using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using System.Drawing;

namespace ToDoList
{
    public partial class Register : Form
    {
        private string _userName { get; set; } 
        private string _password { get; set; } 
        public Register()
        {
            InitializeComponent();
        }
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            _userName = UsernameText.Text?.Trim();
            _password = PasswordText.Text?.Trim();

            if (string.IsNullOrEmpty(_userName) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Empty");
                return;
            }
            if (_userName.ToCharArray().Length <= 6 || _password.ToCharArray().Length <= 6 || _userName.ToCharArray().Length >= 16 || _password.ToCharArray().Length >= 20)
            {
                MessageBox.Show("Min Characters 7 | Max Characters 16");
                return;
            }
            if (string.IsNullOrWhiteSpace(_userName) || string.IsNullOrWhiteSpace(_password) || _userName.Contains(" ") || _password.Contains(" "))
            {
                MessageBox.Show("Cant Have Spaces!");
                return;
            }

            string passwordHash = HashPassword(_password);

            // Save to the database
            try
            {
                using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Microsoft SQL Server"].ConnectionString))
                {
                    conn.Open();

                    string checkUser = "SELECT COUNT(*) FROM USERS WHERE USERNAME = @UserName";
                    using (SqlCommand cmdUser = new SqlCommand(checkUser, conn))
                    {
                        cmdUser.Parameters.AddWithValue("@UserName", _userName);
                        int userCount = (int)cmdUser.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Account Already Exist!");
                            return;
                        }
                    }

                    string query = "INSERT INTO Users (UserName, PasswordHash) VALUES (@UserName, @PasswordHash)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", _userName);
                        cmd.Parameters.AddWithValue("@PasswordHash", passwordHash);
                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Registration Successful!");
                            this.Hide();
                            Login login = new Login(_userName, _password);
                            login.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Registration Failed. Please Try Again.");
                        }
                    }                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }         
        }
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }

        private void LoginMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login(_userName, _password);
            login.ShowDialog();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }            
        public void PaintForm(Graphics g)
        {           
            Color color1 = ColorTranslator.FromHtml("#E6DADA"); // Gradient color
            Color color2 = ColorTranslator.FromHtml("#274046");

            //LinearGradient Brush
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle, color1, color2, LinearGradientMode.Vertical))
            {
                g.FillRectangle(brush, this.ClientRectangle);
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            PaintForm(e.Graphics);
        }
    }
}

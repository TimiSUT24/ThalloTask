using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Configuration;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

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
        private void button1_Click(object sender, EventArgs e)
        {
            _userName = UsernameText.Text?.Trim();
            _password = PasswordText.Text?.Trim();

            if (string.IsNullOrEmpty(_userName) || string.IsNullOrEmpty(_password))
            {
                MessageBox.Show("Empty");
                return;
            }
            if (_userName.ToCharArray().Length <= 6 || _password.ToCharArray().Length <= 6)
            {
                MessageBox.Show("Username and password need to be 7 characters long");
                return;
            }
            if (string.IsNullOrWhiteSpace(_userName) || string.IsNullOrWhiteSpace(_password) || _userName.Contains(" ") || _password.Contains(" "))
            {
                MessageBox.Show("Cant have spaces");
                return;
            }

            string passwordHash = HashPassword(_password);

            // Save to the database
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft SQL Server"].ConnectionString))
            {               
                try
                {
                    conn.Open();

                    string checkUser = "SELECT COUNT(*) FROM USERS WHERE USERNAME = @UserName";
                    using (SqlCommand cmdUser = new SqlCommand(checkUser, conn))
                    {
                        cmdUser.Parameters.AddWithValue("@UserName", _userName);
                        int userCount = (int)cmdUser.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Account already exist");
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
                            MessageBox.Show("Registration successful!");
                            Login login = new Login(_userName, _password);
                            login.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
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

        private void button2_Click(object sender, EventArgs e)
        {
            Login login = new Login(_userName, _password);
            login.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
       
    }
}

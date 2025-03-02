using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using Microsoft.Data.SqlClient;

namespace ToDoList
{
    public partial class Login : Form
    {
        public Login(string userName, string password)
        {
            InitializeComponent();
        }
        private void LoginBtn_Click_1(object sender, EventArgs e)
        {
            string username = UsernameText.Text;
            string password = PasswordText.Text;

            ValidateUser(username, password);
        }
        private bool ValidateUser(string userName, string password)
        {
            string passwordHash = HashPassword(password);

            // Query the database to get the stored password hash
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft SQL Server"].ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT PasswordHash FROM Users WHERE UserName = @UserName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        string storedHash = cmd.ExecuteScalar() as string;
                        conn.Close();
                        if (storedHash != null && storedHash == passwordHash)
                        {
                            MessageBox.Show("Successful Login");
                            this.Hide();
                            UserMenu usermenu = new UserMenu(userName);
                            usermenu.ShowDialog();
                            this.Close();
                            return true; // Passwords match
                        }
                        else
                        {
                            MessageBox.Show("Wrong Password Or Username");
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An Error Occurred: {ex.Message}");
            }
            return false; // Passwords don't match or user doesn't exist
        }
        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
        private void RegisterMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Application.Exit();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var paint = new Register();
            paint.PaintForm(e.Graphics);
        }    
    }
}

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
        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            ValidateUser(username, password);           
        }
        private bool ValidateUser(string userName, string password)
        {
            string passwordHash = HashPassword(password);

            // Query the database to get the stored password hash
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft SQL Server"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT PasswordHash FROM Users WHERE UserName = @UserName";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", userName);
                        string storedHash = cmd.ExecuteScalar() as string;

                        if (storedHash != null && storedHash == passwordHash)
                        {
                            UserMenu usermenu = new UserMenu(userName);
                            MessageBox.Show("Successful login");                           
                            usermenu.Show();
                            this.Hide();
                            return true; // Passwords match
                        }
                        else
                        {
                            MessageBox.Show("Wrong password or username");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
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
        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }        
    }
}

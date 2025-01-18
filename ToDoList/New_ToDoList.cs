using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class New_ToDoList : Form
    {
        private string currentUser { get; set; }
        public New_ToDoList(string userName)
        {
            InitializeComponent();
            currentUser = userName;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public int GetUserID(string userName)
        {
            int userId = -1;
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                conn.Open();
                string SelectId = "SELECT ID FROM USERS WHERE USERNAME = @USERNAME";
                using (SqlCommand cmd = new SqlCommand(SelectId, conn))
                {
                    cmd.Parameters.AddWithValue("@USERNAME", currentUser);
                    object user = cmd.ExecuteScalar();
                    if (user != null)
                    {
                        userId = Convert.ToInt32(user);
                    }
                    else
                    {
                        MessageBox.Show("Error null");
                    }
                }
            }
            return userId;
        }
        private void AddTask_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Task cannot be empty");
                return;
            }

            int userId = GetUserID(currentUser);

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                try
                {
                    conn.Open();

                    string addTask = "INSERT INTO TASKS(TASK,DESCRIPTION,PRIORITY,DATESTART,DATEEND,USER_ID) VALUES (@TASK,@DESCRIPTION,@PRIORITY,@DATESTART,@DATEEND,@USER_ID)";
                    using (SqlCommand cmd = new SqlCommand(addTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", textBox1.Text);
                        cmd.Parameters.AddWithValue("@DESCRIPTION", richTextBox1.Text);
                        cmd.Parameters.AddWithValue("@PRIORITY", listBox1.Text);
                        cmd.Parameters.AddWithValue("@USER_ID", userId);
                        cmd.Parameters.AddWithValue("@DATESTART", dateTimePicker1.Value.Date);
                        cmd.Parameters.AddWithValue("@DATEEND", dateTimePicker2.Value.Date);
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("till lagt");
                        }
                        else
                        {
                            MessageBox.Show("fel");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured " + ex.Message);
                }
            }


        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

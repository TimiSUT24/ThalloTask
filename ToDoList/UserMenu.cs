using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ToDoList
{
    public partial class UserMenu : Form
    {
        private string currentUser { get; set; }
        private int userId { get; set; }
        private string task { get; set; }

        public UserMenu(string userName)
        {
            InitializeComponent();
            currentUser = userName;
            ShowName();
            ShowTasks();
        }
        private void RegisterShow_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }

        private void UserMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = currentUser;
            NewTask ToDo = new NewTask(userName);
            ToDo.Show();
        }

        public void ShowName()
        {
            label2.Text = "Logged in as " + currentUser;
        }

        private void Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            task = Tasks.Items[Tasks.SelectedIndex].ToString(); //Gets the selected id
        }
        private void ShowSelectedTask_Click(object sender, EventArgs e)
        {
            ShowTaskDetails();
        }
        private void ShowTaskDetails()
        {
            NewTask to = new NewTask(currentUser);
            userId = to.GetUserID(currentUser);

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                try
                {
                    conn.Open();
                    string showTask = "SELECT ID,TASK,DESCRIPTION,PRIORITY,DATESTART,DATEEND FROM TASKS WHERE TASK = @TASK"; //Shows the selected task details
                    using (SqlCommand cmd = new SqlCommand(showTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string task1 = reader["TASK"].ToString();
                                string description = reader["DESCRIPTION"].ToString();
                                string priority = reader["PRIORITY"].ToString();
                                string datestart = reader["DATESTART"].ToString();
                                string dateEnd = reader["DATEEND"].ToString();
                                MessageBox.Show($" Task: {task1}\n\n Description: {description}\n\n Priority: {priority}\n\n DateStart: {datestart}\n DateEnd: {dateEnd}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Please Select a Task");
                }
            }
        }
        private void ShowTasks()
        {
            NewTask to = new NewTask(currentUser);
            userId = to.GetUserID(currentUser);     //Get which user is logged in and gets id 

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                conn.Open();
                string task = "SELECT TASK FROM TASKS WHERE USER_ID = @USER_ID";
                using (SqlCommand cmd = new SqlCommand(task, conn))
                {
                    cmd.Parameters.AddWithValue("@USER_ID", userId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())                   //read from database to code and add items to list
                        {
                            string item = reader["TASK"].ToString();
                            Tasks.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void Tasks_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowTaskDetails();
        }

        private void EditTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (task == Tasks.Items[Tasks.SelectedIndex].ToString())
                {
                    MessageBox.Show(task);                 
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Select a task to edit");
            }
          
        }
      
    }
}

using CuoreUI;
using CuoreUI.Controls;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ToDoList
{
    public partial class UserMenu : Form
    {
        private string CurrentUser { get; set; }
        private int UserId { get; set; }
        public string task { get; set; }
        public string AllTasks { get; set; }

        public string nl = "\r\n \r\n";

        public string TaskTxt { get; set; }

        public UserMenu(string userName)
        {
            InitializeComponent();
            CurrentUser = userName;
            ShowName();
            ShowTasks();

        }
         public UserMenu(string userName, string taskTxt) : this(userName)
         {            
             TaskTxt = taskTxt;
         }
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }
        private void UserMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
          Application.Exit();
        }
        private void NewTask_Click(object sender, EventArgs e)
        {
            string userName = CurrentUser;
            NewTask ToDo = new NewTask(userName);
            ToDo.ShowDialog();          
        }
        public void ShowName()
        {
            if (TextUser.Content.Length > TextUser.Content.Length)
            {
                ContentAlignment.MiddleLeft.ToString();
            }
            TextUser.Content = "Logged in as " + CurrentUser;
        }

        public void Tasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tasks.SelectedIndex != -1)
            {
                task = Tasks.Items[Tasks.SelectedIndex].ToString(); //Gets the selected task
            }
            else
            {
                return;
            }
        }
        public async void ShowTask_Click(object sender, EventArgs e)
        {
            
           await ShowTaskDetails();
            TaskTextBoxForm textBoxForm = new TaskTextBoxForm(CurrentUser,TaskTxt);
            textBoxForm.ShowDialog();
        }
        public async Task ShowTaskDetails()
        {

            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                try
                {
                    await conn.OpenAsync();
                    string showTask = "SELECT ID,TASK,DESCRIPTION,PRIORITY,DATESTART,DATEEND FROM TASKS WHERE TASK = @TASK"; //Shows the selected task details
                    using (SqlCommand cmd = new SqlCommand(showTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (reader.Read())
                            {
                                string task1 = reader["TASK"].ToString();
                                string description = reader["DESCRIPTION"].ToString();
                                string priority = reader["PRIORITY"].ToString();
                                string datestart = reader["DATESTART"].ToString();
                                string dateEnd = reader["DATEEND"].ToString();
                                TaskTxt = $"Task: {task1}{nl} Description: {description}{nl} Priority: {priority}{nl} DateStart: {datestart}{nl} DateEnd: {dateEnd}";
                            }
                        }
                    }
                   await conn.CloseAsync();
                }
                catch
                {
                    MessageBox.Show("Please Select a Task");
                }
            }
        }
        public void ShowTasks()
        {
            try
            {
                NewTask to = new NewTask(CurrentUser);
                UserId = to.GetUserID(CurrentUser);     //Get which user is logged in and gets id 

                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
                {
                    conn.Open();
                    string task = @"SELECT TASK FROM TASKS WHERE USER_ID = @USER_ID
                                ORDER BY 
                                (CASE
                                    WHEN PRIORITY = 'HIGH' THEN 1 
                                    WHEN PRIORITY = 'MEDIUM' THEN 2   
                                    WHEN PRIORITY = 'LOW' THEN 3   
                                    ELSE 'NONE'
                                END);
                                ";

                    using (SqlCommand cmd = new SqlCommand(task, conn))
                    {
                        cmd.Parameters.AddWithValue("@USER_ID", UserId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())                   //read from database to code and add items to list
                            {
                                AllTasks = reader["TASK"].ToString();
                                Tasks.Items.Add(AllTasks);
                            }
                        }
                    }
                    conn.Close();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
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
                    EditTask editTask = new EditTask(CurrentUser, task);
                    editTask.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("Please Select a task to edit");
            }
        }
        public async Task DeleteConformation()
        {
            await Task.Delay(1000);
        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                var choice = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (choice == DialogResult.No)
                {
                    return;
                }
                else if (choice == DialogResult.Yes)
                {
                    await DeleteConformation();
                }

                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
                {
                    conn.Open();
                    string deleteTask = @"DELETE FROM TASKS WHERE TASK = @TASK";
                    using (SqlCommand cmd = new SqlCommand(deleteTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);

                        cmd.ExecuteNonQuery();

                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
            Tasks.Items.Clear();
            ShowTasks();
        }
        private void ReloadButton_Click_1(object sender, EventArgs e)
        {
            Tasks.Items.Clear();
            ShowTasks();
        }
        private void UserMenu_MouseClick(object sender, MouseEventArgs e)
        {           
            Tasks.SelectedIndex = -1;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var paint = new Register();
            paint.PaintForm(e.Graphics);
        }
     
    }
}
    
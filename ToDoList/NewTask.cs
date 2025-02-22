using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic.Devices;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ToDoList
{
    public partial class NewTask : Form
    {
        private string CurrentUser { get; set; }
        private string SubList { get; set; }
        public NewTask(string userName)
        {
            InitializeComponent();
            CurrentUser = userName;         
        }
        public int GetUserID(string userName)
        {
            int userId = -1;
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                conn.Open();
                string SelectId = "SELECT ID FROM USERS WHERE USERNAME = @USERNAME";        //get userid by username
                using (SqlCommand cmd = new SqlCommand(SelectId, conn))
                {
                    cmd.Parameters.AddWithValue("@USERNAME", CurrentUser);
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
                conn.Close();
            }
            return userId;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Register newTask = new Register();
            newTask.PaintForm(e.Graphics);
        }

        private async void AddTask_Click(object sender, EventArgs e)
        {
            await AddTask();
        }
        public async Task AddTask()
        {
            if (string.IsNullOrEmpty(TaskText.Content) || string.IsNullOrWhiteSpace(TaskText.Content))
            {
                MessageBox.Show("Task cannot be empty");
                return;
            }
            var task = new UserMenu(CurrentUser);
            if (TaskText.Content == task.AllTasks)
            {
                MessageBox.Show("Task already exist!");
                return;
            }

            if (PriorityList.SelectedIndex == -1)
            {
                PriorityList.SelectedIndex = 2;
            }
            int userId = GetUserID(CurrentUser);

            int taskId = -1;
            
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                try
                {
                     await conn.OpenAsync();

                    string addTask = @"INSERT INTO TASKS(TASK,DESCRIPTION,PRIORITY,DATESTART,DATEEND,USER_ID) 
                                     OUTPUT INSERTED.ID
                                     VALUES (@TASK,@DESCRIPTION,@PRIORITY,@DATESTART,@DATEEND,@USER_ID)";
                    
                    using (SqlCommand cmd = new SqlCommand(addTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", TaskText.Content);                //Insert these values to the database 
                        cmd.Parameters.AddWithValue("@DESCRIPTION", DescriptionText.Content);
                        cmd.Parameters.AddWithValue("@PRIORITY", PriorityList.Text);
                        cmd.Parameters.AddWithValue("@USER_ID", userId);
                        cmd.Parameters.AddWithValue("@DATESTART", StartDatePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@DATEEND", EndDatePicker.Value.Date);                                           
                        taskId = (int)await cmd.ExecuteScalarAsync();
                        if (taskId > 0)
                        {
                            MessageBox.Show("Task added");
                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    string addList = @"INSERT INTO SUBTASKS(SUBTASK,TASKID) VALUES(@SUBTASK,@TASKID)";
                    foreach(var items in SubTasks.Items)
                    {
                        using (SqlCommand cmd = new SqlCommand(addList, conn))
                        {
                            cmd.Parameters.AddWithValue("@TASKID",taskId);
                            cmd.Parameters.AddWithValue("@SUBTASK",items.ToString());
                            await cmd.ExecuteNonQueryAsync();
                        }
                    }
                   await conn.CloseAsync();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured " + ex.Message);
                }
            }
        }
        private void NewTask_MouseClick(object sender, MouseEventArgs e)
        {
            Focuslabel3.Focus();
        }
        private void SubTaskAddBtn_Click(object sender, EventArgs e)
        {
            SubTasks.Items.Add(SubTasksText.Content);
        }
        private void SubTaskText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SubTasksText.Content.Length >= 48 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void SubTaskDelBtn_Click(object sender, EventArgs e)
        {
            SubList = SubTasks.Items[SubTasks.SelectedIndex].ToString();
            SubTasks.Items.Remove(SubList);
        }         
    }
}

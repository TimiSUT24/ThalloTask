using CuoreUI;
using CuoreUI.Controls;
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
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
        public string CompDesc { get; set; }
        public string CompPri { get; set; }
        public List<string> CompSubTask = new List<string>();
        public string CompIndex { get; set; }

        public UserMenu(string userName)
        {
            InitializeComponent();
            CurrentUser = userName;
            ShowName();
            ShowTasks();
            DueDates();
            ShowCompTasks();
        }
        public UserMenu(string userName, string taskTxt) : this(userName)
        {
            TaskTxt = taskTxt;
        }
        //MAIN SECTION
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
            TextUser.Content = "Logged in as " + CurrentUser;
        }
        public void Tasks_SelectedIndexChanged(object sender)
        {
            RecurringTaskList.SelectedIndex = -1;
            if (Tasks.SelectedIndex != -1)
            {
                task = Tasks.Items[Tasks.SelectedIndex].ToString(); //Gets the selected task
            }
            else
            {
                return;
            }
            ActiveSubList.Clear();
            CompletedSubTasks.Items.Clear();
            ShowSubTasksCompleted();
            ShowActiveSubTasks();

        }
        public async void ShowTask_Click(object sender, EventArgs e)
        {
            if (Tasks.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select A Task!");
                return;
            }
            await ShowTaskDetails();
            TaskInfo textBoxForm = new TaskInfo(CurrentUser, TaskTxt);
            textBoxForm.ShowDialog();
        }
        public async Task ShowTaskDetails()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                {
                    await conn.OpenAsync();
                    string showTask = "SELECT ID,TASK,DESCRIPTION,PRIORITY,DATESTART,DATEEND FROM TASKS WHERE TASK = @TASK"; //Shows the selected task details
                    using (SqlCommand cmd = new SqlCommand(showTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                string task1 = reader["TASK"].ToString();
                                string description = reader["DESCRIPTION"].ToString();
                                string priority = reader["PRIORITY"].ToString();
                                string datestart = reader["DATESTART"].ToString();
                                string dateEnd = reader["DATEEND"].ToString();
                                TaskTxt = $"Task: {task1}{nl}Description: {description}{nl}Priority: {priority}{nl}DateStart: {datestart}{nl}DateEnd: {dateEnd}";
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Please Select A Task!");
            }
        }
        public void ShowTasks()
        {
            try
            {                
                NewTask to = new NewTask(CurrentUser);
                UserId = to.GetUserID(CurrentUser);     //Get which user is logged in and gets id 

                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
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
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
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
                MessageBox.Show("Please Select A Task To Edit!");
            }
        }
        public async Task DeleteConformation()
        {
            await System.Threading.Tasks.Task.Delay(1000);
        }
        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tasks.Items[Tasks.SelectedIndex].ToString() == null) { }
            }
            catch
            {
                MessageBox.Show("Please Select A Task To Delete!");
                return;
            }
            try
            {
                var choice = MessageBox.Show("Are You Sure You Want To Delete?", "Confirm Delete",
                                  MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (choice == DialogResult.No)
                {
                    return;
                }
                else if (choice == DialogResult.Yes)
                {
                    await DeleteConformation();
                }

                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                {
                    await conn.OpenAsync();
                    string deleteTask = @"DELETE FROM TASKS WHERE TASK = @TASK";
                    using (SqlCommand cmd = new SqlCommand(deleteTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);
                        await cmd.ExecuteNonQueryAsync();
                        Tasks.SelectedIndex = -1;
                        ActiveSubList.Items.Clear();
                        CompletedSubTasks.Items.Clear();
                        DueDatesList.Items.Clear();
                        DueDates();
                    }
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
            DueDatesList.Items.Clear();
            Tasks.SelectedIndex = -1;
            Tasks.Items.Clear();
            RecurringTaskList.Items.Clear();
            CompletedSubTasks.Items.Clear();
            ActiveSubList.Items.Clear();
            ShowTasks();
            DueDates();
            ShowCompTasks();
            ShowSubTasksCompleted();
        }
        private void UserMenu_MouseClick(object sender, MouseEventArgs e)
        {
            Tasks.SelectedIndex = -1;
            RecurringTaskList.SelectedIndex = -1;
            DueDatesList.SelectedIndex = -1;
            CompletedSubTasks.SelectedIndex = -1;
            ActiveSubList.SelectedIndex = -1;
            CompletedSubTasks.Items.Clear();
            ActiveSubList.Items.Clear();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            var paint = new Register();
            paint.PaintForm(e.Graphics);
        }

        // SUBTASK SECTION 

        public void ShowSubTasksCompleted()
        {
            try
            {
                if(task != null)
                {
                    using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                    {
                        conn.Open();
                        string ShowSubTask = @"SELECT SUBTASKDONE FROM COMPLETEDSUBTASKS
                                       JOIN TASKS ON TASKS.ID = COMPLETEDSUBTASKS.SUBID
                                       WHERE TASK = @TASK
                                       ORDER BY SUBTASKDONE ASC";
                        using (SqlCommand cmd = new SqlCommand(ShowSubTask, conn))
                        {
                            cmd.Parameters.AddWithValue("@TASK", task);

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string subTasks = reader["SUBTASKDONE"].ToString();
                                    CompletedSubTasks.Items.Add(subTasks);

                                }
                            }
                        }
                    }
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        public void ShowActiveSubTasks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                {
                    conn.Open();
                    string ActiveSubTask = @"SELECT SUBTASK FROM SUBTASKS
                                           JOIN TASKS ON TASKS.ID = SUBTASKS.TASKID
                                           WHERE TASK = @TASK";
                    using (SqlCommand cmd = new SqlCommand(ActiveSubTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string ActiveSubTasks = reader["SUBTASK"].ToString();                               
                                ActiveSubList.Items.Add(ActiveSubTasks);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        
        //DUE DATE METHOD
        public void DueDates()
        {
            try
            {
                NewTask to = new NewTask(CurrentUser);
                UserId = to.GetUserID(CurrentUser);

                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                {
                    conn.Open();
                    string DueDate = @"SELECT DATEEND,TASK
                                     FROM TASKS
                                     WHERE DATEDIFF(DAY,GETDATE(),DATEEND) BETWEEN 0 AND 3
                                     AND USER_ID = @USER_ID";
                    using (SqlCommand cmd = new SqlCommand(DueDate, conn))
                    {
                        cmd.Parameters.AddWithValue("@USER_ID", UserId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string dates = reader["DATEEND"].ToString();
                                string tasks = reader["TASK"].ToString();                              
                                DueDatesList.Items.Add(tasks + ": " + dates);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        //COMPLETED TASKS SECTION WITH DELETE AND RECUR METHODS
        private async void MarkAsCompBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Tasks.Items[Tasks.SelectedIndex].ToString() == null) { }
                await CompletedTasks();
                RecurringTaskList.Items.Clear();
                CompletedSubTasks.Items.Clear();
                ActiveSubList.Items.Clear();
                DueDatesList.Items.Clear();
                DueDates();
                ShowCompTasks();
            }
            catch
            {
                MessageBox.Show("Select A Task To Complete!");
            }
        }

        public async Task CompletedTasks()
        {
            try
            {
                NewTask to = new NewTask(CurrentUser);
                UserId = to.GetUserID(CurrentUser);
                int CompTaskId = -1;
                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                {
                    await conn.OpenAsync();
                    string selectTask = @"SELECT TASK,DESCRIPTION,PRIORITY
                                        FROM TASKS                                         
                                        WHERE TASK = @TASK";
                    using (SqlCommand cmd = new SqlCommand(selectTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                CompDesc = reader["DESCRIPTION"].ToString();
                                CompPri = reader["PRIORITY"].ToString();

                            }
                        }
                    }
                    string compTask = @"INSERT INTO COMPLETEDTASKS(COMPTASK,COMPDESCRIPTION,COMPPRIORITY,USERID)
                                       OUTPUT INSERTED.ID
                                       VALUES(@COMPTASK,@COMPDESCRIPTION,@COMPPRIORITY,@USERID)";
                    using (SqlCommand cmd2 = new SqlCommand(compTask, conn))
                    {
                        cmd2.Parameters.AddWithValue("@COMPTASK", task);
                        cmd2.Parameters.AddWithValue("@COMPDESCRIPTION", CompDesc);
                        cmd2.Parameters.AddWithValue("@COMPPRIORITY", CompPri);
                        cmd2.Parameters.AddWithValue("@USERID", UserId);

                        CompTaskId = (int)await cmd2.ExecuteScalarAsync();

                    }

                    if (CompletedSubTasks.Items.Count > 0)
                    {
                        string reccurSubTask = @"INSERT INTO RECURRINGSUBTASK (COMPSUBTASK,COMPTASKID) 
                                               VALUES (@COMPSUBTASK,@COMPTASKID)";

                        foreach (var item in CompletedSubTasks.Items)
                        {
                            using (SqlCommand cmd3 = new SqlCommand(reccurSubTask, conn))
                            {
                                cmd3.Parameters.AddWithValue("@COMPSUBTASK", item.ToString());
                                cmd3.Parameters.AddWithValue("@COMPTASKID", CompTaskId);

                                await cmd3.ExecuteNonQueryAsync();
                            }
                        }
                    }

                    string deleteCurrentTask = @"DELETE FROM TASKS WHERE TASK = @TASK";
                    using (SqlCommand cmd4 = new SqlCommand(deleteCurrentTask, conn))
                    {
                        cmd4.Parameters.AddWithValue("@TASK", task);
                        await cmd4.ExecuteNonQueryAsync();
                        Tasks.Items.Clear();
                        ShowTasks();
                        Tasks.SelectedIndex = -1;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void CompDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (RecurringTaskList.Items[RecurringTaskList.SelectedIndex].ToString() == null) { }
                CompDelete();
            }
            catch
            {
                MessageBox.Show("Select Available Task!");
            }
        }

        public void CompDelete()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                {
                    conn.Open();
                    string CompDel = @"DELETE FROM COMPLETEDTASKS WHERE COMPTASK = @COMPTASK";

                    using (SqlCommand cmd = new SqlCommand(CompDel, conn))
                    {
                        cmd.Parameters.AddWithValue("@COMPTASK", CompIndex);
                        cmd.ExecuteNonQuery();
                        RecurringTaskList.Items.Remove(CompIndex);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        public void ShowCompTasks()
        {
            try
            {
                NewTask to = new NewTask(CurrentUser);
                UserId = to.GetUserID(CurrentUser);
                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                {
                    conn.Open();
                    string ShowComp = @"SELECT COMPTASK FROM COMPLETEDTASKS WHERE USERID = @USERID";

                    using (SqlCommand cmd = new SqlCommand(ShowComp, conn))
                    {
                        cmd.Parameters.AddWithValue("@USERID", UserId);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string compTask = reader["COMPTASK"].ToString();
                                RecurringTaskList.Items.Add(compTask);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void RecurringTaskList_SelectedIndexChanged(object sender)
        {
            Tasks.SelectedIndex = -1;
            if (RecurringTaskList.SelectedIndex != -1 && RecurringTaskList.SelectedIndex != null)
            {
                CompIndex = RecurringTaskList.Items[RecurringTaskList.SelectedIndex].ToString();
            }
            else
            {
                return;
            }

        }
        public async Task RecurrTask()
        {
            try
            {
                int taskId = -1;
                NewTask to = new NewTask(CurrentUser);
                UserId = to.GetUserID(CurrentUser);
                using (SqlConnection conn = new SqlConnection(SKClass.GetConnectionString()))
                {
                    await conn.OpenAsync();

                    string selectCompTask = @"SELECT COMPTASK,COMPDESCRIPTION,COMPPRIORITY,COMPSUBTASK FROM COMPLETEDTASKS 
                                            LEFT JOIN RECURRINGSUBTASK ON RECURRINGSUBTASK.COMPTASKID = COMPLETEDTASKS.ID
                                            WHERE COMPTASK = @COMPTASK AND USERID = @USERID";
                    using (SqlCommand cmd = new SqlCommand(selectCompTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@COMPTASK", CompIndex);
                        cmd.Parameters.AddWithValue("@USERID", UserId);
                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                CompDesc = reader["COMPDESCRIPTION"].ToString();
                                CompPri = reader["COMPPRIORITY"].ToString();
                                string subTask = reader["COMPSUBTASK"].ToString();
                                CompSubTask.Add(subTask);

                            }
                        }
                    }
                    string insertComp = @"INSERT INTO TASKS(TASK,DESCRIPTION,PRIORITY,DATESTART,DATEEND,USER_ID)
                                        OUTPUT INSERTED.ID
                                        VALUES(@TASK,@DESCRIPTION,@PRIORITY,@DATESTART,@DATEEND,@USER_ID)";

                    using (SqlCommand cmd2 = new SqlCommand(insertComp, conn))
                    {
                        cmd2.Parameters.AddWithValue("@TASK", CompIndex);
                        cmd2.Parameters.AddWithValue("@DESCRIPTION", CompDesc);
                        cmd2.Parameters.AddWithValue("@PRIORITY", CompPri);
                        cmd2.Parameters.AddWithValue("@USER_ID", UserId);
                        cmd2.Parameters.AddWithValue("@DATESTART", DateTime.Now);
                        cmd2.Parameters.AddWithValue("@DATEEND", DateTime.Now);
                        taskId = (int)await cmd2.ExecuteScalarAsync();
                    }

                    if (CompSubTask.Count > 0)
                    {
                        string insertCompSub = @"INSERT INTO SUBTASKS (SUBTASK,TASKID) VALUES (@SUBTASK,@TASKID)";
                        foreach(var item in CompSubTask)
                        {
                            using (SqlCommand cmd3 = new SqlCommand(insertCompSub, conn))
                            {
                                cmd3.Parameters.AddWithValue("@SUBTASK", item.ToString());
                                cmd3.Parameters.AddWithValue("@TASKID", taskId);
                                await cmd3.ExecuteNonQueryAsync();
                            }
                        }                      
                    }
                    Tasks.Items.Clear();
                    ShowTasks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private async void RecurringBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (RecurringTaskList.Items[RecurringTaskList.SelectedIndex].ToString() == null) { }
                await RecurrTask();
                CompDelete();
                DueDatesList.Items.Clear();
                DueDates();
                RecurringTaskList.SelectedIndex = -1;
            }
            catch
            {
                MessageBox.Show("Select Available Task!");
            }
        }
    }
}   
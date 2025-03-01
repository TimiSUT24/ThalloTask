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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ToDoList
{
    public partial class EditTask : Form
    {
        private string CurrentUser { get; set; }
        private string task { get; set; }
        private string Description { get; set; }
        private string Priority { get; set; }
        private DateTime dateStart { get; set; }
        private DateTime dateEnd { get; set; }
        public string SubTask { get; set; }
        public string SubId { get; set; }
        public string SelectedSubItem { get; set; }
        public string SbId { get; set; }


        public EditTask(string userName, string Tasks)
        {
            InitializeComponent();
            CurrentUser = userName;
            task = Tasks;
            TaskLabel.Content = "Current Task: \n" + task;
            ShowDetailsInText();
        }

        public void ShowDetailsInText()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
                {
                    conn.Open();
                    string showDetails = "SELECT DESCRIPTION,PRIORITY,DATESTART,DATEEND FROM TASKS WHERE TASK = @TASK";
                    using (SqlCommand cmd = new SqlCommand(showDetails, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                DescriptionText.Content = reader["DESCRIPTION"].ToString();
                                PriorityList.Text = reader["PRIORITY"].ToString();
                                DateStart.Value = Convert.ToDateTime(reader["DATESTART"]).Date;
                                DateEnd.Value = Convert.ToDateTime(reader["DATEEND"]).Date;
                            }
                        }
                    }
                    string showSubTasks = @"SELECT SUBTASK FROM SUBTASKS
                                       JOIN TASKS ON TASKS.ID = SUBTASKS.TASKID
                                       WHERE TASK = @TASK";
                    using (SqlCommand cmd = new SqlCommand(showSubTasks, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);

                        using (SqlDataReader reader2 = cmd.ExecuteReader())
                        {
                            while (reader2.Read())
                            {
                                string subTasks = reader2["SUBTASK"].ToString();
                                SubTasks.Items.Add(subTasks);
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
        private void EditTasks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
                {
                    conn.Open();
                    string editTask = @"UPDATE TASKS SET DESCRIPTION = @DESCRIPTION, PRIORITY = @PRIORITY, 
                                   DATESTART = @DATESTART, DATEEND = @DATEEND WHERE TASK = @TASK";

                    using (SqlCommand cmd = new SqlCommand(editTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);
                        cmd.Parameters.AddWithValue("@DESCRIPTION", Description);
                        cmd.Parameters.AddWithValue("@PRIORITY", Priority);
                        cmd.Parameters.AddWithValue("@DATESTART", dateStart);
                        cmd.Parameters.AddWithValue("@DATEEND", dateEnd);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }       
        }
        private void EdittedDetails()
        {
            Description = DescriptionText.Content;
            Priority = PriorityList.Text;
            dateStart = DateStart.Value.Date;
            dateEnd = DateEnd.Value.Date;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            Register newTask = new Register();
            newTask.PaintForm(e.Graphics);
        }

        private void EditsTask_Click(object sender, EventArgs e)
        {
            EdittedDetails();
            EditTasks();
            MessageBox.Show("Sucessful edit");
        }

        private void EditTask_MouseClick(object sender, MouseEventArgs e)
        {
            Focuslabel2.Focus();
            SubTasks.SelectedIndex = -1;
        }

        private async void DoneBtn_Click(object sender, EventArgs e)
        {
            SelectedSubItem = SubTasks.Items[SubTasks.SelectedIndex].ToString();
            await SubTaskOperation();
            SubTasks.Items.Remove(SelectedSubItem);
        }

        public async Task SubTaskOperation()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
                {
                    await conn.OpenAsync();
                    string getTask = @"SELECT SUBTASK,TASKID,ID FROM SUBTASKS WHERE SUBTASK = @SUBTASK ";

                    using (SqlCommand cmd = new SqlCommand(getTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@SUBTASK", SelectedSubItem);

                        using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                        {
                            while (await reader.ReadAsync())
                            {
                                SubTask = reader["SUBTASK"].ToString();
                                SubId = reader["TASKID"].ToString();
                                SbId = reader["ID"].ToString();
                            }
                        }
                    }

                    string addComp = @"INSERT INTO COMPLETEDSUBTASKS (SUBTASKDONE,SUBID)
                                        VALUES (@SUBTASKDONE,@SUBID)";
                    using (SqlCommand cmd = new SqlCommand(addComp, conn))
                    {
                        cmd.Parameters.AddWithValue("@SUBTASKDONE", SelectedSubItem);
                        cmd.Parameters.AddWithValue("@SUBID", SubId);

                        await cmd.ExecuteNonQueryAsync();
                    }

                    string deleteSubTask = @"DELETE FROM SUBTASKS WHERE ID = @ID";

                    using (SqlCommand cmd = new SqlCommand(deleteSubTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", SbId);
                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }          
        }
        public void AddSubTask()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
                {
                    conn.Open();
                    string sel = @"SELECT ID FROM TASKS WHERE TASK = @TASK";
                    using (SqlCommand cmd = new SqlCommand(sel, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASK", task);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                SubId = reader["ID"].ToString();
                            }
                        }
                    }

                    string addTask = @"INSERT INTO SUBTASKS (SUBTASK,TASKID)
                                     VALUES (@SUBTASK,@TASKID)";
                    using (SqlCommand cmd = new SqlCommand(addTask, conn))
                    {
                        cmd.Parameters.AddWithValue("@TASKID", SubId);
                        cmd.Parameters.AddWithValue("@SUBTASK", SubTasksText.Content);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }

        }

        public void SubTaskAddBtn_Click(object sender, EventArgs e)
        {
            SubTasks.Items.Add(SubTasksText.Content);
            AddSubTask();
        }

        public void DeleteSubTask()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
                {
                    conn.Open();
                    string deleteTask = @"DELETE FROM SUBTASKS WHERE SUBTASK = @SUBTASK";

                    using (SqlCommand cmd2 = new SqlCommand(deleteTask, conn))
                    {
                        cmd2.Parameters.AddWithValue("@SUBTASK", SelectedSubItem);
                        cmd2.ExecuteNonQuery();
                    }       
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        public void SubTaskDelBtn_Click(object sender, EventArgs e)
        {
            SelectedSubItem = SubTasks.Items[SubTasks.SelectedIndex].ToString();
            SubTasks.Items.Remove(SelectedSubItem);
            DeleteSubTask();
        }
        private void SubTasksText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (SubTasksText.Content.Length >= 48 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }    
    }
}

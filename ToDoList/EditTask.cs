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
        public EditTask(string userName, string Task)
        {
            InitializeComponent();
            CurrentUser = userName;
            task = Task;
            TaskLabel.Content = "Current Task: \n" + task;
            ShowDetailsInText();
        }
        public void ShowDetailsInText()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                conn.Open();
                string ShowDetails = "SELECT DESCRIPTION,PRIORITY,DATESTART,DATEEND FROM TASKS WHERE TASK = @TASK";
                using (SqlCommand cmd = new SqlCommand(ShowDetails, conn))
                {
                    cmd.Parameters.AddWithValue("@TASK", task);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DescriptionText.Text = reader["DESCRIPTION"].ToString();
                            PriorityList.Text = reader["PRIORITY"].ToString();
                            DateStart.Value = Convert.ToDateTime(reader["DATESTART"]).Date;
                            DateEnd.Value = Convert.ToDateTime(reader["DATEEND"]).Date;
                        }
                    }
                }
                conn.Close();
            }
        }
        private void EditTasks()
        {
            using (SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["Microsoft Sql Server"].ConnectionString))
            {
                conn.Open();
                string editTask = "UPDATE TASKS SET DESCRIPTION = @DESCRIPTION, PRIORITY = @PRIORITY, DATESTART = @DATESTART, DATEEND = @DATEEND WHERE TASK = @TASK";

                using (SqlCommand cmd = new SqlCommand(editTask, conn))
                {
                    cmd.Parameters.AddWithValue("@TASK", task);
                    cmd.Parameters.AddWithValue("@DESCRIPTION", Description);
                    cmd.Parameters.AddWithValue("@PRIORITY", Priority);
                    cmd.Parameters.AddWithValue("@DATESTART", dateStart);
                    cmd.Parameters.AddWithValue("@DATEEND", dateEnd);
                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }
        }      
        private void EdittedDetails()
        {
            Description = DescriptionText.Text;
            Priority = PriorityList.Text;
            dateStart = DateStart.Value.Date;
            dateEnd = DateEnd.Value.Date;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            Register newTask = new Register();
            newTask.PaintForm(e);
        }

        private void EditsTask_Click(object sender, EventArgs e)
        {
            EdittedDetails();
            EditTasks();
            MessageBox.Show("Sucessful edit");
        }
    }
}

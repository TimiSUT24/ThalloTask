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
    public partial class TaskInfo : Form
    {

        public TaskInfo(string userName, string taskTxt)
        {
            InitializeComponent();
            TaskTxtBox.Content = taskTxt;
        }
        private void TextBoxTaskButton_Click(object sender, EventArgs e)
        {          
            this.Close();
        }     
    }

}

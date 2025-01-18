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
    public partial class UserMenu : Form
    {
        private string currentUser { get; set; }
        public UserMenu(string userName)
        {
            InitializeComponent();
            currentUser = userName;
            ShowName();
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
            New_ToDoList ToDo = new New_ToDoList(userName);
            ToDo.Show();
        }

        public virtual void ShowName()
        {
            label2.Text = "Logged in as " + currentUser;
        }           
    }     
}

namespace ToDoList
{
    partial class UserMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            LogoutButton = new Button();
            WelcomeText = new Label();
            NewTask = new Button();
            EditTask = new Button();
            label2 = new Label();
            Tasks = new ListBox();
            ShowSelectedTask = new Button();
            ActiveTasks = new Button();
            DeleteButton = new Button();
            ReloadButton = new Button();
            SuspendLayout();
            // 
            // LogoutButton
            // 
            LogoutButton.Font = new Font("Segoe UI", 12F);
            LogoutButton.Location = new Point(470, 591);
            LogoutButton.Margin = new Padding(4);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(267, 34);
            LogoutButton.TabIndex = 14;
            LogoutButton.Text = "Logout";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += RegisterShow_Click;
            // 
            // WelcomeText
            // 
            WelcomeText.AutoSize = true;
            WelcomeText.Font = new Font("Segoe UI", 18F);
            WelcomeText.Location = new Point(604, 9);
            WelcomeText.Margin = new Padding(4, 0, 4, 0);
            WelcomeText.MinimumSize = new Size(129, 0);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.Size = new Size(295, 32);
            WelcomeText.TabIndex = 15;
            WelcomeText.Text = "Welcome to your ToDoList";
            // 
            // NewTask
            // 
            NewTask.Location = new Point(260, 70);
            NewTask.Name = "NewTask";
            NewTask.Size = new Size(190, 23);
            NewTask.TabIndex = 16;
            NewTask.Text = "New Task";
            NewTask.UseVisualStyleBackColor = true;
            NewTask.Click += button1_Click;
            // 
            // EditTask
            // 
            EditTask.Location = new Point(521, 70);
            EditTask.Name = "EditTask";
            EditTask.Size = new Size(190, 23);
            EditTask.TabIndex = 19;
            EditTask.Text = "Edit Task";
            EditTask.UseVisualStyleBackColor = true;
            EditTask.Click += EditTask_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F);
            label2.Location = new Point(1163, 9);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.MinimumSize = new Size(129, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(129, 32);
            label2.TabIndex = 20;
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // Tasks
            // 
            Tasks.FormattingEnabled = true;
            Tasks.ImeMode = ImeMode.NoControl;
            Tasks.ItemHeight = 15;
            Tasks.Location = new Point(778, 99);
            Tasks.Name = "Tasks";
            Tasks.Size = new Size(190, 199);
            Tasks.TabIndex = 21;        
            Tasks.SelectedIndexChanged += Tasks_SelectedIndexChanged;
            Tasks.MouseDoubleClick += Tasks_MouseDoubleClick;         
            // 
            // ShowSelectedTask
            // 
            ShowSelectedTask.Location = new Point(778, 304);
            ShowSelectedTask.Name = "ShowSelectedTask";
            ShowSelectedTask.Size = new Size(190, 23);
            ShowSelectedTask.TabIndex = 22;
            ShowSelectedTask.Text = "Show";
            ShowSelectedTask.UseVisualStyleBackColor = true;
            ShowSelectedTask.Click += ShowSelectedTask_Click;
            // 
            // ActiveTasks
            // 
            ActiveTasks.Location = new Point(778, 70);
            ActiveTasks.Name = "ActiveTasks";
            ActiveTasks.Size = new Size(190, 23);
            ActiveTasks.TabIndex = 23;
            ActiveTasks.Text = "Active Tasks";
            ActiveTasks.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(1013, 70);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(190, 23);
            DeleteButton.TabIndex = 24;
            DeleteButton.Text = "Delete Task";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // ReloadButton
            // 
            ReloadButton.BackColor = SystemColors.Control;
            ReloadButton.ForeColor = SystemColors.ControlText;
            ReloadButton.Image = (Image)resources.GetObject("ReloadButton.Image");
            ReloadButton.Location = new Point(748, 99);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.Size = new Size(24, 24);
            ReloadButton.TabIndex = 25;
            ReloadButton.UseVisualStyleBackColor = false;
            ReloadButton.Click += ReloadButton_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1443, 680);
            Controls.Add(ReloadButton);
            Controls.Add(DeleteButton);
            Controls.Add(ActiveTasks);
            Controls.Add(ShowSelectedTask);
            Controls.Add(Tasks);
            Controls.Add(label2);
            Controls.Add(EditTask);
            Controls.Add(NewTask);
            Controls.Add(WelcomeText);
            Controls.Add(LogoutButton);
            Name = "UserMenu";
            Text = "UserMenu";
            FormClosing += UserMenu_FormClosing;
            MouseClick += UserMenu_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LogoutButton;
        private Label WelcomeText;
        private Button NewTask;
        private Button EditTask;
        private Label label2;
        public ListBox Tasks;
        private Button ShowSelectedTask;
        private Button ActiveTasks;
        private Button DeleteButton;
        private Button ReloadButton;
    }
}
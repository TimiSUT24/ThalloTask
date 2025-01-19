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
            button3 = new Button();
            label1 = new Label();
            button1 = new Button();
            EditTask = new Button();
            label2 = new Label();
            Tasks = new ListBox();
            ShowSelectedTask = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(604, 591);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(267, 34);
            button3.TabIndex = 14;
            button3.Text = "Logout";
            button3.UseVisualStyleBackColor = true;
            button3.Click += RegisterShow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(604, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.MinimumSize = new Size(129, 0);
            label1.Name = "label1";
            label1.Size = new Size(295, 32);
            label1.TabIndex = 15;
            label1.Text = "Welcome to your ToDoList";
            // 
            // button1
            // 
            button1.Location = new Point(394, 70);
            button1.Name = "button1";
            button1.Size = new Size(190, 23);
            button1.TabIndex = 16;
            button1.Text = "New Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditTask
            // 
            EditTask.Location = new Point(655, 70);
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
            Tasks.ItemHeight = 15;
            Tasks.Location = new Point(912, 99);
            Tasks.Name = "Tasks";
            Tasks.Size = new Size(190, 199);
            Tasks.TabIndex = 21;
            Tasks.SelectedIndexChanged += Tasks_SelectedIndexChanged;
            Tasks.MouseDoubleClick += Tasks_MouseDoubleClick;
            // 
            // ShowSelectedTask
            // 
            ShowSelectedTask.Location = new Point(912, 304);
            ShowSelectedTask.Name = "ShowSelectedTask";
            ShowSelectedTask.Size = new Size(190, 23);
            ShowSelectedTask.TabIndex = 22;
            ShowSelectedTask.Text = "Show";
            ShowSelectedTask.UseVisualStyleBackColor = true;
            ShowSelectedTask.Click += ShowSelectedTask_Click;
            // 
            // button2
            // 
            button2.Location = new Point(912, 70);
            button2.Name = "button2";
            button2.Size = new Size(190, 23);
            button2.TabIndex = 23;
            button2.Text = "Active Tasks";
            button2.UseVisualStyleBackColor = true;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1471, 654);
            Controls.Add(button2);
            Controls.Add(ShowSelectedTask);
            Controls.Add(Tasks);
            Controls.Add(label2);
            Controls.Add(EditTask);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(button3);
            Name = "UserMenu";
            Text = "UserMenu";
            FormClosing += UserMenu_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Label label1;
        private Button button1;
        private Button EditTask;
        private Label label2;
        private ListBox Tasks;
        private Button ShowSelectedTask;
        private Button button2;
    }
}
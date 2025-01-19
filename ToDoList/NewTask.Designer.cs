namespace ToDoList
{
    partial class NewTask
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
            AddTaskButton = new Button();
            TaskLabel = new Label();
            TaskText = new TextBox();
            label2 = new Label();
            DescriptionLabel = new Label();
            PriorityLabel = new Label();
            PriorityList = new ListBox();
            StartDateLabel = new Label();
            DescriptionText = new RichTextBox();
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            EndDateLabel = new Label();
            SuspendLayout();
            // 
            // AddTaskButton
            // 
            AddTaskButton.Location = new Point(32, 448);
            AddTaskButton.Name = "AddTaskButton";
            AddTaskButton.Size = new Size(148, 31);
            AddTaskButton.TabIndex = 0;
            AddTaskButton.Text = "Add Task";
            AddTaskButton.UseVisualStyleBackColor = true;
            AddTaskButton.Click += AddTask_Click;
            // 
            // TaskLabel
            // 
            TaskLabel.AutoSize = true;
            TaskLabel.Font = new Font("Segoe UI", 12F);
            TaskLabel.Location = new Point(32, 27);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(39, 21);
            TaskLabel.TabIndex = 3;
            TaskLabel.Text = "Task";
            // 
            // TaskText
            // 
            TaskText.Font = new Font("Segoe UI", 11F);
            TaskText.Location = new Point(32, 51);
            TaskText.Name = "TaskText";
            TaskText.Size = new Size(204, 27);
            TaskText.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(52, 87);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 5;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 12F);
            DescriptionLabel.Location = new Point(32, 87);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(89, 21);
            DescriptionLabel.TabIndex = 6;
            DescriptionLabel.Text = "Description";
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Font = new Font("Segoe UI", 12F);
            PriorityLabel.Location = new Point(30, 221);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new Size(61, 21);
            PriorityLabel.TabIndex = 8;
            PriorityLabel.Text = "Priority";
            // 
            // PriorityList
            // 
            PriorityList.FormattingEnabled = true;
            PriorityList.ItemHeight = 15;
            PriorityList.Items.AddRange(new object[] { "High", "Medium", "Low", "None" });
            PriorityList.Location = new Point(32, 255);
            PriorityList.Name = "PriorityList";
            PriorityList.Size = new Size(120, 49);
            PriorityList.TabIndex = 10;
            PriorityList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Font = new Font("Segoe UI", 12F);
            StartDateLabel.Location = new Point(32, 317);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(76, 21);
            StartDateLabel.TabIndex = 11;
            StartDateLabel.Text = "Start date";
            // 
            // DescriptionText
            // 
            DescriptionText.Location = new Point(32, 111);
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Size = new Size(238, 96);
            DescriptionText.TabIndex = 13;
            DescriptionText.Text = "";
            // 
            // StartDatePicker
            // 
            StartDatePicker.Location = new Point(32, 341);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(200, 23);
            StartDatePicker.TabIndex = 14;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(32, 404);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(200, 23);
            EndDatePicker.TabIndex = 16;
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Font = new Font("Segoe UI", 12F);
            EndDateLabel.Location = new Point(32, 380);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(70, 21);
            EndDateLabel.TabIndex = 15;
            EndDateLabel.Text = "End date";
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 650);
            Controls.Add(EndDatePicker);
            Controls.Add(EndDateLabel);
            Controls.Add(StartDatePicker);
            Controls.Add(DescriptionText);
            Controls.Add(StartDateLabel);
            Controls.Add(PriorityList);
            Controls.Add(PriorityLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(label2);
            Controls.Add(TaskText);
            Controls.Add(TaskLabel);
            Controls.Add(AddTaskButton);
            Name = "NewTask";
            Text = "New_ToDoList";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddTaskButton;
        private Label TaskLabel;
        public TextBox TaskText;
        private Label label2;
        private Label DescriptionLabel;
        private Label PriorityLabel;
        private ListBox PriorityList;
        private Label StartDateLabel;
        private RichTextBox DescriptionText;
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;
        private Label EndDateLabel;
    }
}
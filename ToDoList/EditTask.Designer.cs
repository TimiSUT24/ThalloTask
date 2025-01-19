namespace ToDoList
{
    partial class EditTask
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
            DateEnd = new DateTimePicker();
            EndDateLabel = new Label();
            DateStart = new DateTimePicker();
            DescriptionText = new RichTextBox();
            StartDateLabel = new Label();
            PriorityList = new ListBox();
            PriorityLabel = new Label();
            DescriptionLabel = new Label();
            label2 = new Label();
            TaskLabel = new Label();
            EditsTask = new Button();
            SuspendLayout();
            // 
            // DateEnd
            // 
            DateEnd.Location = new Point(27, 383);
            DateEnd.Name = "DateEnd";
            DateEnd.Size = new Size(200, 23);
            DateEnd.TabIndex = 28;
            // 
            // EndDateLabel
            // 
            EndDateLabel.AutoSize = true;
            EndDateLabel.Font = new Font("Segoe UI", 12F);
            EndDateLabel.Location = new Point(27, 359);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.Size = new Size(70, 21);
            EndDateLabel.TabIndex = 27;
            EndDateLabel.Text = "End date";
            // 
            // DateStart
            // 
            DateStart.Location = new Point(27, 320);
            DateStart.Name = "DateStart";
            DateStart.Size = new Size(200, 23);
            DateStart.TabIndex = 26;
            // 
            // DescriptionText
            // 
            DescriptionText.Location = new Point(27, 90);
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Size = new Size(238, 96);
            DescriptionText.TabIndex = 25;
            DescriptionText.Text = "";
            // 
            // StartDateLabel
            // 
            StartDateLabel.AutoSize = true;
            StartDateLabel.Font = new Font("Segoe UI", 12F);
            StartDateLabel.Location = new Point(27, 296);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.Size = new Size(76, 21);
            StartDateLabel.TabIndex = 24;
            StartDateLabel.Text = "Start date";
            // 
            // PriorityList
            // 
            PriorityList.FormattingEnabled = true;
            PriorityList.ItemHeight = 15;
            PriorityList.Items.AddRange(new object[] { "High", "Medium", "Low", "None" });
            PriorityList.Location = new Point(27, 234);
            PriorityList.Name = "PriorityList";
            PriorityList.Size = new Size(120, 49);
            PriorityList.TabIndex = 23;
            // 
            // PriorityLabel
            // 
            PriorityLabel.AutoSize = true;
            PriorityLabel.Font = new Font("Segoe UI", 12F);
            PriorityLabel.Location = new Point(25, 200);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.Size = new Size(61, 21);
            PriorityLabel.TabIndex = 22;
            PriorityLabel.Text = "Priority";
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Font = new Font("Segoe UI", 12F);
            DescriptionLabel.Location = new Point(27, 66);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(89, 21);
            DescriptionLabel.TabIndex = 21;
            DescriptionLabel.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(47, 66);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 20;
            // 
            // TaskLabel
            // 
            TaskLabel.AutoSize = true;
            TaskLabel.Font = new Font("Segoe UI", 12F);
            TaskLabel.Location = new Point(27, 9);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(39, 21);
            TaskLabel.TabIndex = 18;
            TaskLabel.Text = "Task";
            // 
            // EditsTask
            // 
            EditsTask.Location = new Point(27, 427);
            EditsTask.Name = "EditsTask";
            EditsTask.Size = new Size(148, 31);
            EditsTask.TabIndex = 17;
            EditsTask.Text = "Edit Task";
            EditsTask.UseVisualStyleBackColor = true;
            EditsTask.Click += EditsTask_Click;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 568);
            Controls.Add(DateEnd);
            Controls.Add(EndDateLabel);
            Controls.Add(DateStart);
            Controls.Add(DescriptionText);
            Controls.Add(StartDateLabel);
            Controls.Add(PriorityList);
            Controls.Add(PriorityLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(label2);
            Controls.Add(TaskLabel);
            Controls.Add(EditsTask);
            Name = "EditTask";
            Text = "EditTask";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DateEnd;
        private Label EndDateLabel;
        private DateTimePicker DateStart;
        private RichTextBox DescriptionText;
        private Label StartDateLabel;
        private ListBox PriorityList;
        private Label PriorityLabel;
        private Label DescriptionLabel;
        private Label label2;
        private Label TaskLabel;
        private Button EditsTask;
    }
}
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
            DateStart = new DateTimePicker();
            label2 = new Label();
            DescriptionLabel = new CuoreUI.Controls.cuiButton();
            TaskLabel = new CuoreUI.Controls.cuiLabel();
            DescriptionText = new CuoreUI.Controls.cuiTextBox2();
            PriorityLabel = new CuoreUI.Controls.cuiButton();
            PriorityList = new TransparentListBox();
            StartDateLabel = new CuoreUI.Controls.cuiButton();
            EndDateLabel = new CuoreUI.Controls.cuiButton();
            EditsTask = new CuoreUI.Controls.cuiButton();
            Focuslabel2 = new CuoreUI.Controls.cuiLabel();
            SubTasks = new TransparentListBox();
            SubTaskDelBtn = new CuoreUI.Controls.cuiButton();
            SubTaskAddBtn = new CuoreUI.Controls.cuiButton();
            SubTasksText = new CuoreUI.Controls.cuiTextBox2();
            DoneBtn = new CuoreUI.Controls.cuiButton();
            SuspendLayout();
            // 
            // DateEnd
            // 
            DateEnd.Location = new Point(33, 442);
            DateEnd.Name = "DateEnd";
            DateEnd.Size = new Size(200, 23);
            DateEnd.TabIndex = 28;
            // 
            // DateStart
            // 
            DateStart.Location = new Point(33, 379);
            DateStart.Name = "DateStart";
            DateStart.Size = new Size(200, 23);
            DateStart.TabIndex = 0;
            DateStart.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(53, 116);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 20;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.BackColor = Color.Transparent;
            DescriptionLabel.CheckButton = false;
            DescriptionLabel.Checked = false;
            DescriptionLabel.CheckedBackground = Color.FromArgb(255, 106, 0);
            DescriptionLabel.CheckedForeColor = Color.White;
            DescriptionLabel.CheckedImageTint = Color.White;
            DescriptionLabel.CheckedOutline = Color.Transparent;
            DescriptionLabel.Content = "Description";
            DescriptionLabel.DialogResult = DialogResult.None;
            DescriptionLabel.Font = new Font("Segoe UI", 12F);
            DescriptionLabel.ForeColor = Color.White;
            DescriptionLabel.HoverBackground = Color.Transparent;
            DescriptionLabel.HoveredImageTint = Color.White;
            DescriptionLabel.HoverForeColor = Color.White;
            DescriptionLabel.HoverOutline = Color.WhiteSmoke;
            DescriptionLabel.Image = null;
            DescriptionLabel.ImageAutoCenter = true;
            DescriptionLabel.ImageExpand = new Point(0, 0);
            DescriptionLabel.ImageOffset = new Point(0, 0);
            DescriptionLabel.ImageTint = Color.White;
            DescriptionLabel.Location = new Point(33, 111);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.NormalBackground = Color.Transparent;
            DescriptionLabel.NormalOutline = Color.WhiteSmoke;
            DescriptionLabel.OutlineThickness = 1F;
            DescriptionLabel.PressedBackground = Color.Transparent;
            DescriptionLabel.PressedForeColor = Color.White;
            DescriptionLabel.PressedImageTint = Color.White;
            DescriptionLabel.PressedOutline = Color.WhiteSmoke;
            DescriptionLabel.Rounding = new Padding(8);
            DescriptionLabel.Size = new Size(97, 26);
            DescriptionLabel.TabIndex = 33;
            DescriptionLabel.TextOffset = new Point(0, 0);
            // 
            // TaskLabel
            // 
            TaskLabel.BackColor = Color.Transparent;
            TaskLabel.Content = "";
            TaskLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            TaskLabel.ForeColor = Color.White;
            TaskLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Left;
            TaskLabel.Location = new Point(33, 49);
            TaskLabel.Margin = new Padding(4, 3, 4, 3);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.Size = new Size(238, 56);
            TaskLabel.TabIndex = 35;
            // 
            // DescriptionText
            // 
            DescriptionText.BackColor = Color.White;
            DescriptionText.BorderColor = Color.WhiteSmoke;
            DescriptionText.BorderFocusColor = Color.Gray;
            DescriptionText.BorderSize = 2;
            DescriptionText.Content = "";
            DescriptionText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DescriptionText.ForeColor = Color.Black;
            DescriptionText.Location = new Point(31, 141);
            DescriptionText.Margin = new Padding(4);
            DescriptionText.Multiline = true;
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Padding = new Padding(15, 5, 15, 5);
            DescriptionText.PasswordChar = false;
            DescriptionText.PlaceholderColor = Color.Transparent;
            DescriptionText.PlaceholderText = "";
            DescriptionText.Rounding = 8;
            DescriptionText.Size = new Size(238, 96);
            DescriptionText.TabIndex = 36;
            DescriptionText.TextOffset = new Size(0, 0);
            DescriptionText.UnderlinedStyle = false;
            // 
            // PriorityLabel
            // 
            PriorityLabel.BackColor = Color.Transparent;
            PriorityLabel.CheckButton = false;
            PriorityLabel.Checked = false;
            PriorityLabel.CheckedBackground = Color.FromArgb(255, 106, 0);
            PriorityLabel.CheckedForeColor = Color.White;
            PriorityLabel.CheckedImageTint = Color.White;
            PriorityLabel.CheckedOutline = Color.Transparent;
            PriorityLabel.Content = "Priority";
            PriorityLabel.DialogResult = DialogResult.None;
            PriorityLabel.Font = new Font("Segoe UI", 12F);
            PriorityLabel.ForeColor = Color.White;
            PriorityLabel.HoverBackground = Color.Transparent;
            PriorityLabel.HoveredImageTint = Color.White;
            PriorityLabel.HoverForeColor = Color.White;
            PriorityLabel.HoverOutline = Color.WhiteSmoke;
            PriorityLabel.Image = null;
            PriorityLabel.ImageAutoCenter = true;
            PriorityLabel.ImageExpand = new Point(0, 0);
            PriorityLabel.ImageOffset = new Point(0, 0);
            PriorityLabel.ImageTint = Color.White;
            PriorityLabel.Location = new Point(33, 252);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.NormalBackground = Color.Transparent;
            PriorityLabel.NormalOutline = Color.WhiteSmoke;
            PriorityLabel.OutlineThickness = 1F;
            PriorityLabel.PressedBackground = Color.Transparent;
            PriorityLabel.PressedForeColor = Color.White;
            PriorityLabel.PressedImageTint = Color.White;
            PriorityLabel.PressedOutline = Color.WhiteSmoke;
            PriorityLabel.Rounding = new Padding(8);
            PriorityLabel.Size = new Size(70, 26);
            PriorityLabel.TabIndex = 37;
            PriorityLabel.TextOffset = new Point(0, 0);
            // 
            // PriorityList
            // 
            PriorityList.BackColor = Color.Transparent;
            PriorityList.BackgroundColor = Color.White;
            PriorityList.BorderStyle = BorderStyle.None;
            PriorityList.DrawMode = DrawMode.OwnerDrawFixed;
            PriorityList.Font = new Font("Microsoft YaHei UI", 9F);
            PriorityList.ForeColor = Color.FromArgb(84, 84, 84);
            PriorityList.ForegroundColor = Color.Black;
            PriorityList.FormattingEnabled = true;
            PriorityList.ItemHeight = 18;
            PriorityList.ItemHoveredBackgroundColor = Color.Transparent;
            PriorityList.ItemHoveredForegroundColor = Color.Black;
            PriorityList.ItemRounding = 8;
            PriorityList.Items.AddRange(new object[] { "High", "Medium", "Low" });
            PriorityList.ItemSelectedBackgroundColor = SystemColors.ActiveCaption;
            PriorityList.Location = new Point(31, 282);
            PriorityList.Margin = new Padding(1);
            PriorityList.Name = "PriorityList";
            PriorityList.Rounding = 8;
            PriorityList.SelectedForegroundColor = Color.Black;
            PriorityList.Size = new Size(156, 54);
            PriorityList.TabIndex = 38;
            // 
            // StartDateLabel
            // 
            StartDateLabel.BackColor = Color.Transparent;
            StartDateLabel.CheckButton = false;
            StartDateLabel.Checked = false;
            StartDateLabel.CheckedBackground = Color.FromArgb(255, 106, 0);
            StartDateLabel.CheckedForeColor = Color.White;
            StartDateLabel.CheckedImageTint = Color.White;
            StartDateLabel.CheckedOutline = Color.Transparent;
            StartDateLabel.Content = "Start Date";
            StartDateLabel.DialogResult = DialogResult.None;
            StartDateLabel.Font = new Font("Segoe UI", 12F);
            StartDateLabel.ForeColor = Color.White;
            StartDateLabel.HoverBackground = Color.Transparent;
            StartDateLabel.HoveredImageTint = Color.White;
            StartDateLabel.HoverForeColor = Color.White;
            StartDateLabel.HoverOutline = Color.WhiteSmoke;
            StartDateLabel.Image = null;
            StartDateLabel.ImageAutoCenter = true;
            StartDateLabel.ImageExpand = new Point(0, 0);
            StartDateLabel.ImageOffset = new Point(0, 0);
            StartDateLabel.ImageTint = Color.White;
            StartDateLabel.Location = new Point(31, 349);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.NormalBackground = Color.Transparent;
            StartDateLabel.NormalOutline = Color.WhiteSmoke;
            StartDateLabel.OutlineThickness = 1F;
            StartDateLabel.PressedBackground = Color.Transparent;
            StartDateLabel.PressedForeColor = Color.White;
            StartDateLabel.PressedImageTint = Color.White;
            StartDateLabel.PressedOutline = Color.WhiteSmoke;
            StartDateLabel.Rounding = new Padding(8);
            StartDateLabel.Size = new Size(80, 26);
            StartDateLabel.TabIndex = 39;
            StartDateLabel.TextOffset = new Point(0, 0);
            // 
            // EndDateLabel
            // 
            EndDateLabel.BackColor = Color.Transparent;
            EndDateLabel.CheckButton = false;
            EndDateLabel.Checked = false;
            EndDateLabel.CheckedBackground = Color.FromArgb(255, 106, 0);
            EndDateLabel.CheckedForeColor = Color.White;
            EndDateLabel.CheckedImageTint = Color.White;
            EndDateLabel.CheckedOutline = Color.Transparent;
            EndDateLabel.Content = "End Date";
            EndDateLabel.DialogResult = DialogResult.None;
            EndDateLabel.Font = new Font("Segoe UI", 12F);
            EndDateLabel.ForeColor = Color.White;
            EndDateLabel.HoverBackground = Color.Transparent;
            EndDateLabel.HoveredImageTint = Color.White;
            EndDateLabel.HoverForeColor = Color.White;
            EndDateLabel.HoverOutline = Color.WhiteSmoke;
            EndDateLabel.Image = null;
            EndDateLabel.ImageAutoCenter = true;
            EndDateLabel.ImageExpand = new Point(0, 0);
            EndDateLabel.ImageOffset = new Point(0, 0);
            EndDateLabel.ImageTint = Color.White;
            EndDateLabel.Location = new Point(33, 410);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.NormalBackground = Color.Transparent;
            EndDateLabel.NormalOutline = Color.WhiteSmoke;
            EndDateLabel.OutlineThickness = 1F;
            EndDateLabel.PressedBackground = Color.Transparent;
            EndDateLabel.PressedForeColor = Color.White;
            EndDateLabel.PressedImageTint = Color.White;
            EndDateLabel.PressedOutline = Color.WhiteSmoke;
            EndDateLabel.Rounding = new Padding(8);
            EndDateLabel.Size = new Size(80, 26);
            EndDateLabel.TabIndex = 40;
            EndDateLabel.TextOffset = new Point(0, 0);
            // 
            // EditsTask
            // 
            EditsTask.BackColor = Color.Transparent;
            EditsTask.CheckButton = false;
            EditsTask.Checked = false;
            EditsTask.CheckedBackground = Color.FromArgb(255, 106, 0);
            EditsTask.CheckedForeColor = Color.White;
            EditsTask.CheckedImageTint = Color.White;
            EditsTask.CheckedOutline = Color.Transparent;
            EditsTask.Content = "Edit Task";
            EditsTask.DialogResult = DialogResult.None;
            EditsTask.Font = new Font("Segoe UI", 12F);
            EditsTask.ForeColor = Color.White;
            EditsTask.HoverBackground = Color.Transparent;
            EditsTask.HoveredImageTint = Color.White;
            EditsTask.HoverForeColor = Color.White;
            EditsTask.HoverOutline = Color.Transparent;
            EditsTask.Image = null;
            EditsTask.ImageAutoCenter = true;
            EditsTask.ImageExpand = new Point(0, 0);
            EditsTask.ImageOffset = new Point(0, 0);
            EditsTask.ImageTint = Color.White;
            EditsTask.Location = new Point(33, 481);
            EditsTask.Name = "EditsTask";
            EditsTask.NormalBackground = Color.Transparent;
            EditsTask.NormalOutline = Color.WhiteSmoke;
            EditsTask.OutlineThickness = 1F;
            EditsTask.PressedBackground = Color.Transparent;
            EditsTask.PressedForeColor = Color.White;
            EditsTask.PressedImageTint = Color.White;
            EditsTask.PressedOutline = Color.Transparent;
            EditsTask.Rounding = new Padding(8);
            EditsTask.Size = new Size(98, 26);
            EditsTask.TabIndex = 41;
            EditsTask.TextOffset = new Point(0, 0);
            EditsTask.Click += EditsTask_Click;
            // 
            // Focuslabel2
            // 
            Focuslabel2.BackColor = Color.Transparent;
            Focuslabel2.Content = "";
            Focuslabel2.ForeColor = Color.Transparent;
            Focuslabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            Focuslabel2.Location = new Point(836, 23);
            Focuslabel2.Margin = new Padding(4, 3, 4, 3);
            Focuslabel2.Name = "Focuslabel2";
            Focuslabel2.Size = new Size(71, 41);
            Focuslabel2.TabIndex = 42;
            // 
            // SubTasks
            // 
            SubTasks.BackColor = Color.Transparent;
            SubTasks.BackgroundColor = Color.White;
            SubTasks.BorderStyle = BorderStyle.None;
            SubTasks.ColumnWidth = 300;
            SubTasks.DrawMode = DrawMode.OwnerDrawFixed;
            SubTasks.Font = new Font("Microsoft YaHei UI", 9.5F);
            SubTasks.ForeColor = Color.Black;
            SubTasks.ForegroundColor = Color.Black;
            SubTasks.FormattingEnabled = true;
            SubTasks.ItemHeight = 34;
            SubTasks.ItemHoveredBackgroundColor = Color.White;
            SubTasks.ItemHoveredForegroundColor = Color.Black;
            SubTasks.ItemRounding = 8;
            SubTasks.ItemSelectedBackgroundColor = SystemColors.ActiveCaption;
            SubTasks.Location = new Point(508, 305);
            SubTasks.Name = "SubTasks";
            SubTasks.RightToLeft = RightToLeft.No;
            SubTasks.Rounding = 8;
            SubTasks.SelectedForegroundColor = Color.Black;
            SubTasks.Size = new Size(415, 204);
            SubTasks.TabIndex = 55;
            // 
            // SubTaskDelBtn
            // 
            SubTaskDelBtn.BackColor = Color.Transparent;
            SubTaskDelBtn.CheckButton = false;
            SubTaskDelBtn.Checked = false;
            SubTaskDelBtn.CheckedBackground = Color.White;
            SubTaskDelBtn.CheckedForeColor = Color.White;
            SubTaskDelBtn.CheckedImageTint = Color.White;
            SubTaskDelBtn.CheckedOutline = Color.WhiteSmoke;
            SubTaskDelBtn.Content = "Delete";
            SubTaskDelBtn.DialogResult = DialogResult.None;
            SubTaskDelBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            SubTaskDelBtn.ForeColor = Color.White;
            SubTaskDelBtn.HoverBackground = Color.Transparent;
            SubTaskDelBtn.HoveredImageTint = Color.White;
            SubTaskDelBtn.HoverForeColor = Color.White;
            SubTaskDelBtn.HoverOutline = Color.Empty;
            SubTaskDelBtn.Image = null;
            SubTaskDelBtn.ImageAutoCenter = true;
            SubTaskDelBtn.ImageExpand = new Point(0, 0);
            SubTaskDelBtn.ImageOffset = new Point(0, 0);
            SubTaskDelBtn.ImageTint = Color.White;
            SubTaskDelBtn.Location = new Point(738, 208);
            SubTaskDelBtn.Name = "SubTaskDelBtn";
            SubTaskDelBtn.NormalBackground = Color.Transparent;
            SubTaskDelBtn.NormalOutline = Color.WhiteSmoke;
            SubTaskDelBtn.OutlineThickness = 1.6F;
            SubTaskDelBtn.PressedBackground = Color.Transparent;
            SubTaskDelBtn.PressedForeColor = Color.White;
            SubTaskDelBtn.PressedImageTint = Color.White;
            SubTaskDelBtn.PressedOutline = Color.Empty;
            SubTaskDelBtn.Rounding = new Padding(8);
            SubTaskDelBtn.Size = new Size(69, 29);
            SubTaskDelBtn.TabIndex = 54;
            SubTaskDelBtn.TextOffset = new Point(0, 0);
            SubTaskDelBtn.Click += SubTaskDelBtn_Click;
            // 
            // SubTaskAddBtn
            // 
            SubTaskAddBtn.BackColor = Color.Transparent;
            SubTaskAddBtn.CheckButton = false;
            SubTaskAddBtn.Checked = false;
            SubTaskAddBtn.CheckedBackground = Color.White;
            SubTaskAddBtn.CheckedForeColor = Color.White;
            SubTaskAddBtn.CheckedImageTint = Color.White;
            SubTaskAddBtn.CheckedOutline = Color.WhiteSmoke;
            SubTaskAddBtn.Content = "Add";
            SubTaskAddBtn.DialogResult = DialogResult.None;
            SubTaskAddBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            SubTaskAddBtn.ForeColor = Color.White;
            SubTaskAddBtn.HoverBackground = Color.Transparent;
            SubTaskAddBtn.HoveredImageTint = Color.White;
            SubTaskAddBtn.HoverForeColor = Color.White;
            SubTaskAddBtn.HoverOutline = Color.Empty;
            SubTaskAddBtn.Image = null;
            SubTaskAddBtn.ImageAutoCenter = true;
            SubTaskAddBtn.ImageExpand = new Point(0, 0);
            SubTaskAddBtn.ImageOffset = new Point(0, 0);
            SubTaskAddBtn.ImageTint = Color.White;
            SubTaskAddBtn.Location = new Point(738, 249);
            SubTaskAddBtn.Name = "SubTaskAddBtn";
            SubTaskAddBtn.NormalBackground = Color.Transparent;
            SubTaskAddBtn.NormalOutline = Color.WhiteSmoke;
            SubTaskAddBtn.OutlineThickness = 1.6F;
            SubTaskAddBtn.PressedBackground = Color.Transparent;
            SubTaskAddBtn.PressedForeColor = Color.White;
            SubTaskAddBtn.PressedImageTint = Color.White;
            SubTaskAddBtn.PressedOutline = Color.Empty;
            SubTaskAddBtn.Rounding = new Padding(8);
            SubTaskAddBtn.Size = new Size(69, 29);
            SubTaskAddBtn.TabIndex = 53;
            SubTaskAddBtn.TextOffset = new Point(0, 0);
            SubTaskAddBtn.Click += SubTaskAddBtn_Click;
            // 
            // SubTasksText
            // 
            SubTasksText.BackColor = Color.White;
            SubTasksText.BorderColor = Color.WhiteSmoke;
            SubTasksText.BorderFocusColor = Color.Gray;
            SubTasksText.BorderSize = 2;
            SubTasksText.Content = "";
            SubTasksText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 5);
            SubTasksText.ForeColor = Color.Gray;
            SubTasksText.Location = new Point(508, 242);
            SubTasksText.Margin = new Padding(4);
            SubTasksText.Multiline = false;
            SubTasksText.Name = "SubTasksText";
            SubTasksText.Padding = new Padding(15, 15, 15, 0);
            SubTasksText.PasswordChar = false;
            SubTasksText.PlaceholderColor = Color.Transparent;
            SubTasksText.PlaceholderText = "";
            SubTasksText.Rounding = 8;
            SubTasksText.Size = new Size(223, 45);
            SubTasksText.TabIndex = 52;
            SubTasksText.TextOffset = new Size(0, 0);
            SubTasksText.UnderlinedStyle = false;
            SubTasksText.KeyPress += SubTasksText_KeyPress;
            // 
            // DoneBtn
            // 
            DoneBtn.BackColor = Color.Transparent;
            DoneBtn.CheckButton = false;
            DoneBtn.Checked = false;
            DoneBtn.CheckedBackground = Color.White;
            DoneBtn.CheckedForeColor = Color.White;
            DoneBtn.CheckedImageTint = Color.White;
            DoneBtn.CheckedOutline = Color.WhiteSmoke;
            DoneBtn.Content = "Done";
            DoneBtn.DialogResult = DialogResult.None;
            DoneBtn.Font = new Font("Microsoft Sans Serif", 9.75F);
            DoneBtn.ForeColor = Color.White;
            DoneBtn.HoverBackground = Color.Transparent;
            DoneBtn.HoveredImageTint = Color.White;
            DoneBtn.HoverForeColor = Color.White;
            DoneBtn.HoverOutline = Color.Empty;
            DoneBtn.Image = null;
            DoneBtn.ImageAutoCenter = true;
            DoneBtn.ImageExpand = new Point(0, 0);
            DoneBtn.ImageOffset = new Point(0, 0);
            DoneBtn.ImageTint = Color.White;
            DoneBtn.Location = new Point(813, 249);
            DoneBtn.Name = "DoneBtn";
            DoneBtn.NormalBackground = Color.Transparent;
            DoneBtn.NormalOutline = Color.WhiteSmoke;
            DoneBtn.OutlineThickness = 1.6F;
            DoneBtn.PressedBackground = Color.Transparent;
            DoneBtn.PressedForeColor = Color.White;
            DoneBtn.PressedImageTint = Color.White;
            DoneBtn.PressedOutline = Color.Empty;
            DoneBtn.Rounding = new Padding(8);
            DoneBtn.Size = new Size(69, 29);
            DoneBtn.TabIndex = 56;
            DoneBtn.TextOffset = new Point(0, 0);
            DoneBtn.Click += DoneBtn_Click;
            // 
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(953, 650);
            Controls.Add(DoneBtn);
            Controls.Add(SubTasks);
            Controls.Add(SubTaskDelBtn);
            Controls.Add(SubTaskAddBtn);
            Controls.Add(SubTasksText);
            Controls.Add(Focuslabel2);
            Controls.Add(EditsTask);
            Controls.Add(EndDateLabel);
            Controls.Add(StartDateLabel);
            Controls.Add(PriorityList);
            Controls.Add(PriorityLabel);
            Controls.Add(DescriptionText);
            Controls.Add(TaskLabel);
            Controls.Add(DescriptionLabel);
            Controls.Add(DateEnd);
            Controls.Add(DateStart);
            Controls.Add(label2);
            DoubleBuffered = true;
            MaximumSize = new Size(969, 689);
            Name = "EditTask";
            MouseClick += EditTask_MouseClick;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker DateEnd;
        private DateTimePicker DateStart;
        private Label label2;
        private CuoreUI.Controls.cuiButton DescriptionLabel;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel TaskLabel;
        private CuoreUI.Controls.cuiTextBox2 DescriptionText;
        private CuoreUI.Controls.cuiButton PriorityLabel;
        private TransparentListBox PriorityList;
        private CuoreUI.Controls.cuiButton StartDateLabel;
        private CuoreUI.Controls.cuiButton EndDateLabel;
        private CuoreUI.Controls.cuiButton EditsTask;
        private CuoreUI.Controls.cuiLabel Focuslabel2;
        private TransparentListBox SubTasks;
        private CuoreUI.Controls.cuiButton SubTaskDelBtn;
        private CuoreUI.Controls.cuiButton SubTaskAddBtn;
        private CuoreUI.Controls.cuiTextBox2 SubTasksText;
        private CuoreUI.Controls.cuiButton DoneBtn;
    }
}
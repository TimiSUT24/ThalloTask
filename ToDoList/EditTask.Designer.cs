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
            // EditTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(953, 650);
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
    }
}
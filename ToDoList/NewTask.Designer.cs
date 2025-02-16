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
            StartDatePicker = new DateTimePicker();
            EndDatePicker = new DateTimePicker();
            TaskLabel = new CuoreUI.Controls.cuiButton();
            DescLabel = new CuoreUI.Controls.cuiButton();
            PriorityLabel = new CuoreUI.Controls.cuiButton();
            StartDateLabel = new CuoreUI.Controls.cuiButton();
            EndDateLabel = new CuoreUI.Controls.cuiButton();
            cuiButton6 = new CuoreUI.Controls.cuiButton();
            DescriptionText = new CuoreUI.Controls.cuiTextBox2();
            TaskText = new CuoreUI.Controls.cuiTextBox2();
            PriorityList = new TransparentListBox();
            Focuslabel3 = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // StartDatePicker
            // 
            StartDatePicker.CalendarForeColor = Color.Black;
            StartDatePicker.CalendarTitleForeColor = Color.Black;
            StartDatePicker.Location = new Point(32, 381);
            StartDatePicker.Name = "StartDatePicker";
            StartDatePicker.Size = new Size(200, 23);
            StartDatePicker.TabIndex = 14;
            // 
            // EndDatePicker
            // 
            EndDatePicker.Location = new Point(32, 460);
            EndDatePicker.Name = "EndDatePicker";
            EndDatePicker.Size = new Size(200, 23);
            EndDatePicker.TabIndex = 16;
            // 
            // TaskLabel
            // 
            TaskLabel.BackColor = Color.Transparent;
            TaskLabel.CheckButton = false;
            TaskLabel.Checked = false;
            TaskLabel.CheckedBackground = Color.FromArgb(255, 106, 0);
            TaskLabel.CheckedForeColor = Color.White;
            TaskLabel.CheckedImageTint = Color.White;
            TaskLabel.CheckedOutline = Color.Transparent;
            TaskLabel.Content = "Task";
            TaskLabel.DialogResult = DialogResult.None;
            TaskLabel.Font = new Font("Segoe UI", 12F);
            TaskLabel.ForeColor = Color.White;
            TaskLabel.HoverBackground = Color.Transparent;
            TaskLabel.HoveredImageTint = Color.White;
            TaskLabel.HoverForeColor = Color.White;
            TaskLabel.HoverOutline = Color.WhiteSmoke;
            TaskLabel.Image = null;
            TaskLabel.ImageAutoCenter = true;
            TaskLabel.ImageExpand = new Point(0, 0);
            TaskLabel.ImageOffset = new Point(0, 0);
            TaskLabel.ImageTint = Color.White;
            TaskLabel.Location = new Point(32, 44);
            TaskLabel.Name = "TaskLabel";
            TaskLabel.NormalBackground = Color.Transparent;
            TaskLabel.NormalOutline = Color.WhiteSmoke;
            TaskLabel.OutlineThickness = 1F;
            TaskLabel.PressedBackground = Color.Transparent;
            TaskLabel.PressedForeColor = Color.White;
            TaskLabel.PressedImageTint = Color.White;
            TaskLabel.PressedOutline = Color.WhiteSmoke;
            TaskLabel.Rounding = new Padding(8);
            TaskLabel.Size = new Size(76, 26);
            TaskLabel.TabIndex = 31;
            TaskLabel.TextOffset = new Point(0, 0);
            // 
            // DescLabel
            // 
            DescLabel.BackColor = Color.Transparent;
            DescLabel.CheckButton = false;
            DescLabel.Checked = false;
            DescLabel.CheckedBackground = Color.FromArgb(255, 106, 0);
            DescLabel.CheckedForeColor = Color.White;
            DescLabel.CheckedImageTint = Color.White;
            DescLabel.CheckedOutline = Color.Transparent;
            DescLabel.Content = "Description";
            DescLabel.DialogResult = DialogResult.None;
            DescLabel.Font = new Font("Segoe UI", 12F);
            DescLabel.ForeColor = Color.White;
            DescLabel.HoverBackground = Color.Transparent;
            DescLabel.HoveredImageTint = Color.White;
            DescLabel.HoverForeColor = Color.White;
            DescLabel.HoverOutline = Color.WhiteSmoke;
            DescLabel.Image = null;
            DescLabel.ImageAutoCenter = true;
            DescLabel.ImageExpand = new Point(0, 0);
            DescLabel.ImageOffset = new Point(0, 0);
            DescLabel.ImageTint = Color.White;
            DescLabel.Location = new Point(32, 109);
            DescLabel.Name = "DescLabel";
            DescLabel.NormalBackground = Color.Transparent;
            DescLabel.NormalOutline = Color.WhiteSmoke;
            DescLabel.OutlineThickness = 1F;
            DescLabel.PressedBackground = Color.Transparent;
            DescLabel.PressedForeColor = Color.White;
            DescLabel.PressedImageTint = Color.White;
            DescLabel.PressedOutline = Color.WhiteSmoke;
            DescLabel.Rounding = new Padding(8);
            DescLabel.Size = new Size(103, 26);
            DescLabel.TabIndex = 32;
            DescLabel.TextOffset = new Point(0, 0);
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
            PriorityLabel.Location = new Point(32, 243);
            PriorityLabel.Name = "PriorityLabel";
            PriorityLabel.NormalBackground = Color.Transparent;
            PriorityLabel.NormalOutline = Color.WhiteSmoke;
            PriorityLabel.OutlineThickness = 1F;
            PriorityLabel.PressedBackground = Color.Transparent;
            PriorityLabel.PressedForeColor = Color.White;
            PriorityLabel.PressedImageTint = Color.White;
            PriorityLabel.PressedOutline = Color.WhiteSmoke;
            PriorityLabel.Rounding = new Padding(8);
            PriorityLabel.Size = new Size(76, 26);
            PriorityLabel.TabIndex = 33;
            PriorityLabel.TextOffset = new Point(0, 0);
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
            StartDateLabel.Location = new Point(32, 349);
            StartDateLabel.Name = "StartDateLabel";
            StartDateLabel.NormalBackground = Color.Transparent;
            StartDateLabel.NormalOutline = Color.WhiteSmoke;
            StartDateLabel.OutlineThickness = 1F;
            StartDateLabel.PressedBackground = Color.Transparent;
            StartDateLabel.PressedForeColor = Color.White;
            StartDateLabel.PressedImageTint = Color.White;
            StartDateLabel.PressedOutline = Color.WhiteSmoke;
            StartDateLabel.Rounding = new Padding(8);
            StartDateLabel.Size = new Size(88, 26);
            StartDateLabel.TabIndex = 34;
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
            EndDateLabel.Location = new Point(32, 428);
            EndDateLabel.Name = "EndDateLabel";
            EndDateLabel.NormalBackground = Color.Transparent;
            EndDateLabel.NormalOutline = Color.WhiteSmoke;
            EndDateLabel.OutlineThickness = 1F;
            EndDateLabel.PressedBackground = Color.Transparent;
            EndDateLabel.PressedForeColor = Color.White;
            EndDateLabel.PressedImageTint = Color.White;
            EndDateLabel.PressedOutline = Color.WhiteSmoke;
            EndDateLabel.Rounding = new Padding(8);
            EndDateLabel.Size = new Size(88, 26);
            EndDateLabel.TabIndex = 35;
            EndDateLabel.TextOffset = new Point(0, 0);
            // 
            // cuiButton6
            // 
            cuiButton6.BackColor = Color.Transparent;
            cuiButton6.CheckButton = false;
            cuiButton6.Checked = false;
            cuiButton6.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton6.CheckedForeColor = Color.White;
            cuiButton6.CheckedImageTint = Color.White;
            cuiButton6.CheckedOutline = Color.Transparent;
            cuiButton6.Content = "Add Task";
            cuiButton6.DialogResult = DialogResult.None;
            cuiButton6.Font = new Font("Segoe UI", 12F);
            cuiButton6.ForeColor = Color.White;
            cuiButton6.HoverBackground = Color.Transparent;
            cuiButton6.HoveredImageTint = Color.White;
            cuiButton6.HoverForeColor = Color.White;
            cuiButton6.HoverOutline = Color.Empty;
            cuiButton6.Image = null;
            cuiButton6.ImageAutoCenter = true;
            cuiButton6.ImageExpand = new Point(0, 0);
            cuiButton6.ImageOffset = new Point(0, 0);
            cuiButton6.ImageTint = Color.White;
            cuiButton6.Location = new Point(32, 508);
            cuiButton6.Name = "cuiButton6";
            cuiButton6.NormalBackground = Color.Transparent;
            cuiButton6.NormalOutline = Color.WhiteSmoke;
            cuiButton6.OutlineThickness = 1F;
            cuiButton6.PressedBackground = Color.Transparent;
            cuiButton6.PressedForeColor = Color.White;
            cuiButton6.PressedImageTint = Color.White;
            cuiButton6.PressedOutline = Color.Empty;
            cuiButton6.Rounding = new Padding(8);
            cuiButton6.Size = new Size(88, 26);
            cuiButton6.TabIndex = 36;
            cuiButton6.TextOffset = new Point(0, 0);
            cuiButton6.Click += AddTask_Click;
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
            DescriptionText.Location = new Point(32, 140);
            DescriptionText.Margin = new Padding(4);
            DescriptionText.Multiline = true;
            DescriptionText.Name = "DescriptionText";
            DescriptionText.Padding = new Padding(15, 5, 15, 5);
            DescriptionText.PasswordChar = false;
            DescriptionText.PlaceholderColor = Color.Transparent;
            DescriptionText.PlaceholderText = "";
            DescriptionText.Rounding = 8;
            DescriptionText.Size = new Size(238, 96);
            DescriptionText.TabIndex = 0;
            DescriptionText.TextOffset = new Size(0, 0);
            DescriptionText.UnderlinedStyle = false;
            // 
            // TaskText
            // 
            TaskText.BackColor = Color.White;
            TaskText.BackgroundImageLayout = ImageLayout.None;
            TaskText.BorderColor = Color.WhiteSmoke;
            TaskText.BorderFocusColor = Color.Gray;
            TaskText.BorderSize = 2;
            TaskText.Content = "";
            TaskText.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskText.ForeColor = Color.Black;
            TaskText.Location = new Point(32, 75);
            TaskText.Margin = new Padding(4);
            TaskText.Multiline = false;
            TaskText.Name = "TaskText";
            TaskText.Padding = new Padding(15, 6, 15, 0);
            TaskText.PasswordChar = false;
            TaskText.PlaceholderColor = Color.Transparent;
            TaskText.PlaceholderText = "";
            TaskText.Rounding = 8;
            TaskText.Size = new Size(204, 27);
            TaskText.TabIndex = 0;
            TaskText.TextOffset = new Size(0, 0);
            TaskText.UnderlinedStyle = false;
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
            PriorityList.Location = new Point(32, 277);
            PriorityList.Margin = new Padding(1);
            PriorityList.Name = "PriorityList";
            PriorityList.Rounding = 8;
            PriorityList.SelectedForegroundColor = Color.Black;
            PriorityList.Size = new Size(156, 54);
            PriorityList.TabIndex = 0;
            // 
            // Focuslabel3
            // 
            Focuslabel3.BackColor = Color.Transparent;
            Focuslabel3.Content = "";
            Focuslabel3.ForeColor = Color.Transparent;
            Focuslabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
            Focuslabel3.Location = new Point(860, 29);
            Focuslabel3.Margin = new Padding(4, 3, 4, 3);
            Focuslabel3.Name = "Focuslabel3";
            Focuslabel3.Size = new Size(71, 41);
            Focuslabel3.TabIndex = 43;
            // 
            // NewTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(953, 650);
            Controls.Add(Focuslabel3);
            Controls.Add(PriorityList);
            Controls.Add(TaskText);
            Controls.Add(DescriptionText);
            Controls.Add(cuiButton6);
            Controls.Add(EndDateLabel);
            Controls.Add(StartDateLabel);
            Controls.Add(PriorityLabel);
            Controls.Add(DescLabel);
            Controls.Add(TaskLabel);
            Controls.Add(EndDatePicker);
            Controls.Add(StartDatePicker);
            DoubleBuffered = true;
            MaximumSize = new Size(969, 689);
            MinimumSize = new Size(261, 61);
            Name = "NewTask";
            Text = "New Task";
            MouseClick += NewTask_MouseClick;
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker StartDatePicker;
        private DateTimePicker EndDatePicker;        
        private CuoreUI.Controls.cuiButton DescLabel;
        private CuoreUI.Controls.cuiButton TaskLabel;
        private CuoreUI.Controls.cuiButton PriorityLabel;
        private CuoreUI.Controls.cuiButton StartDateLabel;
        private CuoreUI.Controls.cuiButton EndDateLabel;
        private CuoreUI.Controls.cuiButton cuiButton6;
        private CuoreUI.Controls.cuiTextBox2 DescriptionText;
        private CuoreUI.Controls.cuiTextBox2 TaskText;
        private TransparentListBox PriorityList;
        private CuoreUI.Controls.cuiLabel Focuslabel3;
    }
}
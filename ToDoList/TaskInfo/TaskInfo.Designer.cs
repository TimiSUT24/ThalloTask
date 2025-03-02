namespace ToDoList
{
    partial class TaskInfo
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
            TextBoxTaskButton = new CuoreUI.Controls.cuiButton();
            TaskTxtBox = new CuoreUI.Controls.cuiTextBox2();
            SuspendLayout();
            // 
            // TextBoxTaskButton
            // 
            TextBoxTaskButton.BackColor = Color.Transparent;
            TextBoxTaskButton.CheckButton = false;
            TextBoxTaskButton.Checked = false;
            TextBoxTaskButton.CheckedBackground = Color.Transparent;
            TextBoxTaskButton.CheckedForeColor = Color.Transparent;
            TextBoxTaskButton.CheckedImageTint = Color.Transparent;
            TextBoxTaskButton.CheckedOutline = Color.Transparent;
            TextBoxTaskButton.Content = "Ok";
            TextBoxTaskButton.DialogResult = DialogResult.None;
            TextBoxTaskButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextBoxTaskButton.ForeColor = Color.Black;
            TextBoxTaskButton.HoverBackground = Color.Transparent;
            TextBoxTaskButton.HoveredImageTint = Color.Transparent;
            TextBoxTaskButton.HoverForeColor = Color.Black;
            TextBoxTaskButton.HoverOutline = Color.Empty;
            TextBoxTaskButton.Image = null;
            TextBoxTaskButton.ImageAutoCenter = true;
            TextBoxTaskButton.ImageExpand = new Point(0, 0);
            TextBoxTaskButton.ImageOffset = new Point(0, 0);
            TextBoxTaskButton.ImageTint = Color.Transparent;
            TextBoxTaskButton.Location = new Point(406, 295);
            TextBoxTaskButton.Name = "TextBoxTaskButton";
            TextBoxTaskButton.NormalBackground = Color.Transparent;
            TextBoxTaskButton.NormalOutline = Color.Black;
            TextBoxTaskButton.OutlineThickness = 3F;
            TextBoxTaskButton.PressedBackground = Color.Transparent;
            TextBoxTaskButton.PressedForeColor = Color.Black;
            TextBoxTaskButton.PressedImageTint = Color.Transparent;
            TextBoxTaskButton.PressedOutline = Color.Black;
            TextBoxTaskButton.Rounding = new Padding(8);
            TextBoxTaskButton.Size = new Size(41, 38);
            TextBoxTaskButton.TabIndex = 43;
            TextBoxTaskButton.TextOffset = new Point(0, 0);
            TextBoxTaskButton.Click += TextBoxTaskButton_Click;
            // 
            // TaskTxtBox
            // 
            TaskTxtBox.BackColor = Color.White;
            TaskTxtBox.BackgroundImageLayout = ImageLayout.None;
            TaskTxtBox.BorderColor = Color.Black;
            TaskTxtBox.BorderFocusColor = Color.Black;
            TaskTxtBox.BorderSize = 2;
            TaskTxtBox.Content = "";
            TaskTxtBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskTxtBox.ForeColor = Color.Black;
            TaskTxtBox.Location = new Point(13, 13);
            TaskTxtBox.Margin = new Padding(4);
            TaskTxtBox.Multiline = true;
            TaskTxtBox.Name = "TaskTxtBox";
            TaskTxtBox.Padding = new Padding(15, 5, 15, 5);
            TaskTxtBox.PasswordChar = false;
            TaskTxtBox.PlaceholderColor = Color.Black;
            TaskTxtBox.PlaceholderText = "";
            TaskTxtBox.Rounding = 8;
            TaskTxtBox.Size = new Size(446, 329);
            TaskTxtBox.TabIndex = 45;
            TaskTxtBox.TextOffset = new Size(0, 0);
            TaskTxtBox.UnderlinedStyle = false;
            // 
            // TaskInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(472, 355);
            Controls.Add(TextBoxTaskButton);
            Controls.Add(TaskTxtBox);
            MaximumSize = new Size(488, 394);
            Name = "TaskInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskInfo";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton TextBoxTaskButton;
        private CuoreUI.Controls.cuiTextBox2 TaskTxtBox;
    }
}
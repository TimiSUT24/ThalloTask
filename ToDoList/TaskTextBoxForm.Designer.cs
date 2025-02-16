namespace ToDoList
{
    partial class TaskTextBoxForm
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
            TextBoxTaskButton.CheckButton = false;
            TextBoxTaskButton.Checked = false;
            TextBoxTaskButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            TextBoxTaskButton.CheckedForeColor = Color.White;
            TextBoxTaskButton.CheckedImageTint = Color.White;
            TextBoxTaskButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            TextBoxTaskButton.Content = "Ok";
            TextBoxTaskButton.DialogResult = DialogResult.None;
            TextBoxTaskButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            TextBoxTaskButton.ForeColor = Color.White;
            TextBoxTaskButton.HoverBackground = Color.FromArgb(200, 255, 106, 0);
            TextBoxTaskButton.HoveredImageTint = Color.White;
            TextBoxTaskButton.HoverForeColor = Color.White;
            TextBoxTaskButton.HoverOutline = Color.Empty;
            TextBoxTaskButton.Image = null;
            TextBoxTaskButton.ImageAutoCenter = true;
            TextBoxTaskButton.ImageExpand = new Point(0, 0);
            TextBoxTaskButton.ImageOffset = new Point(0, 0);
            TextBoxTaskButton.ImageTint = Color.White;
            TextBoxTaskButton.Location = new Point(408, 300);
            TextBoxTaskButton.Name = "TextBoxTaskButton";
            TextBoxTaskButton.NormalBackground = Color.FromArgb(255, 106, 0);
            TextBoxTaskButton.NormalOutline = Color.Empty;
            TextBoxTaskButton.OutlineThickness = 1.6F;
            TextBoxTaskButton.PressedBackground = Color.FromArgb(255, 106, 0);
            TextBoxTaskButton.PressedForeColor = Color.White;
            TextBoxTaskButton.PressedImageTint = Color.White;
            TextBoxTaskButton.PressedOutline = Color.Empty;
            TextBoxTaskButton.Rounding = new Padding(8);
            TextBoxTaskButton.Size = new Size(35, 34);
            TextBoxTaskButton.TabIndex = 43;
            TextBoxTaskButton.TextOffset = new Point(0, 0);
            TextBoxTaskButton.Click += TextBoxTaskButton_Click;
            // 
            // TaskTxtBox
            // 
            TaskTxtBox.BackColor = Color.White;
            TaskTxtBox.BorderColor = Color.FromArgb(64, 64, 64);
            TaskTxtBox.BorderFocusColor = Color.FromArgb(255, 106, 0);
            TaskTxtBox.BorderSize = 1;
            TaskTxtBox.Content = "";
            TaskTxtBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TaskTxtBox.ForeColor = Color.Black;
            TaskTxtBox.Location = new Point(13, 13);
            TaskTxtBox.Margin = new Padding(4);
            TaskTxtBox.Multiline = true;
            TaskTxtBox.Name = "TaskTxtBox";
            TaskTxtBox.Padding = new Padding(15, 5, 15, 5);
            TaskTxtBox.PasswordChar = false;
            TaskTxtBox.PlaceholderColor = Color.DimGray;
            TaskTxtBox.PlaceholderText = "";
            TaskTxtBox.Rounding = 8;
            TaskTxtBox.Size = new Size(446, 329);
            TaskTxtBox.TabIndex = 45;
            TaskTxtBox.TextOffset = new Size(0, 0);
            TaskTxtBox.UnderlinedStyle = false;
            // 
            // TaskTextBoxForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 355);
            Controls.Add(TextBoxTaskButton);
            Controls.Add(TaskTxtBox);
            Name = "TaskTextBoxForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TaskTextBoxForm";         
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton TextBoxTaskButton;
        private CuoreUI.Controls.cuiTextBox2 TaskTxtBox;
    }
}
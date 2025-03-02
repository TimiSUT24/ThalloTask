namespace ToDoList
{
    partial class Login
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
            LoginLabel = new Label();
            LoginButton = new Button();
            PasswordLabel = new Label();
            PasswordText = new TextBox();
            UsernameLabel = new Label();
            UsernameText = new TextBox();
            RegisterButton = new Button();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.BackColor = Color.Transparent;
            LoginLabel.Font = new Font("Segoe UI", 18F);
            LoginLabel.Location = new Point(557, 75);
            LoginLabel.Margin = new Padding(4, 0, 4, 0);
            LoginLabel.MinimumSize = new Size(129, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(129, 32);
            LoginLabel.TabIndex = 11;
            LoginLabel.Text = "Login";
            LoginLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.Transparent;
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.Location = new Point(588, 311);
            LoginButton.Margin = new Padding(4);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(267, 34);
            LoginButton.TabIndex = 10;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginBtn_Click_1;
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 10F);
            PasswordLabel.Location = new Point(588, 222);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.MinimumSize = new Size(129, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(129, 19);
            PasswordLabel.TabIndex = 9;
            PasswordLabel.Text = "Enter Password";
            // 
            // PasswordText
            // 
            PasswordText.BackColor = SystemColors.Window;
            PasswordText.Font = new Font("Segoe UI", 12F);
            PasswordText.Location = new Point(588, 254);
            PasswordText.Margin = new Padding(4);
            PasswordText.MaxLength = 50;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(264, 29);
            PasswordText.TabIndex = 8;
            PasswordText.UseSystemPasswordChar = true;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Segoe UI", 10F);
            UsernameLabel.Location = new Point(588, 134);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.MinimumSize = new Size(129, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(129, 19);
            UsernameLabel.TabIndex = 7;
            UsernameLabel.Text = "Enter Username";
            // 
            // UsernameText
            // 
            UsernameText.BackColor = SystemColors.Window;
            UsernameText.Font = new Font("Segoe UI", 12F);
            UsernameText.Location = new Point(588, 166);
            UsernameText.Margin = new Padding(4);
            UsernameText.MaxLength = 50;
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(264, 29);
            UsernameText.TabIndex = 6;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Transparent;
            RegisterButton.Font = new Font("Segoe UI", 12F);
            RegisterButton.Location = new Point(588, 364);
            RegisterButton.Margin = new Padding(4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(267, 34);
            RegisterButton.TabIndex = 12;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterMenu_Click;
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Transparent;
            ExitButton.Font = new Font("Segoe UI", 12F);
            ExitButton.Location = new Point(588, 417);
            ExitButton.Margin = new Padding(4);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(267, 34);
            ExitButton.TabIndex = 13;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1382, 839);
            Controls.Add(ExitButton);
            Controls.Add(RegisterButton);
            Controls.Add(LoginLabel);
            Controls.Add(LoginButton);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordText);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameText);
            DoubleBuffered = true;
            MaximumSize = new Size(1398, 878);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            FormClosing += Login_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LoginLabel;
        private Button LoginButton;
        private Label PasswordLabel;
        private TextBox PasswordText;
        private Label UsernameLabel;
        private TextBox UsernameText;
        private Button RegisterButton;
        private Button ExitButton;
    }
}
namespace ToDoList
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameText = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            PasswordText = new TextBox();
            RegisterButton = new Button();
            RegisterLabel = new Label();
            LoginButton = new Button();
            ExitButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // UsernameText
            // 
            UsernameText.BackColor = SystemColors.Window;
            UsernameText.Location = new Point(564, 240);
            UsernameText.Margin = new Padding(4);
            UsernameText.MaxLength = 50;
            UsernameText.Name = "UsernameText";
            UsernameText.Size = new Size(264, 29);
            UsernameText.TabIndex = 0;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.BackColor = Color.Transparent;
            UsernameLabel.Font = new Font("Segoe UI", 10F);
            UsernameLabel.Location = new Point(564, 208);
            UsernameLabel.Margin = new Padding(4, 0, 4, 0);
            UsernameLabel.MinimumSize = new Size(129, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(129, 19);
            UsernameLabel.TabIndex = 1;
            UsernameLabel.Text = "Enter Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.BackColor = Color.Transparent;
            PasswordLabel.Font = new Font("Segoe UI", 10F);
            PasswordLabel.Location = new Point(564, 296);
            PasswordLabel.Margin = new Padding(4, 0, 4, 0);
            PasswordLabel.MinimumSize = new Size(129, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(129, 19);
            PasswordLabel.TabIndex = 3;
            PasswordLabel.Text = "Enter Password";
            // 
            // PasswordText
            // 
            PasswordText.BackColor = SystemColors.Window;
            PasswordText.Location = new Point(564, 328);
            PasswordText.Margin = new Padding(4);
            PasswordText.MaxLength = 50;
            PasswordText.Name = "PasswordText";
            PasswordText.Size = new Size(264, 29);
            PasswordText.TabIndex = 2;
            PasswordText.UseSystemPasswordChar = true;
            // 
            // RegisterButton
            // 
            RegisterButton.BackColor = Color.Transparent;
            RegisterButton.Font = new Font("Segoe UI", 12F);
            RegisterButton.Location = new Point(564, 386);
            RegisterButton.Margin = new Padding(4);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(267, 34);
            RegisterButton.TabIndex = 4;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = false;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // RegisterLabel
            // 
            RegisterLabel.AutoSize = true;
            RegisterLabel.BackColor = Color.Transparent;
            RegisterLabel.Font = new Font("Segoe UI", 12F);
            RegisterLabel.Location = new Point(564, 162);
            RegisterLabel.Margin = new Padding(4, 0, 4, 0);
            RegisterLabel.MinimumSize = new Size(129, 0);
            RegisterLabel.Name = "RegisterLabel";
            RegisterLabel.Size = new Size(164, 21);
            RegisterLabel.TabIndex = 5;
            RegisterLabel.Text = "Register your account:";
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(564, 436);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(267, 34);
            LoginButton.TabIndex = 6;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginMenu_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(564, 485);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(267, 34);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(541, 68);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 8;
            label1.Text = "Welcome To ThalloTask\r\n";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1382, 839);
            Controls.Add(label1);
            Controls.Add(ExitButton);
            Controls.Add(LoginButton);
            Controls.Add(RegisterLabel);
            Controls.Add(RegisterButton);
            Controls.Add(PasswordLabel);
            Controls.Add(PasswordText);
            Controls.Add(UsernameLabel);
            Controls.Add(UsernameText);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximumSize = new Size(1398, 878);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox UsernameText;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private Button RegisterButton;
        private Label RegisterLabel;
        private Button LoginButton;
        private Button ExitButton;
        private TextBox PasswordText;
        private Label label1;
    }
}

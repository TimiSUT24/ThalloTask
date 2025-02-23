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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserMenu));
            DeleteButton = new CuoreUI.Controls.cuiButton();
            EditTask = new CuoreUI.Controls.cuiButton();
            NewTask = new CuoreUI.Controls.cuiButton();
            LogoutButton = new CuoreUI.Controls.cuiButton();
            ShowTask = new CuoreUI.Controls.cuiButton();
            ActiveTasks = new CuoreUI.Controls.cuiButton();
            WelcomeText = new CuoreUI.Controls.cuiButton();
            TextUser = new CuoreUI.Controls.cuiButton();
            cuiBorder1 = new CuoreUI.Controls.cuiBorder();
            ReloadButton = new CuoreUI.Controls.cuiButton();
            CompletedSubTasks = new ReaLTaiizor.Controls.MetroListBox();
            FinishedTaskBorder = new CuoreUI.Controls.cuiBorder();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            TaskBorder = new CuoreUI.Controls.cuiBorder();
            Tasks = new ReaLTaiizor.Controls.MetroListBox();
            TaskBorder.SuspendLayout();
            SuspendLayout();
            // 
            // DeleteButton
            // 
            DeleteButton.BackColor = Color.Transparent;
            DeleteButton.CheckButton = false;
            DeleteButton.Checked = false;
            DeleteButton.CheckedBackground = Color.Transparent;
            DeleteButton.CheckedForeColor = Color.White;
            DeleteButton.CheckedImageTint = Color.White;
            DeleteButton.CheckedOutline = Color.Transparent;
            DeleteButton.Content = "Delete Task";
            DeleteButton.DialogResult = DialogResult.None;
            DeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DeleteButton.ForeColor = Color.White;
            DeleteButton.HoverBackground = Color.Transparent;
            DeleteButton.HoveredImageTint = Color.White;
            DeleteButton.HoverForeColor = Color.White;
            DeleteButton.HoverOutline = Color.Empty;
            DeleteButton.Image = null;
            DeleteButton.ImageAutoCenter = true;
            DeleteButton.ImageExpand = new Point(0, 0);
            DeleteButton.ImageOffset = new Point(0, 0);
            DeleteButton.ImageTint = Color.White;
            DeleteButton.Location = new Point(639, 78);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.NormalBackground = Color.Transparent;
            DeleteButton.NormalOutline = Color.WhiteSmoke;
            DeleteButton.OutlineThickness = 1F;
            DeleteButton.PressedBackground = Color.Transparent;
            DeleteButton.PressedForeColor = Color.White;
            DeleteButton.PressedImageTint = Color.White;
            DeleteButton.PressedOutline = Color.Empty;
            DeleteButton.Rounding = new Padding(8);
            DeleteButton.Size = new Size(144, 26);
            DeleteButton.TabIndex = 28;
            DeleteButton.TextOffset = new Point(0, 0);
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditTask
            // 
            EditTask.BackColor = Color.Transparent;
            EditTask.CheckButton = false;
            EditTask.Checked = false;
            EditTask.CheckedBackground = Color.Transparent;
            EditTask.CheckedForeColor = Color.White;
            EditTask.CheckedImageTint = Color.White;
            EditTask.CheckedOutline = Color.Transparent;
            EditTask.Content = "Edit Task";
            EditTask.DialogResult = DialogResult.None;
            EditTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EditTask.ForeColor = Color.White;
            EditTask.HoverBackground = Color.Transparent;
            EditTask.HoveredImageTint = Color.White;
            EditTask.HoverForeColor = Color.White;
            EditTask.HoverOutline = Color.Empty;
            EditTask.Image = null;
            EditTask.ImageAutoCenter = true;
            EditTask.ImageExpand = new Point(0, 0);
            EditTask.ImageOffset = new Point(0, 0);
            EditTask.ImageTint = Color.White;
            EditTask.Location = new Point(476, 78);
            EditTask.Name = "EditTask";
            EditTask.NormalBackground = Color.Transparent;
            EditTask.NormalOutline = Color.WhiteSmoke;
            EditTask.OutlineThickness = 1F;
            EditTask.PressedBackground = Color.Transparent;
            EditTask.PressedForeColor = Color.White;
            EditTask.PressedImageTint = Color.White;
            EditTask.PressedOutline = Color.Empty;
            EditTask.Rounding = new Padding(8);
            EditTask.Size = new Size(144, 26);
            EditTask.TabIndex = 29;
            EditTask.TextOffset = new Point(0, 0);
            EditTask.Click += EditTask_Click;
            // 
            // NewTask
            // 
            NewTask.BackColor = Color.Transparent;
            NewTask.CheckButton = false;
            NewTask.Checked = false;
            NewTask.CheckedBackground = Color.FromArgb(255, 106, 0);
            NewTask.CheckedForeColor = Color.White;
            NewTask.CheckedImageTint = Color.White;
            NewTask.CheckedOutline = Color.Transparent;
            NewTask.Content = "New Task";
            NewTask.DialogResult = DialogResult.None;
            NewTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NewTask.ForeColor = Color.White;
            NewTask.HoverBackground = Color.Transparent;
            NewTask.HoveredImageTint = Color.White;
            NewTask.HoverForeColor = Color.White;
            NewTask.HoverOutline = Color.Empty;
            NewTask.Image = null;
            NewTask.ImageAutoCenter = true;
            NewTask.ImageExpand = new Point(0, 0);
            NewTask.ImageOffset = new Point(0, 0);
            NewTask.ImageTint = Color.White;
            NewTask.Location = new Point(314, 78);
            NewTask.Name = "NewTask";
            NewTask.NormalBackground = Color.Transparent;
            NewTask.NormalOutline = Color.WhiteSmoke;
            NewTask.OutlineThickness = 1F;
            NewTask.PressedBackground = Color.Transparent;
            NewTask.PressedForeColor = Color.White;
            NewTask.PressedImageTint = Color.White;
            NewTask.PressedOutline = Color.Empty;
            NewTask.Rounding = new Padding(8);
            NewTask.Size = new Size(144, 26);
            NewTask.TabIndex = 30;
            NewTask.TextOffset = new Point(0, 0);
            NewTask.Click += NewTask_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.BackColor = Color.Transparent;
            LogoutButton.CheckButton = false;
            LogoutButton.Checked = false;
            LogoutButton.CheckedBackground = Color.Transparent;
            LogoutButton.CheckedForeColor = Color.White;
            LogoutButton.CheckedImageTint = Color.White;
            LogoutButton.CheckedOutline = Color.Transparent;
            LogoutButton.Content = "Logout";
            LogoutButton.DialogResult = DialogResult.None;
            LogoutButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogoutButton.ForeColor = Color.White;
            LogoutButton.HoverBackground = Color.Transparent;
            LogoutButton.HoveredImageTint = Color.White;
            LogoutButton.HoverForeColor = Color.White;
            LogoutButton.HoverOutline = Color.Empty;
            LogoutButton.Image = null;
            LogoutButton.ImageAutoCenter = true;
            LogoutButton.ImageExpand = new Point(0, 0);
            LogoutButton.ImageOffset = new Point(0, 0);
            LogoutButton.ImageTint = Color.White;
            LogoutButton.Location = new Point(518, 359);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.NormalBackground = Color.Transparent;
            LogoutButton.NormalOutline = Color.WhiteSmoke;
            LogoutButton.OutlineThickness = 1.6F;
            LogoutButton.PressedBackground = Color.Transparent;
            LogoutButton.PressedForeColor = Color.White;
            LogoutButton.PressedImageTint = Color.White;
            LogoutButton.PressedOutline = Color.Empty;
            LogoutButton.Rounding = new Padding(8);
            LogoutButton.Size = new Size(144, 26);
            LogoutButton.TabIndex = 31;
            LogoutButton.TextOffset = new Point(0, 0);
            LogoutButton.Click += LogoutButton_Click;
            // 
            // ShowTask
            // 
            ShowTask.BackColor = Color.Transparent;
            ShowTask.CheckButton = false;
            ShowTask.Checked = false;
            ShowTask.CheckedBackground = Color.Transparent;
            ShowTask.CheckedForeColor = Color.White;
            ShowTask.CheckedImageTint = Color.White;
            ShowTask.CheckedOutline = Color.Transparent;
            ShowTask.Content = "Show";
            ShowTask.DialogResult = DialogResult.None;
            ShowTask.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShowTask.ForeColor = Color.White;
            ShowTask.HoverBackground = Color.Transparent;
            ShowTask.HoveredImageTint = Color.White;
            ShowTask.HoverForeColor = Color.White;
            ShowTask.HoverOutline = Color.Transparent;
            ShowTask.Image = null;
            ShowTask.ImageAutoCenter = true;
            ShowTask.ImageExpand = new Point(0, 0);
            ShowTask.ImageOffset = new Point(0, 0);
            ShowTask.ImageTint = Color.White;
            ShowTask.Location = new Point(127, 383);
            ShowTask.Name = "ShowTask";
            ShowTask.NormalBackground = Color.Transparent;
            ShowTask.NormalOutline = Color.WhiteSmoke;
            ShowTask.OutlineThickness = 1.6F;
            ShowTask.PressedBackground = Color.Transparent;
            ShowTask.PressedForeColor = Color.White;
            ShowTask.PressedImageTint = Color.White;
            ShowTask.PressedOutline = Color.Empty;
            ShowTask.Rounding = new Padding(8);
            ShowTask.Size = new Size(144, 26);
            ShowTask.TabIndex = 32;
            ShowTask.TextOffset = new Point(0, 0);
            ShowTask.Click += ShowTask_Click;
            // 
            // ActiveTasks
            // 
            ActiveTasks.BackColor = Color.Transparent;
            ActiveTasks.CheckButton = false;
            ActiveTasks.Checked = false;
            ActiveTasks.CheckedBackground = Color.Transparent;
            ActiveTasks.CheckedForeColor = Color.White;
            ActiveTasks.CheckedImageTint = Color.White;
            ActiveTasks.CheckedOutline = Color.Transparent;
            ActiveTasks.Content = "Active Tasks";
            ActiveTasks.DialogResult = DialogResult.None;
            ActiveTasks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActiveTasks.ForeColor = Color.White;
            ActiveTasks.HoverBackground = Color.Transparent;
            ActiveTasks.HoveredImageTint = Color.White;
            ActiveTasks.HoverForeColor = Color.White;
            ActiveTasks.HoverOutline = Color.WhiteSmoke;
            ActiveTasks.Image = null;
            ActiveTasks.ImageAutoCenter = true;
            ActiveTasks.ImageExpand = new Point(0, 0);
            ActiveTasks.ImageOffset = new Point(0, 0);
            ActiveTasks.ImageTint = Color.White;
            ActiveTasks.Location = new Point(127, 78);
            ActiveTasks.Name = "ActiveTasks";
            ActiveTasks.NormalBackground = Color.Transparent;
            ActiveTasks.NormalOutline = Color.WhiteSmoke;
            ActiveTasks.OutlineThickness = 1.6F;
            ActiveTasks.PressedBackground = Color.Transparent;
            ActiveTasks.PressedForeColor = Color.White;
            ActiveTasks.PressedImageTint = Color.White;
            ActiveTasks.PressedOutline = Color.WhiteSmoke;
            ActiveTasks.Rounding = new Padding(8);
            ActiveTasks.Size = new Size(144, 26);
            ActiveTasks.TabIndex = 33;
            ActiveTasks.TextOffset = new Point(0, 0);
            // 
            // WelcomeText
            // 
            WelcomeText.BackColor = Color.Transparent;
            WelcomeText.CheckButton = false;
            WelcomeText.Checked = false;
            WelcomeText.CheckedBackground = Color.Transparent;
            WelcomeText.CheckedForeColor = Color.Transparent;
            WelcomeText.CheckedImageTint = Color.Transparent;
            WelcomeText.CheckedOutline = Color.Transparent;
            WelcomeText.Content = "Welcome to your ToDoList";
            WelcomeText.DialogResult = DialogResult.None;
            WelcomeText.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WelcomeText.ForeColor = Color.White;
            WelcomeText.HoverBackground = Color.Transparent;
            WelcomeText.HoveredImageTint = Color.Transparent;
            WelcomeText.HoverForeColor = Color.White;
            WelcomeText.HoverOutline = Color.WhiteSmoke;
            WelcomeText.Image = null;
            WelcomeText.ImageAutoCenter = true;
            WelcomeText.ImageExpand = new Point(0, 0);
            WelcomeText.ImageOffset = new Point(0, 0);
            WelcomeText.ImageTint = Color.Transparent;
            WelcomeText.Location = new Point(509, 9);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.NormalBackground = Color.Transparent;
            WelcomeText.NormalOutline = Color.WhiteSmoke;
            WelcomeText.OutlineThickness = 2F;
            WelcomeText.PressedBackground = Color.Transparent;
            WelcomeText.PressedForeColor = Color.White;
            WelcomeText.PressedImageTint = Color.Transparent;
            WelcomeText.PressedOutline = Color.WhiteSmoke;
            WelcomeText.Rounding = new Padding(8);
            WelcomeText.Size = new Size(331, 43);
            WelcomeText.TabIndex = 0;
            WelcomeText.TabStop = false;
            WelcomeText.TextOffset = new Point(0, 0);
            // 
            // TextUser
            // 
            TextUser.AutoSize = true;
            TextUser.BackColor = Color.Transparent;
            TextUser.CheckButton = false;
            TextUser.Checked = false;
            TextUser.CheckedBackground = Color.Transparent;
            TextUser.CheckedForeColor = Color.Transparent;
            TextUser.CheckedImageTint = Color.Transparent;
            TextUser.CheckedOutline = Color.Transparent;
            TextUser.Content = "";
            TextUser.DialogResult = DialogResult.None;
            TextUser.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextUser.ForeColor = Color.White;
            TextUser.HoverBackground = Color.Transparent;
            TextUser.HoveredImageTint = Color.Transparent;
            TextUser.HoverForeColor = Color.White;
            TextUser.HoverOutline = Color.WhiteSmoke;
            TextUser.Image = null;
            TextUser.ImageAutoCenter = true;
            TextUser.ImageExpand = new Point(0, 0);
            TextUser.ImageOffset = new Point(0, 0);
            TextUser.ImageTint = Color.Transparent;
            TextUser.Location = new Point(1109, 12);
            TextUser.Name = "TextUser";
            TextUser.NormalBackground = Color.Transparent;
            TextUser.NormalOutline = Color.WhiteSmoke;
            TextUser.OutlineThickness = 2F;
            TextUser.PressedBackground = Color.Transparent;
            TextUser.PressedForeColor = Color.White;
            TextUser.PressedImageTint = Color.Transparent;
            TextUser.PressedOutline = Color.WhiteSmoke;
            TextUser.Rounding = new Padding(8);
            TextUser.Size = new Size(261, 25);
            TextUser.TabIndex = 35;
            TextUser.TabStop = false;
            TextUser.TextOffset = new Point(0, 0);
            // 
            // cuiBorder1
            // 
            cuiBorder1.BackColor = Color.Transparent;
            cuiBorder1.Location = new Point(1, 443);
            cuiBorder1.Name = "cuiBorder1";
            cuiBorder1.OutlineThickness = 2F;
            cuiBorder1.PanelColor = Color.White;
            cuiBorder1.PanelOutlineColor = Color.Transparent;
            cuiBorder1.Rounding = new Padding(0);
            cuiBorder1.Size = new Size(1382, 2);
            cuiBorder1.TabIndex = 36;
            // 
            // ReloadButton
            // 
            ReloadButton.BackColor = Color.Transparent;
            ReloadButton.BackgroundImageLayout = ImageLayout.None;
            ReloadButton.CheckButton = false;
            ReloadButton.Checked = false;
            ReloadButton.CheckedBackground = Color.FromArgb(255, 106, 0);
            ReloadButton.CheckedForeColor = Color.White;
            ReloadButton.CheckedImageTint = Color.White;
            ReloadButton.CheckedOutline = Color.FromArgb(255, 106, 0);
            ReloadButton.Content = "";
            ReloadButton.DialogResult = DialogResult.None;
            ReloadButton.Font = new Font("Microsoft Sans Serif", 9.75F);
            ReloadButton.ForeColor = Color.Transparent;
            ReloadButton.HoverBackground = Color.Empty;
            ReloadButton.HoveredImageTint = Color.Black;
            ReloadButton.HoverForeColor = Color.Transparent;
            ReloadButton.HoverOutline = Color.Transparent;
            ReloadButton.Image = (Image)resources.GetObject("ReloadButton.Image");
            ReloadButton.ImageAutoCenter = true;
            ReloadButton.ImageExpand = new Point(5, 5);
            ReloadButton.ImageOffset = new Point(0, 0);
            ReloadButton.ImageTint = Color.Black;
            ReloadButton.Location = new Point(57, 117);
            ReloadButton.Name = "ReloadButton";
            ReloadButton.NormalBackground = Color.Transparent;
            ReloadButton.NormalOutline = Color.Empty;
            ReloadButton.OutlineThickness = 1.6F;
            ReloadButton.PressedBackground = Color.Transparent;
            ReloadButton.PressedForeColor = Color.White;
            ReloadButton.PressedImageTint = SystemColors.ActiveCaption;
            ReloadButton.PressedOutline = Color.WhiteSmoke;
            ReloadButton.Rounding = new Padding(8);
            ReloadButton.Size = new Size(30, 32);
            ReloadButton.TabIndex = 39;
            ReloadButton.TextOffset = new Point(0, 0);
            ReloadButton.Click += ReloadButton_Click_1;
            // 
            // CompletedSubTasks
            // 
            CompletedSubTasks.BackColor = Color.Transparent;
            CompletedSubTasks.BorderColor = Color.Transparent;
            CompletedSubTasks.DisabledBackColor = Color.Transparent;
            CompletedSubTasks.DisabledForeColor = Color.Transparent;
            CompletedSubTasks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompletedSubTasks.HoveredItemBackColor = Color.Transparent;
            CompletedSubTasks.HoveredItemColor = Color.Black;
            CompletedSubTasks.IsDerivedStyle = false;
            CompletedSubTasks.ItemHeight = 30;
            CompletedSubTasks.Location = new Point(99, 512);
            CompletedSubTasks.MultiSelect = false;
            CompletedSubTasks.Name = "CompletedSubTasks";
            CompletedSubTasks.SelectedIndex = -1;
            CompletedSubTasks.SelectedItem = null;
            CompletedSubTasks.SelectedItemBackColor = Color.Transparent;
            CompletedSubTasks.SelectedItemColor = Color.Black;
            CompletedSubTasks.SelectedText = null;
            CompletedSubTasks.SelectedValue = null;
            CompletedSubTasks.ShowBorder = false;
            CompletedSubTasks.ShowScrollBar = true;
            CompletedSubTasks.Size = new Size(203, 244);
            CompletedSubTasks.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            CompletedSubTasks.StyleManager = null;
            CompletedSubTasks.TabIndex = 57;
            CompletedSubTasks.ThemeAuthor = "Taiizor";
            CompletedSubTasks.ThemeName = "MetroLight";
            // 
            // FinishedTaskBorder
            // 
            FinishedTaskBorder.BackColor = Color.Transparent;
            FinishedTaskBorder.Location = new Point(93, 506);
            FinishedTaskBorder.Name = "FinishedTaskBorder";
            FinishedTaskBorder.OutlineThickness = 2F;
            FinishedTaskBorder.PanelColor = Color.Transparent;
            FinishedTaskBorder.PanelOutlineColor = Color.WhiteSmoke;
            FinishedTaskBorder.Rounding = new Padding(8);
            FinishedTaskBorder.Size = new Size(216, 257);
            FinishedTaskBorder.TabIndex = 58;
            // 
            // cuiButton1
            // 
            cuiButton1.BackColor = Color.Transparent;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.Transparent;
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.Transparent;
            cuiButton1.Content = "Completed SubTasks";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiButton1.ForeColor = Color.White;
            cuiButton1.HoverBackground = Color.Transparent;
            cuiButton1.HoveredImageTint = Color.White;
            cuiButton1.HoverForeColor = Color.White;
            cuiButton1.HoverOutline = Color.WhiteSmoke;
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.ImageTint = Color.White;
            cuiButton1.Location = new Point(99, 474);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.Transparent;
            cuiButton1.NormalOutline = Color.WhiteSmoke;
            cuiButton1.OutlineThickness = 1.6F;
            cuiButton1.PressedBackground = Color.Transparent;
            cuiButton1.PressedForeColor = Color.White;
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.WhiteSmoke;
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(203, 26);
            cuiButton1.TabIndex = 59;
            cuiButton1.TextOffset = new Point(0, 0);
            // 
            // TaskBorder
            // 
            TaskBorder.BackColor = Color.Transparent;
            TaskBorder.Controls.Add(Tasks);
            TaskBorder.Location = new Point(93, 110);
            TaskBorder.Name = "TaskBorder";
            TaskBorder.OutlineThickness = 2F;
            TaskBorder.PanelColor = Color.Transparent;
            TaskBorder.PanelOutlineColor = Color.WhiteSmoke;
            TaskBorder.Rounding = new Padding(8);
            TaskBorder.Size = new Size(216, 264);
            TaskBorder.TabIndex = 61;
            // 
            // Tasks
            // 
            Tasks.BackColor = Color.Transparent;
            Tasks.BorderColor = Color.Transparent;
            Tasks.DisabledBackColor = Color.Transparent;
            Tasks.DisabledForeColor = Color.Transparent;
            Tasks.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tasks.HoveredItemBackColor = SystemColors.ActiveCaption;
            Tasks.HoveredItemColor = Color.Black;
            Tasks.IsDerivedStyle = false;
            Tasks.ItemHeight = 30;
            Tasks.Location = new Point(6, 18);
            Tasks.MultiSelect = false;
            Tasks.Name = "Tasks";
            Tasks.SelectedIndex = -1;
            Tasks.SelectedItem = null;
            Tasks.SelectedItemBackColor = SystemColors.ActiveCaption;
            Tasks.SelectedItemColor = Color.Black;
            Tasks.SelectedText = null;
            Tasks.SelectedValue = null;
            Tasks.ShowBorder = false;
            Tasks.ShowScrollBar = true;
            Tasks.Size = new Size(197, 229);
            Tasks.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            Tasks.StyleManager = null;
            Tasks.TabIndex = 60;
            Tasks.ThemeAuthor = "Taiizor";
            Tasks.ThemeName = "MetroLight";
            Tasks.SelectedIndexChanged += Tasks_SelectedIndexChanged;
            // 
            // UserMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1382, 839);
            Controls.Add(TaskBorder);
            Controls.Add(cuiButton1);
            Controls.Add(CompletedSubTasks);
            Controls.Add(ReloadButton);
            Controls.Add(cuiBorder1);
            Controls.Add(TextUser);
            Controls.Add(WelcomeText);
            Controls.Add(ActiveTasks);
            Controls.Add(ShowTask);
            Controls.Add(LogoutButton);
            Controls.Add(NewTask);
            Controls.Add(EditTask);
            Controls.Add(DeleteButton);
            Controls.Add(FinishedTaskBorder);
            DoubleBuffered = true;
            MaximumSize = new Size(1398, 878);
            Name = "UserMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserMenu";
            FormClosing += UserMenu_FormClosing;
            MouseClick += UserMenu_MouseClick;
            TaskBorder.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CuoreUI.Controls.cuiButton DeleteButton;
        private CuoreUI.Controls.cuiButton EditTask;
        private CuoreUI.Controls.cuiButton NewTask;
        private CuoreUI.Controls.cuiButton LogoutButton;
        private CuoreUI.Controls.cuiButton ShowTask;
        private CuoreUI.Controls.cuiButton ActiveTasks;
        private CuoreUI.Controls.cuiButton WelcomeText;
        private CuoreUI.Controls.cuiButton TextUser;
        private CuoreUI.Controls.cuiBorder cuiBorder1;
        private CuoreUI.Controls.cuiButton ReloadButton;
        private ReaLTaiizor.Controls.MetroListBox CompletedSubTasks;
        private CuoreUI.Controls.cuiBorder FinishedTaskBorder;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiBorder TaskBorder;
        private ReaLTaiizor.Controls.MetroListBox Tasks;
    }
}
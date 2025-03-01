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
            CompletedTaskLb = new CuoreUI.Controls.cuiButton();
            TaskBorder = new CuoreUI.Controls.cuiBorder();
            Tasks = new ReaLTaiizor.Controls.MetroListBox();
            ActiveSubTasksLb = new CuoreUI.Controls.cuiButton();
            ActiveSubList = new ReaLTaiizor.Controls.MetroListBox();
            ActiveSubBorder = new CuoreUI.Controls.cuiBorder();
            DueDateLb = new CuoreUI.Controls.cuiButton();
            DueDatesList = new ReaLTaiizor.Controls.MetroListBox();
            DueDatesBorder = new CuoreUI.Controls.cuiBorder();
            RecurringTaskLb = new CuoreUI.Controls.cuiButton();
            RecurringTaskList = new ReaLTaiizor.Controls.MetroListBox();
            RecurringTaskBorder = new CuoreUI.Controls.cuiBorder();
            RecurringBtn = new CuoreUI.Controls.cuiButton();
            MarkAsCompBtn = new CuoreUI.Controls.cuiButton();
            CompDeleteBtn = new CuoreUI.Controls.cuiButton();
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
            LogoutButton.Location = new Point(803, 78);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.NormalBackground = Color.Transparent;
            LogoutButton.NormalOutline = Color.WhiteSmoke;
            LogoutButton.OutlineThickness = 1F;
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
            ShowTask.OutlineThickness = 1F;
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
            ActiveTasks.OutlineThickness = 1F;
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
            WelcomeText.Content = "Welcome";
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
            WelcomeText.Location = new Point(544, 12);
            WelcomeText.Name = "WelcomeText";
            WelcomeText.NormalBackground = Color.Transparent;
            WelcomeText.NormalOutline = Color.WhiteSmoke;
            WelcomeText.OutlineThickness = 2F;
            WelcomeText.PressedBackground = Color.Transparent;
            WelcomeText.PressedForeColor = Color.White;
            WelcomeText.PressedImageTint = Color.Transparent;
            WelcomeText.PressedOutline = Color.WhiteSmoke;
            WelcomeText.Rounding = new Padding(8);
            WelcomeText.Size = new Size(280, 43);
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
            TextUser.Location = new Point(1081, 12);
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
            CompletedSubTasks.ItemHeight = 40;
            CompletedSubTasks.Location = new Point(408, 506);
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
            FinishedTaskBorder.Location = new Point(402, 500);
            FinishedTaskBorder.Name = "FinishedTaskBorder";
            FinishedTaskBorder.OutlineThickness = 2F;
            FinishedTaskBorder.PanelColor = Color.Transparent;
            FinishedTaskBorder.PanelOutlineColor = Color.WhiteSmoke;
            FinishedTaskBorder.Rounding = new Padding(8);
            FinishedTaskBorder.Size = new Size(216, 257);
            FinishedTaskBorder.TabIndex = 58;
            // 
            // CompletedTaskLb
            // 
            CompletedTaskLb.BackColor = Color.Transparent;
            CompletedTaskLb.CheckButton = false;
            CompletedTaskLb.Checked = false;
            CompletedTaskLb.CheckedBackground = Color.Transparent;
            CompletedTaskLb.CheckedForeColor = Color.White;
            CompletedTaskLb.CheckedImageTint = Color.White;
            CompletedTaskLb.CheckedOutline = Color.Transparent;
            CompletedTaskLb.Content = "Completed SubTasks";
            CompletedTaskLb.DialogResult = DialogResult.None;
            CompletedTaskLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompletedTaskLb.ForeColor = Color.White;
            CompletedTaskLb.HoverBackground = Color.Transparent;
            CompletedTaskLb.HoveredImageTint = Color.White;
            CompletedTaskLb.HoverForeColor = Color.White;
            CompletedTaskLb.HoverOutline = Color.WhiteSmoke;
            CompletedTaskLb.Image = null;
            CompletedTaskLb.ImageAutoCenter = true;
            CompletedTaskLb.ImageExpand = new Point(0, 0);
            CompletedTaskLb.ImageOffset = new Point(0, 0);
            CompletedTaskLb.ImageTint = Color.White;
            CompletedTaskLb.Location = new Point(408, 468);
            CompletedTaskLb.Name = "CompletedTaskLb";
            CompletedTaskLb.NormalBackground = Color.Transparent;
            CompletedTaskLb.NormalOutline = Color.WhiteSmoke;
            CompletedTaskLb.OutlineThickness = 1.6F;
            CompletedTaskLb.PressedBackground = Color.Transparent;
            CompletedTaskLb.PressedForeColor = Color.White;
            CompletedTaskLb.PressedImageTint = Color.White;
            CompletedTaskLb.PressedOutline = Color.WhiteSmoke;
            CompletedTaskLb.Rounding = new Padding(8);
            CompletedTaskLb.Size = new Size(203, 26);
            CompletedTaskLb.TabIndex = 59;
            CompletedTaskLb.TextOffset = new Point(0, 0);
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
            Tasks.ItemHeight = 40;
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
            // ActiveSubTasksLb
            // 
            ActiveSubTasksLb.BackColor = Color.Transparent;
            ActiveSubTasksLb.CheckButton = false;
            ActiveSubTasksLb.Checked = false;
            ActiveSubTasksLb.CheckedBackground = Color.Transparent;
            ActiveSubTasksLb.CheckedForeColor = Color.White;
            ActiveSubTasksLb.CheckedImageTint = Color.White;
            ActiveSubTasksLb.CheckedOutline = Color.Transparent;
            ActiveSubTasksLb.Content = "Active Subtasks";
            ActiveSubTasksLb.DialogResult = DialogResult.None;
            ActiveSubTasksLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActiveSubTasksLb.ForeColor = Color.White;
            ActiveSubTasksLb.HoverBackground = Color.Transparent;
            ActiveSubTasksLb.HoveredImageTint = Color.White;
            ActiveSubTasksLb.HoverForeColor = Color.White;
            ActiveSubTasksLb.HoverOutline = Color.WhiteSmoke;
            ActiveSubTasksLb.Image = null;
            ActiveSubTasksLb.ImageAutoCenter = true;
            ActiveSubTasksLb.ImageExpand = new Point(0, 0);
            ActiveSubTasksLb.ImageOffset = new Point(0, 0);
            ActiveSubTasksLb.ImageTint = Color.White;
            ActiveSubTasksLb.Location = new Point(93, 468);
            ActiveSubTasksLb.Name = "ActiveSubTasksLb";
            ActiveSubTasksLb.NormalBackground = Color.Transparent;
            ActiveSubTasksLb.NormalOutline = Color.WhiteSmoke;
            ActiveSubTasksLb.OutlineThickness = 1.6F;
            ActiveSubTasksLb.PressedBackground = Color.Transparent;
            ActiveSubTasksLb.PressedForeColor = Color.White;
            ActiveSubTasksLb.PressedImageTint = Color.White;
            ActiveSubTasksLb.PressedOutline = Color.WhiteSmoke;
            ActiveSubTasksLb.Rounding = new Padding(8);
            ActiveSubTasksLb.Size = new Size(203, 26);
            ActiveSubTasksLb.TabIndex = 64;
            ActiveSubTasksLb.TextOffset = new Point(0, 0);
            // 
            // ActiveSubList
            // 
            ActiveSubList.BackColor = Color.Transparent;
            ActiveSubList.BorderColor = Color.Transparent;
            ActiveSubList.DisabledBackColor = Color.Transparent;
            ActiveSubList.DisabledForeColor = Color.Transparent;
            ActiveSubList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ActiveSubList.HoveredItemBackColor = Color.Transparent;
            ActiveSubList.HoveredItemColor = Color.Black;
            ActiveSubList.IsDerivedStyle = false;
            ActiveSubList.ItemHeight = 40;
            ActiveSubList.Location = new Point(93, 506);
            ActiveSubList.MultiSelect = false;
            ActiveSubList.Name = "ActiveSubList";
            ActiveSubList.SelectedIndex = -1;
            ActiveSubList.SelectedItem = null;
            ActiveSubList.SelectedItemBackColor = Color.Transparent;
            ActiveSubList.SelectedItemColor = Color.Black;
            ActiveSubList.SelectedText = null;
            ActiveSubList.SelectedValue = null;
            ActiveSubList.ShowBorder = false;
            ActiveSubList.ShowScrollBar = true;
            ActiveSubList.Size = new Size(203, 244);
            ActiveSubList.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            ActiveSubList.StyleManager = null;
            ActiveSubList.TabIndex = 62;
            ActiveSubList.ThemeAuthor = "Taiizor";
            ActiveSubList.ThemeName = "MetroLight";
            // 
            // ActiveSubBorder
            // 
            ActiveSubBorder.BackColor = Color.Transparent;
            ActiveSubBorder.Location = new Point(87, 500);
            ActiveSubBorder.Name = "ActiveSubBorder";
            ActiveSubBorder.OutlineThickness = 2F;
            ActiveSubBorder.PanelColor = Color.Transparent;
            ActiveSubBorder.PanelOutlineColor = Color.WhiteSmoke;
            ActiveSubBorder.Rounding = new Padding(8);
            ActiveSubBorder.Size = new Size(216, 257);
            ActiveSubBorder.TabIndex = 63;
            // 
            // DueDateLb
            // 
            DueDateLb.BackColor = Color.Transparent;
            DueDateLb.CheckButton = false;
            DueDateLb.Checked = false;
            DueDateLb.CheckedBackground = Color.Transparent;
            DueDateLb.CheckedForeColor = Color.White;
            DueDateLb.CheckedImageTint = Color.White;
            DueDateLb.CheckedOutline = Color.Transparent;
            DueDateLb.Content = "Due Dates";
            DueDateLb.DialogResult = DialogResult.None;
            DueDateLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DueDateLb.ForeColor = Color.White;
            DueDateLb.HoverBackground = Color.Transparent;
            DueDateLb.HoveredImageTint = Color.White;
            DueDateLb.HoverForeColor = Color.White;
            DueDateLb.HoverOutline = Color.WhiteSmoke;
            DueDateLb.Image = null;
            DueDateLb.ImageAutoCenter = true;
            DueDateLb.ImageExpand = new Point(0, 0);
            DueDateLb.ImageOffset = new Point(0, 0);
            DueDateLb.ImageTint = Color.White;
            DueDateLb.Location = new Point(697, 468);
            DueDateLb.Name = "DueDateLb";
            DueDateLb.NormalBackground = Color.Transparent;
            DueDateLb.NormalOutline = Color.WhiteSmoke;
            DueDateLb.OutlineThickness = 1.6F;
            DueDateLb.PressedBackground = Color.Transparent;
            DueDateLb.PressedForeColor = Color.White;
            DueDateLb.PressedImageTint = Color.White;
            DueDateLb.PressedOutline = Color.WhiteSmoke;
            DueDateLb.Rounding = new Padding(8);
            DueDateLb.Size = new Size(203, 26);
            DueDateLb.TabIndex = 67;
            DueDateLb.TextOffset = new Point(0, 0);
            // 
            // DueDatesList
            // 
            DueDatesList.BackColor = Color.Transparent;
            DueDatesList.BorderColor = Color.Transparent;
            DueDatesList.DisabledBackColor = Color.Transparent;
            DueDatesList.DisabledForeColor = Color.Transparent;
            DueDatesList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DueDatesList.HoveredItemBackColor = Color.Transparent;
            DueDatesList.HoveredItemColor = Color.Black;
            DueDatesList.IsDerivedStyle = false;
            DueDatesList.ItemHeight = 50;
            DueDatesList.Location = new Point(697, 506);
            DueDatesList.MultiSelect = false;
            DueDatesList.Name = "DueDatesList";
            DueDatesList.SelectedIndex = -1;
            DueDatesList.SelectedItem = null;
            DueDatesList.SelectedItemBackColor = Color.Transparent;
            DueDatesList.SelectedItemColor = Color.Black;
            DueDatesList.SelectedText = null;
            DueDatesList.SelectedValue = null;
            DueDatesList.ShowBorder = false;
            DueDatesList.ShowScrollBar = true;
            DueDatesList.Size = new Size(203, 244);
            DueDatesList.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            DueDatesList.StyleManager = null;
            DueDatesList.TabIndex = 65;
            DueDatesList.ThemeAuthor = "Taiizor";
            DueDatesList.ThemeName = "MetroLight";
            // 
            // DueDatesBorder
            // 
            DueDatesBorder.BackColor = Color.Transparent;
            DueDatesBorder.Location = new Point(691, 500);
            DueDatesBorder.Name = "DueDatesBorder";
            DueDatesBorder.OutlineThickness = 2F;
            DueDatesBorder.PanelColor = Color.Transparent;
            DueDatesBorder.PanelOutlineColor = Color.WhiteSmoke;
            DueDatesBorder.Rounding = new Padding(8);
            DueDatesBorder.Size = new Size(216, 257);
            DueDatesBorder.TabIndex = 66;
            // 
            // RecurringTaskLb
            // 
            RecurringTaskLb.BackColor = Color.Transparent;
            RecurringTaskLb.CheckButton = false;
            RecurringTaskLb.Checked = false;
            RecurringTaskLb.CheckedBackground = Color.Transparent;
            RecurringTaskLb.CheckedForeColor = Color.White;
            RecurringTaskLb.CheckedImageTint = Color.White;
            RecurringTaskLb.CheckedOutline = Color.Transparent;
            RecurringTaskLb.Content = "Completed Tasks";
            RecurringTaskLb.DialogResult = DialogResult.None;
            RecurringTaskLb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecurringTaskLb.ForeColor = Color.White;
            RecurringTaskLb.HoverBackground = Color.Transparent;
            RecurringTaskLb.HoveredImageTint = Color.White;
            RecurringTaskLb.HoverForeColor = Color.White;
            RecurringTaskLb.HoverOutline = Color.WhiteSmoke;
            RecurringTaskLb.Image = null;
            RecurringTaskLb.ImageAutoCenter = true;
            RecurringTaskLb.ImageExpand = new Point(0, 0);
            RecurringTaskLb.ImageOffset = new Point(0, 0);
            RecurringTaskLb.ImageTint = Color.White;
            RecurringTaskLb.Location = new Point(1019, 468);
            RecurringTaskLb.Name = "RecurringTaskLb";
            RecurringTaskLb.NormalBackground = Color.Transparent;
            RecurringTaskLb.NormalOutline = Color.WhiteSmoke;
            RecurringTaskLb.OutlineThickness = 1.6F;
            RecurringTaskLb.PressedBackground = Color.Transparent;
            RecurringTaskLb.PressedForeColor = Color.White;
            RecurringTaskLb.PressedImageTint = Color.White;
            RecurringTaskLb.PressedOutline = Color.WhiteSmoke;
            RecurringTaskLb.Rounding = new Padding(8);
            RecurringTaskLb.Size = new Size(203, 26);
            RecurringTaskLb.TabIndex = 70;
            RecurringTaskLb.TextOffset = new Point(0, 0);
            // 
            // RecurringTaskList
            // 
            RecurringTaskList.BackColor = Color.Transparent;
            RecurringTaskList.BorderColor = Color.Transparent;
            RecurringTaskList.DisabledBackColor = Color.Transparent;
            RecurringTaskList.DisabledForeColor = Color.Transparent;
            RecurringTaskList.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecurringTaskList.HoveredItemBackColor = SystemColors.ActiveCaption;
            RecurringTaskList.HoveredItemColor = Color.Black;
            RecurringTaskList.IsDerivedStyle = false;
            RecurringTaskList.ItemHeight = 40;
            RecurringTaskList.Location = new Point(1019, 506);
            RecurringTaskList.MultiSelect = false;
            RecurringTaskList.Name = "RecurringTaskList";
            RecurringTaskList.SelectedIndex = -1;
            RecurringTaskList.SelectedItem = null;
            RecurringTaskList.SelectedItemBackColor = SystemColors.ActiveCaption;
            RecurringTaskList.SelectedItemColor = Color.Black;
            RecurringTaskList.SelectedText = null;
            RecurringTaskList.SelectedValue = null;
            RecurringTaskList.ShowBorder = false;
            RecurringTaskList.ShowScrollBar = true;
            RecurringTaskList.Size = new Size(203, 244);
            RecurringTaskList.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            RecurringTaskList.StyleManager = null;
            RecurringTaskList.TabIndex = 68;
            RecurringTaskList.ThemeAuthor = "Taiizor";
            RecurringTaskList.ThemeName = "MetroLight";
            RecurringTaskList.SelectedIndexChanged += RecurringTaskList_SelectedIndexChanged;
            // 
            // RecurringTaskBorder
            // 
            RecurringTaskBorder.BackColor = Color.Transparent;
            RecurringTaskBorder.Location = new Point(1013, 500);
            RecurringTaskBorder.Name = "RecurringTaskBorder";
            RecurringTaskBorder.OutlineThickness = 2F;
            RecurringTaskBorder.PanelColor = Color.Transparent;
            RecurringTaskBorder.PanelOutlineColor = Color.WhiteSmoke;
            RecurringTaskBorder.Rounding = new Padding(8);
            RecurringTaskBorder.Size = new Size(216, 257);
            RecurringTaskBorder.TabIndex = 69;
            // 
            // RecurringBtn
            // 
            RecurringBtn.BackColor = Color.Transparent;
            RecurringBtn.CheckButton = false;
            RecurringBtn.Checked = false;
            RecurringBtn.CheckedBackground = Color.Transparent;
            RecurringBtn.CheckedForeColor = Color.White;
            RecurringBtn.CheckedImageTint = Color.White;
            RecurringBtn.CheckedOutline = Color.Transparent;
            RecurringBtn.Content = "Recur";
            RecurringBtn.DialogResult = DialogResult.None;
            RecurringBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecurringBtn.ForeColor = Color.White;
            RecurringBtn.HoverBackground = Color.Transparent;
            RecurringBtn.HoveredImageTint = Color.White;
            RecurringBtn.HoverForeColor = Color.White;
            RecurringBtn.HoverOutline = Color.Transparent;
            RecurringBtn.Image = null;
            RecurringBtn.ImageAutoCenter = true;
            RecurringBtn.ImageExpand = new Point(0, 0);
            RecurringBtn.ImageOffset = new Point(0, 0);
            RecurringBtn.ImageTint = Color.White;
            RecurringBtn.Location = new Point(1121, 763);
            RecurringBtn.Name = "RecurringBtn";
            RecurringBtn.NormalBackground = Color.Transparent;
            RecurringBtn.NormalOutline = Color.WhiteSmoke;
            RecurringBtn.OutlineThickness = 1.6F;
            RecurringBtn.PressedBackground = Color.Transparent;
            RecurringBtn.PressedForeColor = Color.White;
            RecurringBtn.PressedImageTint = Color.White;
            RecurringBtn.PressedOutline = Color.Transparent;
            RecurringBtn.Rounding = new Padding(8);
            RecurringBtn.Size = new Size(101, 26);
            RecurringBtn.TabIndex = 71;
            RecurringBtn.TextOffset = new Point(0, 0);
            RecurringBtn.Click += RecurringBtn_Click_1;
            // 
            // MarkAsCompBtn
            // 
            MarkAsCompBtn.BackColor = Color.Transparent;
            MarkAsCompBtn.CheckButton = false;
            MarkAsCompBtn.Checked = false;
            MarkAsCompBtn.CheckedBackground = Color.Transparent;
            MarkAsCompBtn.CheckedForeColor = Color.White;
            MarkAsCompBtn.CheckedImageTint = Color.White;
            MarkAsCompBtn.CheckedOutline = Color.Transparent;
            MarkAsCompBtn.Content = "Mark As Complete";
            MarkAsCompBtn.DialogResult = DialogResult.None;
            MarkAsCompBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MarkAsCompBtn.ForeColor = Color.White;
            MarkAsCompBtn.HoverBackground = Color.Transparent;
            MarkAsCompBtn.HoveredImageTint = Color.White;
            MarkAsCompBtn.HoverForeColor = Color.White;
            MarkAsCompBtn.HoverOutline = Color.Transparent;
            MarkAsCompBtn.Image = null;
            MarkAsCompBtn.ImageAutoCenter = true;
            MarkAsCompBtn.ImageExpand = new Point(0, 0);
            MarkAsCompBtn.ImageOffset = new Point(0, 0);
            MarkAsCompBtn.ImageTint = Color.White;
            MarkAsCompBtn.Location = new Point(315, 338);
            MarkAsCompBtn.Name = "MarkAsCompBtn";
            MarkAsCompBtn.NormalBackground = Color.Transparent;
            MarkAsCompBtn.NormalOutline = Color.WhiteSmoke;
            MarkAsCompBtn.OutlineThickness = 1F;
            MarkAsCompBtn.PressedBackground = Color.Transparent;
            MarkAsCompBtn.PressedForeColor = Color.White;
            MarkAsCompBtn.PressedImageTint = Color.White;
            MarkAsCompBtn.PressedOutline = Color.Transparent;
            MarkAsCompBtn.Rounding = new Padding(8);
            MarkAsCompBtn.Size = new Size(143, 36);
            MarkAsCompBtn.TabIndex = 72;
            MarkAsCompBtn.TextOffset = new Point(0, 0);
            MarkAsCompBtn.Click += MarkAsCompBtn_Click;
            // 
            // CompDeleteBtn
            // 
            CompDeleteBtn.BackColor = Color.Transparent;
            CompDeleteBtn.CheckButton = false;
            CompDeleteBtn.Checked = false;
            CompDeleteBtn.CheckedBackground = Color.Transparent;
            CompDeleteBtn.CheckedForeColor = Color.White;
            CompDeleteBtn.CheckedImageTint = Color.White;
            CompDeleteBtn.CheckedOutline = Color.Transparent;
            CompDeleteBtn.Content = "Delete";
            CompDeleteBtn.DialogResult = DialogResult.None;
            CompDeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CompDeleteBtn.ForeColor = Color.White;
            CompDeleteBtn.HoverBackground = Color.Transparent;
            CompDeleteBtn.HoveredImageTint = Color.White;
            CompDeleteBtn.HoverForeColor = Color.White;
            CompDeleteBtn.HoverOutline = Color.Transparent;
            CompDeleteBtn.Image = null;
            CompDeleteBtn.ImageAutoCenter = true;
            CompDeleteBtn.ImageExpand = new Point(0, 0);
            CompDeleteBtn.ImageOffset = new Point(0, 0);
            CompDeleteBtn.ImageTint = Color.White;
            CompDeleteBtn.Location = new Point(1013, 763);
            CompDeleteBtn.Name = "CompDeleteBtn";
            CompDeleteBtn.NormalBackground = Color.Transparent;
            CompDeleteBtn.NormalOutline = Color.WhiteSmoke;
            CompDeleteBtn.OutlineThickness = 1.6F;
            CompDeleteBtn.PressedBackground = Color.Transparent;
            CompDeleteBtn.PressedForeColor = Color.White;
            CompDeleteBtn.PressedImageTint = Color.White;
            CompDeleteBtn.PressedOutline = Color.Transparent;
            CompDeleteBtn.Rounding = new Padding(8);
            CompDeleteBtn.Size = new Size(101, 26);
            CompDeleteBtn.TabIndex = 73;
            CompDeleteBtn.TextOffset = new Point(0, 0);
            CompDeleteBtn.Click += CompDeleteBtn_Click;
            // 
            // UserMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = SystemColors.ActiveBorder;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1382, 839);
            Controls.Add(CompDeleteBtn);
            Controls.Add(MarkAsCompBtn);
            Controls.Add(RecurringBtn);
            Controls.Add(RecurringTaskLb);
            Controls.Add(RecurringTaskList);
            Controls.Add(RecurringTaskBorder);
            Controls.Add(DueDateLb);
            Controls.Add(DueDatesList);
            Controls.Add(DueDatesBorder);
            Controls.Add(ActiveSubTasksLb);
            Controls.Add(ActiveSubList);
            Controls.Add(ActiveSubBorder);
            Controls.Add(TaskBorder);
            Controls.Add(CompletedTaskLb);
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
        private CuoreUI.Controls.cuiButton CompletedTaskLb;
        private CuoreUI.Controls.cuiBorder TaskBorder;
        private ReaLTaiizor.Controls.MetroListBox Tasks;
        private CuoreUI.Controls.cuiButton ActiveSubTasksLb;
        private ReaLTaiizor.Controls.MetroListBox ActiveSubList;
        private CuoreUI.Controls.cuiBorder ActiveSubBorder;
        private CuoreUI.Controls.cuiButton DueDateLb;
        private ReaLTaiizor.Controls.MetroListBox DueDatesList;
        private CuoreUI.Controls.cuiBorder DueDatesBorder;
        private CuoreUI.Controls.cuiButton RecurringTaskLb;
        private ReaLTaiizor.Controls.MetroListBox RecurringTaskList;
        private CuoreUI.Controls.cuiBorder RecurringTaskBorder;
        private CuoreUI.Controls.cuiButton RecurringBtn;
        private CuoreUI.Controls.cuiButton MarkAsCompBtn;
        private CuoreUI.Controls.cuiButton CompDeleteBtn;
    }
}
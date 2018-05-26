namespace Dispenser.ui.mainwindow
{
    partial class MainWindow
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
            this.central = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.vS2015DarkTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme();
            this.vS2015LightTheme1 = new WeifenLuo.WinFormsUI.Docking.VS2015LightTheme();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.action_file_save = new System.Windows.Forms.ToolStripMenuItem();
            this.action_file_saveall = new System.Windows.Forms.ToolStripMenuItem();
            this.action_file_quit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.action_view_operation = new System.Windows.Forms.ToolStripMenuItem();
            this.action_view_io = new System.Windows.Forms.ToolStripMenuItem();
            this.action_view_motor = new System.Windows.Forms.ToolStripMenuItem();
            this.action_view_point = new System.Windows.Forms.ToolStripMenuItem();
            this.action_view_communication = new System.Windows.Forms.ToolStripMenuItem();
            this.action_view_navigation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.action_help = new System.Windows.Forms.ToolStripMenuItem();
            this.action_about = new System.Windows.Forms.ToolStripMenuItem();
            this.action_aboutCompany = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.action_login = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // central
            // 
            this.central.Dock = System.Windows.Forms.DockStyle.Fill;
            this.central.DockBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.central.Location = new System.Drawing.Point(0, 25);
            this.central.Name = "central";
            this.central.Padding = new System.Windows.Forms.Padding(6);
            this.central.RightToLeftLayout = true;
            this.central.ShowAutoHideContentOnHover = false;
            this.central.Size = new System.Drawing.Size(800, 425);
            this.central.TabIndex = 0;
            this.central.Theme = this.vS2015DarkTheme1;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuAbout,
            this.menuLogin});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(800, 25);
            this.menuBar.TabIndex = 3;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.action_file_save,
            this.action_file_saveall,
            this.action_file_quit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(58, 21);
            this.menuFile.Text = "文件(&F)";
            // 
            // action_file_save
            // 
            this.action_file_save.Name = "action_file_save";
            this.action_file_save.Size = new System.Drawing.Size(180, 22);
            this.action_file_save.Text = "保存";
            this.action_file_save.Click += new System.EventHandler(this.action_file_save_Click);
            // 
            // action_file_saveall
            // 
            this.action_file_saveall.Name = "action_file_saveall";
            this.action_file_saveall.Size = new System.Drawing.Size(180, 22);
            this.action_file_saveall.Text = "保存所有";
            this.action_file_saveall.Click += new System.EventHandler(this.action_file_saveall_Click);
            // 
            // action_file_quit
            // 
            this.action_file_quit.Name = "action_file_quit";
            this.action_file_quit.Size = new System.Drawing.Size(180, 22);
            this.action_file_quit.Text = "退出";
            this.action_file_quit.Click += new System.EventHandler(this.action_file_quit_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.action_view_operation,
            this.action_view_io,
            this.action_view_motor,
            this.action_view_point,
            this.action_view_communication,
            this.action_view_navigation});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(60, 21);
            this.menuView.Text = "视图(&V)";
            // 
            // action_view_operation
            // 
            this.action_view_operation.Name = "action_view_operation";
            this.action_view_operation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.action_view_operation.Size = new System.Drawing.Size(168, 22);
            this.action_view_operation.Text = "操作界面";
            this.action_view_operation.Click += new System.EventHandler(this.action_view_operation_Click);
            // 
            // action_view_io
            // 
            this.action_view_io.Name = "action_view_io";
            this.action_view_io.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.action_view_io.Size = new System.Drawing.Size(168, 22);
            this.action_view_io.Text = "IO调试";
            this.action_view_io.Click += new System.EventHandler(this.action_view_io_Click);
            // 
            // action_view_motor
            // 
            this.action_view_motor.Name = "action_view_motor";
            this.action_view_motor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.action_view_motor.Size = new System.Drawing.Size(168, 22);
            this.action_view_motor.Text = "电机调试";
            this.action_view_motor.Click += new System.EventHandler(this.action_view_motor_Click);
            // 
            // action_view_point
            // 
            this.action_view_point.Name = "action_view_point";
            this.action_view_point.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
            this.action_view_point.Size = new System.Drawing.Size(168, 22);
            this.action_view_point.Text = "点位调试";
            this.action_view_point.Click += new System.EventHandler(this.action_view_point_Click);
            // 
            // action_view_communication
            // 
            this.action_view_communication.Name = "action_view_communication";
            this.action_view_communication.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
            this.action_view_communication.Size = new System.Drawing.Size(168, 22);
            this.action_view_communication.Text = "通讯调试";
            this.action_view_communication.Click += new System.EventHandler(this.action_view_communication_Click);
            // 
            // action_view_navigation
            // 
            this.action_view_navigation.Name = "action_view_navigation";
            this.action_view_navigation.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
            this.action_view_navigation.Size = new System.Drawing.Size(168, 22);
            this.action_view_navigation.Text = "导航栏";
            this.action_view_navigation.Click += new System.EventHandler(this.action_view_navigation_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.action_help,
            this.action_about,
            this.action_aboutCompany});
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(60, 21);
            this.menuAbout.Text = "关于(&A)";
            // 
            // action_help
            // 
            this.action_help.Name = "action_help";
            this.action_help.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.action_help.Size = new System.Drawing.Size(203, 22);
            this.action_help.Text = "帮助";
            this.action_help.Click += new System.EventHandler(this.action_help_Click);
            // 
            // action_about
            // 
            this.action_about.Name = "action_about";
            this.action_about.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.action_about.Size = new System.Drawing.Size(203, 22);
            this.action_about.Text = "关于";
            this.action_about.Click += new System.EventHandler(this.action_about_Click);
            // 
            // action_aboutCompany
            // 
            this.action_aboutCompany.Name = "action_aboutCompany";
            this.action_aboutCompany.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.action_aboutCompany.Size = new System.Drawing.Size(203, 22);
            this.action_aboutCompany.Text = "关于公司";
            this.action_aboutCompany.Click += new System.EventHandler(this.action_aboutCompany_Click);
            // 
            // menuLogin
            // 
            this.menuLogin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.action_login});
            this.menuLogin.Name = "menuLogin";
            this.menuLogin.Size = new System.Drawing.Size(58, 21);
            this.menuLogin.Text = "登陆(&L)";
            // 
            // action_login
            // 
            this.action_login.Name = "action_login";
            this.action_login.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.action_login.Size = new System.Drawing.Size(143, 22);
            this.action_login.Text = "登陆";
            this.action_login.Click += new System.EventHandler(this.action_login_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.central);
            this.Controls.Add(this.menuBar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuBar;
            this.Name = "MainWindow";
            this.Text = "TD-Dispenser";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private WeifenLuo.WinFormsUI.Docking.DockPanel central;
        private WeifenLuo.WinFormsUI.Docking.VS2015LightTheme vS2015LightTheme1;
        private WeifenLuo.WinFormsUI.Docking.VS2015DarkTheme vS2015DarkTheme1;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
        private System.Windows.Forms.ToolStripMenuItem menuLogin;
        private System.Windows.Forms.ToolStripMenuItem action_login;
        private System.Windows.Forms.ToolStripMenuItem action_about;
        private System.Windows.Forms.ToolStripMenuItem action_aboutCompany;
        private System.Windows.Forms.ToolStripMenuItem action_help;
        private System.Windows.Forms.ToolStripMenuItem action_view_operation;
        private System.Windows.Forms.ToolStripMenuItem action_view_io;
        private System.Windows.Forms.ToolStripMenuItem action_view_motor;
        private System.Windows.Forms.ToolStripMenuItem action_view_point;
        private System.Windows.Forms.ToolStripMenuItem action_view_communication;
        private System.Windows.Forms.ToolStripMenuItem action_view_navigation;
        private System.Windows.Forms.ToolStripMenuItem action_file_quit;
        private System.Windows.Forms.ToolStripMenuItem action_file_save;
        private System.Windows.Forms.ToolStripMenuItem action_file_saveall;
    }
}
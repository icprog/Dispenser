using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;
using Dispenser.ui.operation;
using Dispenser.ui.io;
using Dispenser.ui.motor;
using Dispenser.ui.pointDebug;
using Dispenser.ui.communication;
using Dispenser.ui.navigation;
using Dispenser.ui.login;

namespace Dispenser.ui.mainwindow
{
    public partial class MainWindow : Form
    {
        #region 声明全局变量
        // 【1】 Login
        Login w_login;
        bool logined = false;

        // 【2】 DockWidget
        Operation  w_operation;
        IO         w_io;
        Motor      w_motor;
        PointDebug w_point;
        Communication w_communication;

        Navigation w_navigation;

        // 【3】 

        #endregion

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            // 【1】 初始化Ui
            w_operation = new Operation();          // 操作界面
            w_io = new IO();                        // IO调试
            w_motor = new Motor();                  // 电机调试
            w_point = new PointDebug();             // 点位调试
            w_communication = new Communication();  // 通讯调试

            w_navigation = new Navigation();
            

            w_login = new Login();
            w_login.on_btn_login_clicked += FormLogin_on_btn_login_clicked;
        }

        #region 跨窗口信号槽
        private void FormLogin_on_btn_login_clicked()
        {
            // 【1】 Document
            w_operation.Show(central, DockState.Document);
            w_io.Show(central, DockState.Document);
            w_motor.Show(central, DockState.Document);
            w_point.Show(central, DockState.Document);
            w_communication.Show(central, DockState.Document);

            // 【2】 DockLeft
            w_navigation.Show(central, DockState.DockLeftAutoHide);

            // 【3】 Focus
            w_operation.Focus();
        }
        #endregion

        #region Action
        // 登陆
        private void action_login_Click(object sender, EventArgs e)
        {
            logined = true;
            w_login.Show();
        }

        // 关于
        private void action_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TD-Dispenser\n" +
                            "作者:\t Didiwei\n" +
                            "联系:\t 644356891@qq.com", "关于", MessageBoxButtons.OK);
        }

        // 关于公司
        private void action_aboutCompany_Click(object sender, EventArgs e)
        {
            MessageBox.Show("公司:\t 泰达机器人\n", "关于公司", MessageBoxButtons.OK);
        }

        // 帮助
        private void action_help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("帮助:\t F1\n" +
                            "关于:\t Ctrl + A\n" +
                            "关于公司:\t Ctrl + Shift + A\n" +
                            "登陆:\t Ctrl + L", "帮助", MessageBoxButtons.OK);

        }

        // View
        private void action_view_operation_Click(object sender, EventArgs e)
        {
            // 暂时好像不用做判断, 当其 Show 过后, 才能调用该方法
            w_operation.Activate();
        }

        private void action_view_io_Click(object sender, EventArgs e)
        {
            w_io.Activate();
        }

        private void action_view_motor_Click(object sender, EventArgs e)
        {
            w_motor.Activate();
        }

        private void action_view_point_Click(object sender, EventArgs e)
        {
            w_point.Activate();
        }

        private void action_view_communication_Click(object sender, EventArgs e)
        {
            w_communication.Activate();
        }

        private void action_view_navigation_Click(object sender, EventArgs e)
        {
            if (w_navigation.IsHidden)
            {
                if (logined == true)
                {
                    w_navigation.Show(central, DockState.DockLeft);
                }
            }
            if (w_navigation.DockState == DockState.DockLeftAutoHide)
            {
                w_navigation.Show(central, DockState.DockLeft);
            }
            else
            {
                w_navigation.Activate();
            }
        }

        // 退出
        private void action_file_quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // 保存
        private void action_file_save_Click(object sender, EventArgs e)
        {

        }

        // 保存所有
        private void action_file_saveall_Click(object sender, EventArgs e)
        {

        }
    }
}
#endregion
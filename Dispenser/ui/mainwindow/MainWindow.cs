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
        // 全局变量

        // Login
        Login w_login;

        // DockWidget
        Operation  w_operation;
        IO         w_io;
        Motor      w_motor;
        PointDebug w_point;
        Communication w_communication;
        Navigation w_navigation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            w_operation = new Operation();
            w_io        = new IO();
            w_motor     = new Motor();
            w_point     = new PointDebug();
            w_navigation = new Navigation();
            w_communication = new Communication();

            w_login = new Login();
            w_login.btn_login_changed += LoginForm_btn_login_changed;
        }

        private void LoginForm_btn_login_changed()
        {
            w_operation.Show(central, DockState.Document);
            w_io.Show(central, DockState.Document);
            w_motor.Show(central, DockState.Document);
            w_point.Show(central, DockState.Document);
            w_communication.Show(central, DockState.Document);
            w_navigation.Show(central, DockState.DockLeft);
            w_operation.Focus();
        }

        private void action_login_Click(object sender, EventArgs e)
        {
            w_login.ShowDialog();
            
        }

    }
}

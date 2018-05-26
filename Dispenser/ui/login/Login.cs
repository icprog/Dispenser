using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispenser.ui.login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // 定义信号槽
        public delegate void LoginEventChanged();
        public event LoginEventChanged btn_login_changed;

        private void btn_login_Click(object sender, EventArgs e)
        {
            btn_login_changed();
            this.Hide();
        }


    }
}

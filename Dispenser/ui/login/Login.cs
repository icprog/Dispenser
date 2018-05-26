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
        public delegate void FormLoginEventChanged();
        public event FormLoginEventChanged on_btn_login_clicked;

        private void btn_login_Click(object sender, EventArgs e)
        {
            on_btn_login_clicked();
            this.Hide();
        }


    }
}

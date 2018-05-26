using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WeifenLuo.WinFormsUI.Docking;

namespace Dispenser.ui.operation
{
    public partial class Operation : DockContent
    {
        public Operation()
        {
            InitializeComponent();
        }

        private void Operation_Load(object sender, EventArgs e)
        {
            HNavigationBar hNavigationBar = new HNavigationBar();
            hNavigationBar.Dock = DockStyle.Fill;
            hNavigationBar.FormBorderStyle = FormBorderStyle.None;
            hNavigationBar.TopLevel = false;
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(hNavigationBar);
            hNavigationBar.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dispenser.ui.operation
{
    public partial class HNavigationBar : Form
    {
        public HNavigationBar()
        {
            InitializeComponent();
        }

        private void HNavigationBar_Load(object sender, EventArgs e)
        {

        }

        private void HNavigationBar_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(this.Location, this.Size);
            Graphics graphics = e.Graphics;

            SolidBrush solidBrush = new SolidBrush(Color.Pink);
            graphics.FillRectangle(solidBrush, rect);


        }
    }
}

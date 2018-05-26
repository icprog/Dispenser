using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public enum ColorBackground
{
    White,
    Blue
}


namespace VNavigationBar
{
    public partial class VNavigationBar: UserControl
    {
        private Color _backgroundColor = Color.White;
        private Color _selectedColor = Color.Blue;

        private Color _penBackgroundColor = Color.Black;
        private Color _penSelectedColor = Color.White;

        public VNavigationBar()
        {
            InitializeComponent();
        }

        private void VNavigationBar_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void VNavigationBar_Paint(object sender, PaintEventArgs e)
        {
            Font font = new Font("Microsoft Yahei", 20, FontStyle.Bold);
            Rectangle rect = new Rectangle(this.Location, this.Size);

            Graphics graphics = e.Graphics;

            // 【1】 背景色
            SolidBrush solidBrush_bg = new SolidBrush(_backgroundColor);
            graphics.FillRectangle(solidBrush_bg, rect);

            // 【2】 Items
            SolidBrush solidBrush_sc = new SolidBrush(_selectedColor);
            graphics.FillRectangle(solidBrush_sc, new Rectangle(0, 0, this.Width, 30));

            SolidBrush pen_bg = new SolidBrush(_penBackgroundColor);
            graphics.DrawString("敌敌畏", Font, pen_bg, new Rectangle(0, 0, this.Width, 30));
            // graphics.DrawString("敌敌畏", font, pen_bg, )

    //        for (const QString &str : listItems)
    //{
    //            QPainterPath itemPath;
    //            itemPath.addRect(QRect(0, count * rowHeight, this->width(), rowHeight));

    //            if (currentIndex == count)
    //            {
    //                painter.setPen(penColor_selected);
    //                painter.fillPath(itemPath, QColor(selectedColor));
    //            }
    //            else
    //            {
    //                painter.setPen(penColor_background);
    //                painter.fillPath(itemPath, QColor(backgroundColor));
    //            }

    //            painter.drawText(QRect(0, count * rowHeight, width(), rowHeight), Qt::AlignVCenter | Qt::AlignHCenter, str);
    //            ++count;
    //        }

        }

        [Browsable(true)]
        [Description("背景色"), Category("我的控件")] //DefaultValue("White")
        public Color color_background
        {
            get
            {
                return _backgroundColor;
            }
            set
            {
                _backgroundColor = value;
                this.BackColor = _backgroundColor;
                Update();
            }
        }

        [Browsable(true)]
        [Description("选中色"),  Category("我的控件")] // DefaultValue("Pink"),
        public Color color_selected
        {
            get
            {
                return _selectedColor;
            }
            set
            {
                _selectedColor = value;
                Update();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace task83
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            // Анимационный эффект с градиентом
            Rectangle rec = new Rectangle(150, 10, 90, 90);
            Brush brickBrush = new HatchBrush(HatchStyle.DiagonalBrick, Color.DarkGoldenrod, Color.Cyan);
            Pen brickWidePen = new Pen(brickBrush, 20);
            g.DrawEllipse(brickWidePen, rec);

            // изменяем угол градиента
            for (int i = 0; i < 360; i += 10)
            {
                LinearGradientBrush br = new LinearGradientBrush(rec, Color.DarkViolet, Color.DodgerBlue, i);
                g.FillEllipse(br, rec);
            }
            g.Dispose();
        }
    }
}

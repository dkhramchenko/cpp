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

namespace task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush brickBrush = new HatchBrush(HatchStyle.DiagonalBrick, Color.DarkGoldenrod, Color.Cyan);
            Pen solidBlue = new Pen(Color.FromArgb(0, 0, 255));
            Pen silibWide = new Pen(Color.Blue, 4);
            Pen briclPen = new Pen(brickBrush);
            Pen brickWidePen = new Pen(brickBrush, 10);
            Pen solidYellow = Pens.Yellow;
            e.Graphics.DrawArc(solidBlue, 100, 70, 300, 300, 90, -180);
            e.Graphics.DrawArc(brickWidePen, 150, 70, 200, 300, 90, -180);
        }
    }
}

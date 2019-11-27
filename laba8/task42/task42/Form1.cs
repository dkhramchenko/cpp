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

namespace task42
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GraphicsPath path1 = new GraphicsPath();
        GraphicsPath path2 = new GraphicsPath();
        GraphicsPath path3 = new GraphicsPath();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 175;
            this.Height = 450;
            path1.AddEllipse(25, 25, 100, 100);
            path2.AddEllipse(25, 150, 100, 100);
            path3.AddEllipse(25, 275, 100, 100);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(Color.Black), path1);
            e.Graphics.DrawPath(new Pen(Color.Black), path2);
            e.Graphics.DrawPath(new Pen(Color.Black), path3);
            Graphics g = e.Graphics;
            g.FillEllipse(Brushes.White, 25, 25, 100, 100);
            g.FillEllipse(Brushes.White, 25, 150, 100, 100);
            g.FillEllipse(Brushes.White, 25, 275, 100, 100);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Region region1 = new Region(path1);
            Region region2 = new Region(path2);
            Region region3 = new Region(path3);
            Graphics g = this.CreateGraphics();
            if (region1.IsVisible(e.X, e.Y))
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.FillEllipse(Brushes.Red, 25, 25, 100, 100);
                }
                if (e.Button == MouseButtons.Right)
                {
                    g.FillEllipse(Brushes.White, 25, 25, 100, 100);
                }
            }
            if (region2.IsVisible(e.X, e.Y))
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.FillEllipse(Brushes.Yellow, 25, 150, 100, 100);
                }
                if (e.Button == MouseButtons.Right)
                {
                    g.FillEllipse(Brushes.White, 25, 150, 100, 100);
                }
            }
            if (region3.IsVisible(e.X, e.Y))
            {
                if (e.Button == MouseButtons.Left)
                {
                    g.FillEllipse(Brushes.Green, 25, 275, 100, 100);
                }
                if (e.Button == MouseButtons.Right)
                {
                    g.FillEllipse(Brushes.White, 25, 275, 100, 100);
                }
            }
        }
    }
}

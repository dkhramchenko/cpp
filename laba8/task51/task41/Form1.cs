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

namespace task41
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
            Font f = new Font(Font.FontFamily, 50);
            g.DrawString("Hello world!", f, Brushes.Blue, 34, 34);
            label1.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Font f = new Font(Font.FontFamily, 50);
            g.DrawString("Hello world!", f, Brushes.Green, 30, 30);
        }
    }
}

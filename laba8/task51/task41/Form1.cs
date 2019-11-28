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
            Graphics x = this.CreateGraphics();
            x.DrawString("3аставка!", new Font(Font.FontFamily, 40), Brushes.Red, 44, 24);
            label1.Text = DateTime.Now.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Graphics x = this.CreateGraphics();
            x.DrawString("Заставка!", new Font(Font.FontFamily, 40), Brushes.Black, 40, 20);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

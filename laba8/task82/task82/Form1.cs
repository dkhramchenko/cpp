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

namespace task82
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec1 = new Rectangle(100, 100, 150, 150);
            Rectangle rec2 = new Rectangle(130, 130, 90, 90);
            LinearGradientBrush br1 = new LinearGradientBrush(rec1, Color.Red, Color.Blue, LinearGradientMode.Horizontal);
            LinearGradientBrush br2 = new LinearGradientBrush(rec2, Color.Orange, Color.Green, LinearGradientMode.Horizontal);
            e.Graphics.FillEllipse(br1, 100, 100, 150, 150);
            e.Graphics.FillEllipse(br2, 130, 130, 90, 90);
        }
    }
}

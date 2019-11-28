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

namespace task81
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rec = new Rectangle(1, 1, 600, 600);
            LinearGradientBrush brush = new LinearGradientBrush(rec, Color.OrangeRed, Color.Orange, LinearGradientMode.Horizontal);

            Font f = new Font(Font.FontFamily, 30, FontStyle.Bold);
            e.Graphics.DrawString("Градиентный текст", f, brush, 10, 10);
        }
    }
}

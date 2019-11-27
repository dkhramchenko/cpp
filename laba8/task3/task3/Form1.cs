using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image pic; // экземпляр Image представляет изображение
        Point[] picBounds; // массив точек, задающий границы картинки
        private void Form1_Load(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pic = Image.FromFile(openFileDialog1.FileName);
                this.AutoScrollMinSize = pic.Size;
                picBounds = new Point[3];
                picBounds[0] = new Point(0, 0);
                picBounds[1] = new Point(pic.Width, 0);
                picBounds[2] = new Point(0, pic.Height);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.ScaleTransform(1.0f, 1.0f);
            g.TranslateTransform(AutoScrollPosition.X, AutoScrollPosition.Y);
            g.DrawImage(pic, picBounds);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Создание графческого пути
        GraphicsPath path = new GraphicsPath();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Сохдаём некоторую область из линий
            path.AddLine(0, 0, 100, 100);
            path.AddLine(100, 100, 50, 20);
            path.AddLine(50, 20, 0, 0);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // Рисуем фигуру в соответствии с контуром, записанным в Path
            e.Graphics.DrawPath(new Pen(Color.Red), path);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Region region = new Region(path);
            if (region.IsVisible(e.X, e.Y))
            {
                MessageBox.Show("Попал");
            }
            else
            {
                MessageBox.Show("Промазал");
            }
        }
    }
}

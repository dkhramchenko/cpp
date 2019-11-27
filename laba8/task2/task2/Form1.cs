using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Динамическая коллецция для записи координат точек
        private List<Point> Pts = new List<Point>();

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            // Получение объекта контекста устройства
            Graphics g = this.CreateGraphics();
            // Анализ нажатой кнопки мыши
            if (e.Button == MouseButtons.Left)
            {
                // Если в коллекции уже 4 точки, то пора рисовать кривую Безье
                if (Pts.Count == 4)
                {
                    g.DrawBezier(new Pen(Brushes.Red, 5), Pts[0], Pts[1], Pts[2], Pts[3]);
                }
                else
                {
                    // Если в коллекции ещё нет 4-х точек, то добавим очередную точку
                    Pts.Add(new Point(e.X, e.Y));
                    // и нарисуем на поверхности эллипс
                    g.FillEllipse(Brushes.Red, e.X - 5, e.Y - 5, 10, 10);
                }
            }
            // очистить поверхность и массив при нажатии правой кнопки
            if (e.Button == MouseButtons.Right)
            {
                g.Clear(this.BackColor);
                Pts.Clear();
            }
        }
    }
}

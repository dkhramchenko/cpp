using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            // Рисуем прямоугольник
            g.DrawRectangle(new Pen(Color.ForestGreen, 5), 10, 10, 100, 100);
            // Пишем текст
            g.DrawString("Графичекий текст", new Font(Font.FontFamily, 16),
                Brushes.Azure, this.Width / 2, this.Height / 2);
            // Повернём текст на 30 градусов
            g.RotateTransform(30);
            g.DrawString("Повёрнутый текст", new Font(Font.FontFamily, 45),
                Brushes.BlueViolet, 50, 50);
            // Возвращаем объект g в исходное состояние
            g.ResetTransform();
            // Рисуем солнышко
            Font f = new Font("Tahoma", 24, FontStyle.Bold);
            for (int i = 0; i < 360; i += 15)
            {
                g.DrawString("Солнце", f, Brushes.Yellow, 50, 0);
                g.RotateTransform(20);
            }
            // Возвращаем g в исходное состояние
            g.ResetTransform();
            // Рисуем эллипсы
            Pen p = new Pen(Color.Green);
            for (int i = 0; i < 400; i += 20)
            {
                g.DrawEllipse(p, 500 + i, 100, 10 - 2 * i, 200);
            }
        }
    }
}

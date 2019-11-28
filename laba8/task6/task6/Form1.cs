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

namespace task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush br1 = new SolidBrush(Color.BlanchedAlmond);
            Brush br2 = new SolidBrush(Color.FromArgb(255, 155, 100));

            e.Graphics.FillEllipse(br1, 0, 0, 2 * ClientSize.Width / 3, 2 * ClientSize.Height / 3);
            e.Graphics.FillEllipse(br2, ClientSize.Width / 3, ClientSize.Height / 3, ClientSize.Width / 2, 2 * ClientSize.Height / 3);
            
            // штриховая кисть
            Brush cb1 = new HatchBrush(HatchStyle.Cross, Color.Azure);
            // Фоновый цвет для CrossBrush - чёрный
            Brush cb2 = new HatchBrush(HatchStyle.DiagonalBrick, Color.DarkGoldenrod, Color.Cyan);

            // Ограничивающий прямоугольник для круга
            Rectangle rec = new Rectangle(10, 10, 90, 90);
            
            // Перо для прорисовки контура
            Pen p = new Pen(Color.RoyalBlue);

            // Рисуем контур эллипса
            e.Graphics.DrawEllipse(p, rec);

            // Создаём горизонтальный градиент
            LinearGradientBrush brush = new LinearGradientBrush(rec, Color.RoyalBlue,
                Color.DeepSkyBlue, LinearGradientMode.Horizontal);

            // Заливка эллипса градиентом
            e.Graphics.FillEllipse(brush, rec);
            e.Graphics.Dispose();
        }
    }
}

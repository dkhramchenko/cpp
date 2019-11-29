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

        private void Form1_Load(object sender, EventArgs e)
        {
            Car c1 = new Car();
            c1.Brand = "BMW";
            c1.Color = "Red";
            c1.Price = 100000;
            c1.Weight = 1900;
            richTextBox1.Text =
                String.Format("Марка: {0}, Цвет: {1}, Цена {2}$, Вес: {3}кг", c1.Brand, c1.Color, c1.Price, c1.Weight);

            Cars c2 = new Cars();
            c2.Brand = "Audi";
            c2.Color = "Blue";
            c2.Price = 120000;
            c2.Weight = 1800;
            richTextBox1.Text +=
                String.Format("\nМарка: {0}, Цвет: {1}, Цена {2}$, Вес: {3}кг", c2.Brand, c2.Color, c2.Price, c2.Weight);

            richTextBox1.Text +=
                String.Format("\nGetHashCode: {0}, GetType: {1}, ToString: {2}", c1.GetHashCode(), c1.GetType(), c1.ToString());
        }
    }
}

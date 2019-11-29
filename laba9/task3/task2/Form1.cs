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
            Passenger p1 = new Passenger();
            p1.Brand = "BMW";
            p1.Color = "Red";
            p1.Price = 100000;
            p1.Weight = 1900;
            
            richTextBox1.Text =
                String.Format("Марка: {0}, Цвет: {1}, Цена {2}$, Вес: {3}кг", p1.Brand, p1.Color, p1.Price, p1.Weight);

            richTextBox1.Text +=
                String.Format("\nGetHashCode: {0}, GetType: {1}, ToString: {2}", p1.GetHashCode(), p1.GetType(), p1.ToString());
        }
    }
}

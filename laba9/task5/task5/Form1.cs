using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car.Brand = "Audi";
            Car c = new Car
            {
                Price = 100000,
                Weight = 100000
            };
            richTextBox1.Text =
                String.Format("марка: {0}; цвет: {1}; цена: {2}; вес: {3}",
                Car.Brand, Car.Color, c.Price, c.Weight);
            Car.Brand = "Audi";

        }
    }
}

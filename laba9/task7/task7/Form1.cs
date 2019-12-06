using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Brand = "audi",
                Color = "red",
                Price = 123,
                Weight = 2000
            };
            richTextBox1.Text =
                String.Format("марка: {0}; цвет: {1}; цена: {2}; вес: {3}",
                car.Brand, car.Color, car.Price, car.Weight);
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

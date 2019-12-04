using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLib;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Car c = new Car
            {
                Brand = "Audi",
                Color = "pink",
                Price = 100000,
                Weight = 100000
            };
            richTextBox1.Text =
                String.Format("марка: {0}; цвет: {1}; цена: {2}; вес: {3}",
                c.Brand, c.Color, c.Price, c.Weight);
        }
    }
}

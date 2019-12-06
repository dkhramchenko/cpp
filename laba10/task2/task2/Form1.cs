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
            Car c1 = new Car("audi", 100);
            Car c2 = new Car("bmw");
            richTextBox1.Text += String.Format("Марка: {0}; Цена: {1}\n", c1.Brand, c1.Price);
            richTextBox1.Text += String.Format("Марка: {0}", c2.Brand);
        }
    }
}

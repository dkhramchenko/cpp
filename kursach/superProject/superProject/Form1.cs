using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Brand brand = new Brand("Audi", "Germany", "1950");
            MainSpecs mainSpecs = new MainSpecs("2000", "Red", "100000", "2010");
            Car car = new Car(brand, mainSpecs);
            richTextBox1.Text = car.ToString();
        }
    }
}

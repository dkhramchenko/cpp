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

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car = new Car(1000);
            textBox1.Text = car.CarText();
            car.CarText(pictureBox1);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

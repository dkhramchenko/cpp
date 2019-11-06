using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (checkBox1.Checked)
            {
                double priceSandwitch = 200;
                price += priceSandwitch;
            }
            if (checkBox2.Checked)
            {
                double pricePotato = 100;
                price += pricePotato;
            }
            if (checkBox3.Checked)
            {
                double priceSauce = 50;
                price += priceSauce;
            }
            if (checkBox4.Checked)
            {
                double priceCocaCola = 80;
                price += priceCocaCola;
            }
            label1.Text = String.Format("Стоимость заказа: {0:f2}р.", price);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox3.Enabled = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox3.Enabled = true;
            }
            else
            {
                checkBox3.Checked = false;
                checkBox3.Enabled = false;
            }
        }
    }
}

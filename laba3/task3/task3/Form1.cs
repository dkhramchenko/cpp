using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Данные неполные!");
            }
            else
            {
                double priceUSD = Convert.ToDouble(textBox1.Text);
                double rate = Convert.ToDouble(textBox2.Text);
                double rub = priceUSD * rate;
                label4.Text = textBox1.Text + " USD = " + rub.ToString() + "р.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

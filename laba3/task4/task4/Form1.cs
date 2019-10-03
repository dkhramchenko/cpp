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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Неполные данные!");
            }
            else
            {
                double previous = Convert.ToDouble(textBox1.Text);
                double current = Convert.ToDouble(textBox2.Text);
                double rate = Convert.ToDouble(textBox3.Text);
                double cash = (current - previous) * rate;

                label5.Text = String.Format("Сумма к оплате: {0:f2}р.", cash);
            }
        }
    }
}

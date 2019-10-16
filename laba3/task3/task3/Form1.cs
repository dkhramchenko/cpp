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
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            if (t1 == "" || t2 == "")
            {
                System.Windows.Forms.MessageBox.Show("Данные неполные!");
                return;
            }
            int zapyatayat1 = 0;
            foreach (var symbol in t1)
            {
                if (symbol == ',')
                {
                    ++zapyatayat1;
                }
                if (char.IsDigit(symbol) != true && symbol != ',')
                {
                    System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                    return;
                }
            }
            int zapyatayat2 = 0;
            foreach (var symbol in t2)
            {
                if (symbol == ',')
                {
                    ++zapyatayat2;
                }
                if (char.IsDigit(symbol) != true && symbol != ',')
                {
                    System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                    return;
                }
            }
            if (zapyatayat1 > 1 || zapyatayat2 > 1)
            {
                System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                return;
            }
            double priceUSD = Convert.ToDouble(t1);
            double rate = Convert.ToDouble(t2);
            double rub = priceUSD * rate;
            label4.Text = String.Format("{0:f2} USD = {1:f2}р.", priceUSD, rub);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

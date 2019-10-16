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
            string t1 = textBox1.Text;
            string t2 = textBox2.Text;
            string t3 = textBox3.Text;
            if (t1 == "" || t2 == "" || t3 == "")
            {
                System.Windows.Forms.MessageBox.Show("Неполные данные!");
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
            int zapyatayat3 = 0;
            foreach (var symbol in t3)
            {
                if (symbol == ',')
                {
                    ++zapyatayat3;
                }
                if (char.IsDigit(symbol) != true && symbol != ',')
                {
                    System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                    return;
                }
            }
            if (zapyatayat1 > 1 || zapyatayat2 > 1 || zapyatayat3 > 1)
            {
                System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                return;
            }
            double previous = Convert.ToDouble(textBox1.Text);
            double current = Convert.ToDouble(textBox2.Text);
            double rate = Convert.ToDouble(textBox3.Text);
            double cash = (current - previous) * rate;

            label5.Text = String.Format("Сумма к оплате: {0:f2}р.", cash);
        }
    }
}

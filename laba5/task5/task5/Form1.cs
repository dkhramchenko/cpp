using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task5
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
                System.Windows.Forms.MessageBox.Show("Введите данные!");
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
            int width = Convert.ToInt32(textBox1.Text);
            int height = Convert.ToInt32(textBox2.Text);
            int k;
            string s;
            if (radioButton1.Checked)
            {
                k = 1;
                s = "Однокамерный";
            }
            else
            {
                k = 2;
                s = "Двухкамерный";
            }
            int pod = 0;
            if (checkBox1.Checked)
            {
                pod = 1000;
            }
            int price = width * height * k * 10 + pod;
            label5.Text = string.Format("Размер окна: {0} х {1} см\nСтеклопакет: {2}\nСтоимость: {3}р.", width, height, s, price);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
    }
}

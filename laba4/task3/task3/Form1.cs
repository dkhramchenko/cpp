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
            string t = textBox1.Text;
            if (t == "" || comboBox1.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("Заполните все поля!");
                return;
            }
            int zapyatayat = 0;
            foreach (var symbol in t)
            {
                if (symbol == ',')
                {
                    ++zapyatayat;
                }
                if (char.IsDigit(symbol) != true && symbol != ',')
                {
                    System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                    return;
                }
            }
            if (zapyatayat > 1)
            {
                System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                return;
            }
            
            string fuel = comboBox1.SelectedItem.ToString();

            switch (fuel)
            {
                case "92":
                    {
                        double priceLitr = 49;
                        double cash = Convert.ToDouble(textBox1.Text);
                        double litr = cash / priceLitr;
                        litr = Convert.ToInt32(100 * litr) / 100.0;
                        double sdacha = cash - priceLitr * litr;
                        label3.Text = String.Format(
                            "Литров: {0:f2}\nСумма: {1:f2}р.\nСдача: {2:f2}р.\nЦена за литр: {3:f2}р.",
                            litr, cash, sdacha, priceLitr);
                        break;
                    }
                case "95":
                    {
                        double priceLitr = 55;
                        double cash = Convert.ToDouble(textBox1.Text);
                        double litr = cash / priceLitr;
                        litr = Convert.ToInt32(100 * litr) / 100.0;
                        double sdacha = cash - priceLitr * litr;
                        label3.Text = String.Format(
                            "Литров: {0:f2}\nСумма: {1:f2}р.\nСдача: {2:f2}р.\nЦена за литр: {3:f2}р.",
                            litr, cash, sdacha, priceLitr);
                        break;
                    }
                case "98":
                    {
                        double priceLitr = 59;
                        double cash = Convert.ToDouble(textBox1.Text);
                        double litr = cash / priceLitr;
                        litr = Convert.ToInt32(100 * litr) / 100.0;
                        double sdacha = cash - priceLitr * litr;
                        label3.Text = String.Format(
                            "Литров: {0:f2}\nСумма: {1:f2}р.\nСдача: {2:f2}р.\nЦена за литр: {3:f2}р.",
                            litr, cash, sdacha, priceLitr);
                        break;
                    }
                case "ДТ":
                    {
                        double priceLitr = 61;
                        double cash = Convert.ToDouble(textBox1.Text);
                        double litr = cash / priceLitr;
                        litr = Convert.ToInt32(100 * litr) / 100.0;
                        double sdacha = cash - priceLitr * litr;
                        label3.Text = String.Format(
                            "Литров: {0:f2}\nСумма: {1:f2}р.\nСдача: {2:f2}р.\nЦена за литр: {3:f2}р.",
                            litr, cash, sdacha, priceLitr);
                        break;
                    }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

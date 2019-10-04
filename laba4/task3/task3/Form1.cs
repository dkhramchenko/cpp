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
            if (textBox1.Text == "" || comboBox1.SelectedItem == null || textBox2.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Заполните все поля!");
            }
            else
            {
                string fuel = comboBox1.SelectedItem.ToString();

                switch (fuel)
                {
                    case "92":
                        {
                            double tank = Convert.ToDouble(textBox2.Text);
                            double litr = 50;
                            double price = litr * tank;
                            double cash = Convert.ToDouble(textBox1.Text);
                            double sdacha = cash - price;
                            label3.Text = String.Format("Литров: {0:f2}\nСумма: {1:f2}р.\nСдача: {2:f2}р.\nЦена за литр: {3:f2}р.",
                                tank, cash, sdacha, litr);
                            break;
                        }
                    case "95":
                        {
                            double tank = Convert.ToDouble(textBox2.Text);
                            double litr = 60;
                            double price = litr * tank;
                            double cash = Convert.ToDouble(textBox1.Text);
                            double sdacha = cash - price;

                            label3.Text = String.Format("Литров: {0:f2}\nСумма: {1:f2}р.\nСдача: {2:f2}р.\nЦена за литр: {3:f2}р.",
                                tank, cash, sdacha, litr);
                            break;
                        }
                    case "98":
                        {
                            double tank = Convert.ToDouble(textBox2.Text);
                            double litr = 70;
                            double price = litr * tank;
                            double cash = Convert.ToDouble(textBox1.Text);
                            double sdacha = cash - price;
                            label3.Text = String.Format("Литров: {0:f2}\nСумма: {1:f2}р.\nСдача: {2:f2}р.\nЦена за литр: {3:f2}р.",
                                tank, cash, sdacha, litr);
                            break;
                        }
                    case "ДТ":
                        {
                            double tank = Convert.ToDouble(textBox2.Text);
                            double litr = 55;
                            double price = litr * tank;
                            double cash = Convert.ToDouble(textBox1.Text);
                            double sdacha = cash - price;
                            label3.Text = String.Format("Литров: {0:f2}\nСумма: {1:f2}р.\nСдача: {2:f2}р.\nЦена за литр: {3:f2}р.",
                                tank, cash, sdacha, litr);
                            break;
                        }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

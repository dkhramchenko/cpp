using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task2
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

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label1.Visible = true;
            textBox1.Visible = true;
            button1.Visible = true;

            label1.Text = listBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string answer = textBox1.Text;
            switch (answer)
            {
                case "да":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "Да":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "ДА":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "Нет":
                    System.Windows.Forms.MessageBox.Show("жаль");
                    break;
                case "НЕТ":
                    System.Windows.Forms.MessageBox.Show("жаль");
                    break;
                case "нет":
                    System.Windows.Forms.MessageBox.Show("жаль");
                    break;
                case "no":
                    System.Windows.Forms.MessageBox.Show("жаль");
                    break;
                case "NO":
                    System.Windows.Forms.MessageBox.Show("жаль");
                    break;
                case "No":
                    System.Windows.Forms.MessageBox.Show("жаль");
                    break;
                case "YES":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "n":
                    System.Windows.Forms.MessageBox.Show("жаль");
                    break;
                case "N":
                    System.Windows.Forms.MessageBox.Show("жаль");
                    break;
                case "Y":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "y":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "Yes":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "yes":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "yES":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                case "yeS":
                    System.Windows.Forms.MessageBox.Show("Класс!!!");
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Некорректный ответ");
                    break;
            }
        }
    }
}

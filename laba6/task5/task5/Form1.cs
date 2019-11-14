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

        List<int> list = new List<int>() { 19, 23, 29, 19, 12 };

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < list.Count; ++i)
            {
                listBox1.Items.Add(list[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Введите элемент!");
                return;
            }
            string t = textBox1.Text;
            foreach (var symbol in t)
            {
                if (char.IsDigit(symbol) != true)
                {
                    System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                    return;
                }
            }
            int el = Convert.ToInt32(t);
            int index = list.IndexOf(el);
            if (index == -1)
            {
                System.Windows.Forms.MessageBox.Show("Нет такого элемента!");
                return;
            }
            System.Windows.Forms.MessageBox.Show("Индекс первого вхождения = " + index.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Введите элемент!");
                return;
            }
            string t = textBox1.Text;
            foreach (var symbol in t)
            {
                if (char.IsDigit(symbol) != true)
                {
                    System.Windows.Forms.MessageBox.Show("Данные некорректные!");
                    return;
                }
            }
            int el = Convert.ToInt32(t);
            int index = list.LastIndexOf(el);
            if (index == -1)
            {
                System.Windows.Forms.MessageBox.Show("Нет такого элемента!");
                return;
            }
            System.Windows.Forms.MessageBox.Show("Индекс последнего вхождения = " + index.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Sort();
            listBox1.Items.Clear();
            for (int i = 0; i < list.Count; ++i)
            {
                listBox1.Items.Add(list[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list.Reverse();
            listBox1.Items.Clear();
            for (int i = 0; i < list.Count; ++i)
            {
                listBox1.Items.Add(list[i]);
            }
        }
    }
}

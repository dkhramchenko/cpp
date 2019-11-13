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

        List<int> list;

        private void Form1_Load(object sender, EventArgs e)
        {
            list = new List<int>() { 19, 23, 29, 19, 12 };
            listBox1.DataSource = list;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Введите элемент!");
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
            System.Windows.Forms.MessageBox.Show(index.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Введите элемент!");
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
            System.Windows.Forms.MessageBox.Show(index.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            list.Sort();
            listBox1.DataSource = list;
        }
    }
}

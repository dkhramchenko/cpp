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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Введите текст!");
                return;
            }
            int digit = 0;
            int uppercase = 0;
            int lowercase = 0;
            int special = 0;

            foreach (var ch in textBox1.Text)
            {
                if (char.IsDigit(ch))
                {
                    ++digit;
                }
                if (char.IsUpper(ch))
                {
                    ++uppercase;
                }
                if (char.IsLower(ch))
                {
                    ++lowercase;
                }
                if (char.IsSymbol(ch))
                {
                    ++special;
                }
            }
            label2.Text = String.Format("Цифр: {0}\nБольших букв: {1}\nМаленьких букв: {2}\nСпецсимволов: {3}", digit, uppercase, lowercase, special);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

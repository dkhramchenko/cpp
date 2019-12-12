using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (richTextBoxBrand.Text == "" || richTextBoxPrice.Text == "")
            {
                MessageBox.Show("Поля не могут быть пустыми!");
                return;
            }
            foreach (var ch in richTextBoxPrice.Text)
            {
                if (!Char.IsDigit(ch))
                {
                    MessageBox.Show("Цена может содержать только цифры");
                    return;
                }
            }
            Car c = new Car
            {
                Brand = richTextBoxBrand.Text,
                Price = Convert.ToInt32(richTextBoxPrice.Text)
            };
            if (c.Correct())
            {
                richTextBoxCars.Text += String.Format("Марка: {0}; Цена: {1}\n", c.Brand, c.Price);
            }
            else
            {
                MessageBox.Show("Некорректные данные!");
            }
        }

        private void RichTextBoxCars_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;
            
            if (s1 == "" || s2 == "")
            {
                System.Windows.Forms.MessageBox.Show("Введите данные!");
            }
            else
            {
                int width = Convert.ToInt32(s1);
                int height = Convert.ToInt32(s2);
                int alum = 20;
                int plast = 10;
                int price = width * height;
                string mat = "";

                if (radioButton1.Checked)
                {
                    price *= alum;
                    mat = "алюминий";
                }
                else
                {
                    price *= plast;
                    mat = "пластик";
                }

                label3.Text = String.Format("Размер: {0:f2} x {1:f2} см\nМатериал: {2}\nСтоимость: {3:f2}р.", width, height, mat, price);
            }
        }
    }
}

﻿using System;
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
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Данные неполные!");
            }
            else
            {
                double priceUSD = Convert.ToDouble(textBox1.Text);
                double rate = Convert.ToDouble(textBox2.Text);
                double rub = priceUSD * rate;
                label4.Text = String.Format("{0:f2} USD = {1:f2}р.", priceUSD, rub);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

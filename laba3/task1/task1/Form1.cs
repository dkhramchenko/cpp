﻿using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.Visible = true;
                button1.Visible = true;
                panel2.Visible = true;
                label2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Номер факса не введён!");
                return;
            }
            string faks = textBox1.Text;
            foreach (var symbol in faks)
            {
                if (Char.IsDigit(symbol) != true && symbol != ' ')
                {
                    System.Windows.Forms.MessageBox.Show("Номер факса некорректный!");
                    return;
                }
            }
            System.Windows.Forms.MessageBox.Show("Ваш факс отправлен!");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                textBox1.Visible = false;
                button1.Visible = false;
                panel2.Visible = false;
                label2.Visible = false;
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

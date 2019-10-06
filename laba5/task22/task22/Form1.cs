﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task22
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
                System.Windows.Forms.MessageBox.Show("Введите пароль!");
            }
            else
            {
                foreach (var ch in textBox1.Text)
                {
                    if (char.IsLetter(ch))
                    {
                        System.Windows.Forms.MessageBox.Show("Пароль не должен содержать буквы!");
                        return;
                    }
                }
                System.Windows.Forms.MessageBox.Show("Пароль корректен!");
            }
        }
    }
}

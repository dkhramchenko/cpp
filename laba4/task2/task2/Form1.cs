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

            string question = listBox1.SelectedItem.ToString();
            switch (question)
            {
                case "Вопрос1":
                    label1.Text = "Ответ на Вопрос1";
                    break;
                case "Вопрос2":
                    label1.Text = "Ответ на Вопрос2";
                    break;
                case "Вопрос3":
                    label1.Text = "Ответ на Вопрос3";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            textBox1.Clear();
            textBox1.BackColor = Color.Azure;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
        }
    }
}

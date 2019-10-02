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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c1, c2;
            c1 = listBox1.SelectedItem.ToString();
            if (c1 == "red")
            {
                button1.BackColor = Color.FromName(c1);
                c2 = "gray";
                button1.ForeColor = Color.FromName(c2);
            }
            if (c1 == "blue")
            {
                button1.BackColor = Color.FromName(c1);
                c2 = "pink";
                button1.ForeColor = Color.FromName(c2);
            }
            if (c1 == "yellow")
            {
                button1.BackColor = Color.FromName(c1);
                c2 = "green";
                button1.ForeColor = Color.FromName(c2);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string color1, color2;
            color1 = listBox1.SelectedItem.ToString();
            label1.ForeColor = Color.FromName(color1);
            if (color1 == "red")
            {
                color2 = "gray";
                label1.BackColor = Color.FromName(color2);
            }
            else if (color1 == "blue")
            {
                color2 = "yellow";
                label1.BackColor = Color.FromName(color2);
            }
            else
                label1.BackColor = Color.FromName("pink");
        }
    }
}

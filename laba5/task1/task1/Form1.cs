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

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int size = listBox1.Items.Count;
            for (int i = 0; i < size; ++i)
            {
                int el = Convert.ToInt32(listBox1.Items[i]);
                if (el % 2 == 0)
                {
                    sum += el;
                }
            }
            label1.Text = sum.ToString();
        }
    }
}

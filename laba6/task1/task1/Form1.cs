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

        int[] numbers = new int[] { 4, 9, 12, 56, 45 };

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var n in numbers)
            {
                int index = Array.IndexOf(numbers, n);
                string s = String.Format("{0} элемент = {1}", index, n);
                listBox1.Items.Add(s);
            }
        }
    }
}

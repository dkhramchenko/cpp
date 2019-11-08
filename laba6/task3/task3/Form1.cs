using System;
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
            int[][] m = new int[3][];
            m[0] = new int[] { 1, 2 };
            m[1] = new int[] { 3, 4, 5, 6 };
            m[2] = new int[] { 7, 8, 9 };
            for (int row = 0; row < m.Length; ++row)
            {
                for (int col = 0; col < m[row].Length; ++col)
                {
                    richTextBox1.Text += String.Format("{0}{1} элемент = {2};", row, col, m[row][col]);
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}

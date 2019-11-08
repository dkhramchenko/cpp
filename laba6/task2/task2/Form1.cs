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

        int[,] m = new int[,] { { 4, 9, 12 }, { 56, 45, 23 }, { 3, 67, 89 } }; // объявление и инициализация двумерного массива m
        private void button1_Click(object sender, EventArgs e)
        {   
            for (int i = 0; i <= m.GetUpperBound(0); ++i)
            {
                for (int j = 0; j <= m.GetUpperBound(1); ++j)
                {
                    richTextBox1.Text += String.Format("{0}{1} элемент = {2};", i, j, m[i, j]); // добавление элемента массива(строка i, столбец j, элемент m[i, j]) в richtextbox1
                }
                richTextBox1.Text += "\n"; // переход на новую строчку после добавления всех элементов текущей(i-ой) строки массива m
            }
        }
    }
}

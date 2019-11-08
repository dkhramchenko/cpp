using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var intList = new List<int>() { 1, 2 };
            var strList = new List<string>() { "строка 1", "строка 2", "строка 3" };
            richTextBox1.Text = "ёмоксть списка из чисел = " + intList.Capacity.ToString();
            richTextBox1.Text += "\n" + "ёмоксть списка из строк = " + strList.Capacity.ToString();
            intList.Add(3);
            richTextBox1.Text += "\n" + "ёмоксть списка из чисел = " + intList.Capacity.ToString();
            strList.Add("строка 4");
            richTextBox1.Text += "\n" + "ёмоксть списка из строк = " + strList.Capacity.ToString();
            intList.Insert(1, 10);
            richTextBox1.Text += "\n";
            for (int i = 0; i < 4; ++i)
            {
                richTextBox1.Text += intList[i].ToString() + " ";
            }
            strList.Remove("строка 2");
            richTextBox1.Text += "\n";
            for (int i = 0; i < 3; ++i)
            {
                richTextBox1.Text += strList[i] + " ";
            }
            intList.RemoveAt(1);
            richTextBox1.Text += "\n";
            for (int i = 0; i < 3; ++i)
            {
                richTextBox1.Text += intList[i].ToString() + " ";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Список пуст!");
                return;
            }
            textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Список пуст!");
                return;
            }
            listBox1.Items[listBox1.SelectedIndex] = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Список пуст!");
                return;
            }
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            if (listBox1.Items.Count != 0)
            {
                listBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Список пуст!");
                return;
            }
            List<string> l = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; ++i)
            {
                l.Add(listBox1.Items[i].ToString());
            }
            l.Sort();
            listBox1.Items.Clear();
            for (int i = 0; i < l.Count; ++i)
            {
                listBox1.Items.Add(l[i]);
            }
            listBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Список пуст!");
                return;
            }
            List<string> l = new List<string>();
            for (int i = 0; i < listBox1.Items.Count; ++i)
            {
                l.Add(listBox1.Items[i].ToString());
            }
            l.Sort();
            l.Reverse();
            listBox1.Items.Clear();
            for (int i = 0; i < l.Count; ++i)
            {
                listBox1.Items.Add(l[i]);
            }
            listBox1.SelectedIndex = 0;
        }
    }
}

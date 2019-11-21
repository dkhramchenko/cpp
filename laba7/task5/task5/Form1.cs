using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool correct(string s)
        {
            if (s == "")
            {
                return false;
            }
            int zapytaya = 0;
            foreach (var ch in s)
            {
                if (!Char.IsDigit(ch) && ch != ',')
                {
                    return false;
                }
                if (ch == ',')
                {
                    ++zapytaya;
                }
            }
            if (zapytaya > 1)
            {
                return false;
            }
            return true;
        }

        private void buttonOchistit_Click(object sender, EventArgs e)
        {
            textBoxTovar.Clear();
            textBoxStoimost.Clear();
            textBoxVes.Clear();
        }

        private void Zapisat_Click(object sender, EventArgs e)
        {
            string tov = textBoxTovar.Text;
            string st = textBoxStoimost.Text;
            string ves = textBoxVes.Text;
            string date = dateTimePicker1.Value.ToShortDateString();
            if (tov != "" && correct(st) && correct(ves))
            {
                double ST = Convert.ToDouble(st);
                double VES = Convert.ToDouble(ves);
                string line = new string('*', 100) + "\n\n";
                richTextBox1.Text += 
                    String.Format("товар: {0}, стоимость={1:f2} ₽/кг., вес={2:f2}кг.,\nпоступили: {3}\n{4}", tov, ST, VES, date, line);
            }
            else
            {
                MessageBox.Show("Некорректные данные!");
            }
        }

        private void buttonProchitatIzFaila_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void buttonZapisatVFail_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                writer.WriteLine(richTextBox1.Text);
                writer.Close();
                richTextBox1.Clear();
            }
        }
    }
}

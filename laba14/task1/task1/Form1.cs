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

        private void Form1_Load(object sender, EventArgs e)
        {
            Car car = new Car("audi", 100000, 2000, 100, 25);
            car.Crashes = new int[]{ 1, 2, 3, 4};
            richTextBox1.Text +=
                String.Format("Марка: {0}; Цена: {1}$; Масса: {2}кг; Бак: {3}л; Расход топлива: {4}л/100км;\n",
                car["brand"], car["price"], car["weigth"], car["tankCapacity"], car["fuelConsumption"]);
            for (int i = 1; i <= car.Crashes.Length; ++i)
            {
                richTextBox1.Text += car[i].ToString() + " ";
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

        public List<Car> cars = new List<Car>(); 

        private void buttonChooseFoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                textBoxFoto.Text = openFileDialog1.FileName;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBrand.Text == "" || textBoxPrice.Text == "" || textBoxProductionYear.Text == "" || textBoxFoto.Text == "")
            {
                MessageBox.Show("Введите данные!");
                return;
            }
            foreach (var ch in textBoxPrice.Text)
            {
                if (!Char.IsDigit(ch))
                {
                    MessageBox.Show("Цена может содержать только цифры!");
                    return;
                }
            }
            foreach (var ch in textBoxProductionYear.Text)
            {
                if (!Char.IsDigit(ch))
                {
                    MessageBox.Show("Год выпуска может содержать только цифры!");
                    return;
                }
            }
            Car car = new Car(
                textBoxBrand.Text, Convert.ToInt32(textBoxPrice.Text),
                Convert.ToInt32(textBoxProductionYear.Text), textBoxFoto.Text);
            if (!car.Correct())
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }
            cars.Add(car);
            listBox1.Items.Add(car.CarText());
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            textBoxSelectedBrand.Text = cars[i].Brand;
            textBoxSelectedPrice.Text = cars[i].Price.ToString();
            textBoxSelectedYear.Text = cars[i].ProductionYear.ToString();
            cars[i].ShowFoto(pictureBox1);
        }

        private void TextBoxBrand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

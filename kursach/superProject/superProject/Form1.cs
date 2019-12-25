using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Transport> transportList = new List<Transport>();

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButtonCar.Checked = true;
            labelAdditionalInput.Text = "Тип кузова";
        }

        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked)
            {
                labelAdditionalInput.Text = "Тип кузова";
            }
        }

        private void radioButtonLorry_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLorry.Checked)
            {
                labelAdditionalInput.Text = "Длина прицепа";
            }
        }

        private void buttonImageInput_Click(object sender, EventArgs e)
        {
            if (openFileDialogAddImage.ShowDialog() != DialogResult.Cancel)
            {
                textBoxImagePath.Text = openFileDialogAddImage.FileName;
            }
        }

        private void buttonAddTransport_Click(object sender, EventArgs e)
        {
            if (textBoxImagePath.Text == "")
            {
                MessageBox.Show("Данные некорректные!");
                return;
            }
            Brand brand = new Brand(textBoxBrandNameInput.Text, textBoxBrandCountryInput.Text, textBoxBrandYearInput.Text);
            MainSpecs mainSpecs = new MainSpecs(textBoxWeightInput.Text, textBoxColorInput.Text, textBoxPriceInput.Text, textBoxYearOfBuildInput.Text);
            Image image = Image.FromFile(textBoxImagePath.Text);
            if (radioButtonCar.Checked)
            {
                Car car = new Car(brand, mainSpecs, image, textBoxAdditionalInput.Text);
                if (!car.Correct())
                {
                    MessageBox.Show("Данные некорректные!");
                    return;
                }
                listBoxOfTransport.Items.Add(car.ToString());
                transportList.Add(car);
            }
            if (radioButtonLorry.Checked)
            {
                Lorry lorry = new Lorry(brand, mainSpecs, image, textBoxAdditionalInput.Text);
                if (!lorry.Correct())
                {
                    MessageBox.Show("Данные некорректные!");
                    return;
                }
                listBoxOfTransport.Items.Add(lorry.ToString());
                transportList.Add(lorry);
            }
        }

        private void listBoxOfTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxOfTransport.SelectedIndex;
            pictureBoxTransportImage.Image = transportList[i].Image;
            if (transportList[i].GetType().Name == "Car")
            {
                textBoxTransportTypeOut.Text = "Легковая";
            }
        }
    }
}

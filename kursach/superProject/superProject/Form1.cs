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
        // конструктор формочки
        public Form1()
        {
            InitializeComponent();
        }

        // список для хранения объектов типа Transoprt
        List<Transport> transportList = new List<Transport>();

        // метод, который вызывается при запускается формочки
        private void Form1_Load(object sender, EventArgs e)
        {
            // при запуске поумолчанию выбран легковой автомобиль
            radioButtonCar.Checked = true;
            labelAdditionalInput.Text = "Тип кузова";
        }

        // выбор легкового
        private void radioButtonCar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCar.Checked)
            {
                labelAdditionalInput.Text = "Тип кузова";
            }
        }

        // выбор грузового
        private void radioButtonLorry_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonLorry.Checked)
            {
                labelAdditionalInput.Text = "Длина прицепа";
            }
        }

        // добавление картинки
        private void buttonImageInput_Click(object sender, EventArgs e)
        {
            if (openFileDialogAddImage.ShowDialog() != DialogResult.Cancel)
            {
                textBoxImagePath.Text = openFileDialogAddImage.FileName;
            }
        }

        // добавление транспорта
        private void buttonAddTransport_Click(object sender, EventArgs e)
        {
            // проверяем, что картинка выбрана
            if (textBoxImagePath.Text == "")
            {
                MessageBox.Show("Данные некорректные!");
                return;
            }
            // читаем из текстбоксов информацию о марке и записываем в объект типа Brand
            Brand brand = new Brand(textBoxBrandNameInput.Text, textBoxBrandCountryInput.Text, textBoxBrandYearInput.Text);
            // читаем из текстбоксов информацию об основных характеристиках и записываем в объект типа MainSpecs
            MainSpecs mainSpecs = new MainSpecs(textBoxWeightInput.Text, textBoxColorInput.Text, textBoxPriceInput.Text, textBoxYearOfBuildInput.Text);
            // читаем из текстбокса путь к картинке и записываем в объект типа Image
            Image image = Image.FromFile(textBoxImagePath.Text);
            // если выбрана легковая
            if (radioButtonCar.Checked)
            {
                // создаём объект типа Car
                Car car = new Car(brand, mainSpecs, image, textBoxAdditionalInput.Text);
                // проверка на корректность введённых данных
                if (!car.Correct())
                {
                    MessageBox.Show("Данные некорректные!");
                    return;
                }
                // добавляем краткое текстовое представление объекта car в listBoxOfTransport
                listBoxOfTransport.Items.Add(car.ToString());
                // добавляем объект car в transportList
                transportList.Add(car);
            }
            // если выбрана грузовая
            if (radioButtonLorry.Checked)
            {
                // создаём объект типа Lorry
                Lorry lorry = new Lorry(brand, mainSpecs, image, textBoxAdditionalInput.Text);
                // проверка на корректность введённых данных
                if (!lorry.Correct())
                {
                    MessageBox.Show("Данные некорректные!");
                    return;
                }
                // добавляем краткое текстовое представление объекта car в listBoxOfTransport
                listBoxOfTransport.Items.Add(lorry.ToString());
                // добавляем объект car в transportList
                transportList.Add(lorry);
            }
        }

        // вывод выбранного объекта
        private void listBoxOfTransport_SelectedIndexChanged(object sender, EventArgs e)
        {
            // узнаём номер объекта
            int i = listBoxOfTransport.SelectedIndex;
            // если он типа Car
            if (transportList[i].GetType().Name == "Car")
            {
                textBoxTransportTypeOut.Text = "Легковая";
                labelAdditionalOut.Text = "Тип кузова";
                // преобразовали элемент коллекции transportList к типу Car(коллекция из типа Transport)
                textBoxAdditionalOut.Text = ((Car)(transportList[i])).BodyType;

            }
            // если он типа Lorry
            if (transportList[i].GetType().Name == "Lorry")
            {
                textBoxTransportTypeOut.Text = "Грузовая";
                labelAdditionalOut.Text = "Длина прицепа";
                // преобразовали элемент коллекции transportList к типу Lorry(коллекция из типа Transport)
                textBoxAdditionalOut.Text = ((Lorry)(transportList[i])).TruckLength;
            }
            // пихаем картинку в бокс
            pictureBoxTransportImage.Image = transportList[i].Image;
            // подгоняем размеры картинки
            pictureBoxTransportImage.SizeMode = PictureBoxSizeMode.Zoom;
            // заполняем остальные поля вывода
            textBoxBrandOut.Text = transportList[i].Brand.Name;
            textBoxWeightOutput.Text = transportList[i].MainSpecs.Weigth;
            textBoxColorOut.Text = transportList[i].MainSpecs.Color;
            textBoxPriceOut.Text = transportList[i].MainSpecs.Price;
            textBoxYearOfBuildOut.Text = transportList[i].MainSpecs.YearOfBuild;
        }
    }
}

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
        // коллекция(список) для хранения объектов(машин)
        List<Car> Cars = new List<Car>();

        private void Form1_Load(object sender, EventArgs e)
        {
            Cars.Add(new Car("audi", 100000));
            // связывание данных из коллекции с элементами отображения(listbox и textbox'ы)
            listBox1.DataSource = Cars;
            listBox1.DisplayMember = "Brand";
            textBoxSelectedBrand.DataBindings.Add("Text", Cars, "Brand");
            textBoxSelectedPrice.DataBindings.Add("Text", Cars, "Price");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBrand.Text == "" || textBoxPrice.Text == "")
            {
                MessageBox.Show("Введите данные!");
                return;
            }
            foreach (var ch in textBoxPrice.Text)
            {
                if (!Char.IsDigit(ch))
                {
                    MessageBox.Show("Некорректная цена!");
                    return;
                }
            }
            // создание объекта и его инициализация
            Car car = new Car(textBoxBrand.Text, Convert.ToInt32(textBoxPrice.Text));
            if (!car.Correct())
            {
                MessageBox.Show("Некорректные данные!");
                return;
            }
            // добавление объекта(машины) в коллекцию
            Cars.Add(car);
            // пересвязывание
            listBox1.DataSource = null;
            listBox1.DataSource = Cars;
            listBox1.DisplayMember = "Brand";
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

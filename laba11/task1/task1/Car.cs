﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace task1
{
    public class Car
    {
        // Поля
        private string brand = "";
        private int productionYear = -1;
        private int price = -1;
        private Image foto = null;
        // Свойства
        public string Brand
        {
            get => brand;
            set
            {
                if (value == "")
                {
                    return;
                }
                foreach (var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        return;
                    }
                }
                if (Char.IsLower(value[0]))
                {
                    char ch = value[0];
                    value = value.Remove(0, 1);
                    ch = Char.ToUpper(ch);
                    value = value.Insert(0, ch.ToString());

                }
                brand = value;
            }
        }
        public int Price
        {
            get => price;
            set
            {
                if (value < 0)
                {
                    return;
                }
                price = value;
            }
        }
        public int ProductionYear
        { 
            get => productionYear;
            set
            {
                if (value > 0)
                {
                    productionYear = value;
                }
            }
        }
        // Конструкторы
        private void initializeComponent(string brand, int price, int productionYear)
        {
            this.Brand = brand;
            this.Price = price;
            this.ProductionYear = productionYear;
        }
        public Car()
        { }
        public Car(string brand, int price, int productionYear)
        {
            initializeComponent(brand, price, productionYear);
        }
        public Car(string brand, int price, int productionYear, string fileFoto)
        {
            initializeComponent(brand, price, productionYear);
            this.foto = Image.FromFile(fileFoto);
        }
        // Другие методы
        public bool Correct()
        {
            if (Price < 0 || Brand == "" || productionYear < 0 || foto == null)
            {
                return false;
            }
            return true;
        }
        public string CarText()
        {
            return String.Format("Марка: {0}; Цена: {1}; Год выпуска: {2}\n", Brand, Price, ProductionYear);
        }
        public void CarText(TextBox box)
        {
            box.Text = CarText();
        }
        public string Age()
        {
            if (productionYear > 2000)
            {
                return "New";
            }
            {
                return "Old";
            }
        }
        // Вывод фото
        public void ShowFoto(PictureBox box)
        {
            box.Image = this.foto;
            box.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        public void ShowFoto(Form box)
        {
            box.BackgroundImage = this.foto;
        }
    }
}

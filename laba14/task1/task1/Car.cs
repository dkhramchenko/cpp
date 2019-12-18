using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace task1
{
    public class Car
    {
        // Поля
        private string brand = "";
        private int price = -1;
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
        public int Weigth { get; set; }
        public int TankCapacity { get; set; }
        public int FuelConsumption { get; set; }
        public int[] Crashes { get; set; }
        // Конструкторы
        public Car(string brand, int price, int weight, int tankCapacity, int fuelConsumption)
        {
            Brand = brand;
            Price = price;
            Weigth = weight;
            TankCapacity = tankCapacity;
            FuelConsumption = fuelConsumption;
        }
        public Car() { }
        // Индексаторы
        public int this[int year]
        {
            get
            {
                return Crashes[year - 1];
            }
        }
        public string this[string property]
        {
            get
            {
                switch (property)
                {
                    case "brand": return Brand;
                    case "price": return Price.ToString();
                    case "weight": return Weigth.ToString();
                    case "tankCapacity": return TankCapacity.ToString();
                    case "fuelConsumption": return FuelConsumption.ToString();
                    default: return null;
                }
            }
        }
        // Другие методы
        public string CarText()
        {
            return String.Format("Марка: {0}; Цена: {1}$; Масса: {2}кг; Бак: {3}л; Расход топлива: {4}л/100км;", 
                Brand, Price, Weigth, TankCapacity, FuelConsumption);
        }
    }
}

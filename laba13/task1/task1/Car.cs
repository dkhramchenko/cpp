using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace task1
{
    public class Car : IFuelConsumer
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
        // Другие методы
        public virtual string CarText()
        {
            return String.Format("Марка: {0}; Цена: {1}$; Масса: {2}кг; Бак: {3}л; Расход топлива: {4}л/100км;", 
                Brand, Price, Weigth, TankCapacity, FuelConsumption);
        }
        public double TankRange()
        {
            return TankCapacity / FuelConsumption * 100;
        }
    }

    public class Lorry : Car, ICargoCarrier
    {
        public int TruckLength { get; set; }

        public Lorry(string brand, int price, int weight, int tankCapacity, int fuelConsumption,
            int truckLength) :base(brand, price, weight, tankCapacity, fuelConsumption)
        {
            TruckLength = truckLength;
        }

        public override string CarText()
        {
            return base.CarText() + String.Format(" Длина прицепа: {0}м;", TruckLength);
        }

        public double MaxCargoLength()
        {
            return 0.8 * TruckLength;
        }

        public double MaxCargoWeight()
        {
            return 0.8 * Weigth;
        }
    }
}

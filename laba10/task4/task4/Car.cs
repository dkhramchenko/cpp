using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace task4
{
    public class Car
    {
        // Поля(здесь хранятся данные объекта)
        public static readonly Color color;
        public static readonly string salonMaterial;
        private string brand = "";
        private int price = -1;
        // Свойства(позволяют записывать и читать данные полей)
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
        // Конструкторы(позволяют инициализировать поля объекта значениями)
        public Car()
        {

        }
        public Car(string brand, int price)
        {
            this.Brand = brand;
            this.Price = price;
        }
        static Car()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Wednesday || now.DayOfWeek == DayOfWeek.Sunday)
            {
                color = Color.Pink;
                salonMaterial = "Leather";
            }
            else
            {
                color = Color.White;
                salonMaterial = "Cloth";
            }
        }
        // разные методы
        // проверка корректности объекта
        public bool Correct()
        {
            if (Price < 0 || Brand == "")
            {
                return false;
            }
            return true;
        }
    }
}

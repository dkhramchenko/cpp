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
        public int[] crashes;
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
        // Конструкторы
        public Car(int price, string brand = "audi")
        {
            this.Brand = brand;
            this.Price = price;
        }
        // Другие методы
        public bool Correct()
        {
            if (Price < 0 || Brand == "")
            {
                return false;
            }
            return true;
        }
        public string CarText()
        {
            return String.Format("Марка: {0}; Цена: {1};\n", Brand, Price);
        }
        public void CarText(PictureBox box)
        {
            box.Image = Image.FromFile(@"C:audi-a7-ambassador-peredovogo-dizajna.jpg");
            box.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        // Метод для изучения передачи параметров
        public double AverageCrashes(ref int test, int[] crashes)
        {
            this.crashes = crashes;
            test = 10;
            return crashes.Average();
        }
        public void AverageCrashes(int[] crashes, out double res, out string resume)
        {
            res = crashes.Average();
            if (res > 10)
            {
                resume = "Битая";
            }
            else
            {
                resume = "Небитая";
            }
        }
    }
}

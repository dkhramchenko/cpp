using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Car
    {
        private string brand = "";
        private int price = -1;
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
        public bool Correct()
        {
            if (Price < 0 || Brand == "")
            {
                return false;
            }
            return true;
        }
        public Car(string brand, int price)
        {
            this.Brand = brand;
            this.Price = price;
        }
    }
}

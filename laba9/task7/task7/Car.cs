using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public class Car
    {
        private string brand;
        public string Color;
        private int price;
        public int Weight;

        public int Price { get => price; set => price = value; }
        public string Brand 
        {
            get => brand;
            set 
            { 
                if (Char.IsLower(value[0]))
                {
                    string s = value;
                    s[0] = Char.ToUpper(s[0]);
                    brand = s;
                }
            } 
        }
    }
    public class Passenger : Car
    {
    }
}

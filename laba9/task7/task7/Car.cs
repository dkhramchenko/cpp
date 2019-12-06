using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7
{
    public class Car
    {
        #region Поля класса
        private string brand;
        public string Color;
        private int price;
        public int Weight;
        #endregion

        public int Price { get => price; set => price = value; }
        public string Brand 
        {
            get => brand;
            set 
            { 
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
    }
    public class Passenger : Car
    {
    }
}

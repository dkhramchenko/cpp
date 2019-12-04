using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task6
{
    public class Car
    {
        public string Brand;
        public string Color;
        public int Weight;
        private int price;

        public int ProductionDate
        {
            get => default;
            set
            {
            }
        }

        public int Price { get => price; set => price = value; }
    }
}
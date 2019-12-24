using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    class MainSpecs : ICanBeChekcedForCorrect
    {
        #region fields
        private int weigth = -1;
        private string color = "";
        private int price = -1;
        private int yearOfBuild = -1;
        #endregion fields

        #region properties
        public string Weigth
        {
            get
            {
                return weigth.ToString();
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        return;
                    }
                }
                int weigth = Convert.ToInt32(value);
                if (weigth <= 0)
                {
                    return;
                }
                this.weigth = weigth;
            }
        }
        public string Color 
        {
            get
            {
                return color;
            }
            set
            {
                foreach(var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        return;
                    }
                }
                color = value;
            }
        }
        public string Price 
        { 
            get
            {
                return price.ToString();
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        return;
                    }
                }
                int price = Convert.ToInt32(value);
                if (price <= 0)
                {
                    return;
                }
                this.price = price;
            }
        }
        public string YearOfBuild 
        { 
            get
            {
                return yearOfBuild.ToString();
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        return;
                    }
                }
                int yearOfBuild = Convert.ToInt32(value);
                if (yearOfBuild > 0)
                {
                    this.yearOfBuild = yearOfBuild;
                }
            }
        }
        #endregion properties

        #region constructors
        public MainSpecs(string weight = "-1", string color = "",
            string price = "-1", string yearOfBuild = "")
        {
            Weigth = weight;
            Color = color;
            Price = price;
            YearOfBuild = yearOfBuild;
        }
        #endregion constructors

        #region other methods
        public override string ToString()
        {
            return String.Format("Масса: {0}; Цвет: {1}; Цена: {2}; Год выпуска: {3}",
                Weigth, Color, Price, YearOfBuild);
        }
        public bool Correct()
        {
            if (Weigth == "-1" || Color == "" || Price == "-1")
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}

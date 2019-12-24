using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    // класс для информации об основных харатекристиках транспорта, реализует интерфейс проверки корректности
    class MainSpecs : ICanBeChekcedForCorrect
    {
        #region fields
        private int weigth = -1; // вес
        private string color = ""; // цвет
        private int price = -1; // цена
        private int yearOfBuild = -1; // год выпуска
        #endregion fields

        #region properties
        // свойство для чтения и записи из/в поле weight
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
                if (weigth > 0)
                {
                    this.weigth = weigth;
                }
            }
        }
        // свойство для чтения и записи из/в поле color
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
        // свойство для чтения и записи из/в поле price
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
                if (price > 0)
                {
                    this.price = price;
                }
            }
        }
        // свойство для чтения и записи из/в поле yearOfBuild
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
        // сразу пять перегруженных конструкторов
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
        // переопределённый метод для текстового представления объекта
        public override string ToString()
        {
            return String.Format("Масса: {0}; Цвет: {1}; Цена: {2}; Год выпуска: {3}",
                Weigth, Color, Price, YearOfBuild);
        }
        // реализация интерфейса определения корректности объекта
        public bool Correct()
        {
            if (Weigth != "-1" && Color != "" && Price != "-1")
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

using System;

namespace superProject
{
    // класс для информации об основных харатекристиках транспорта, реализует интерфейс проверки корректности
    class MainSpecs : ICanBeChekcedForCorrect
    {
        #region fields
        private int weigth; // вес
        private string color; // цвет
        private int price; // цена
        private int yearOfBuild; // год выпуска
        #endregion fields

        #region properties
        // свойство для чтения и записи из/в поле weight
        public string Weigth
        {
            get
            {
                return this.weigth.ToString();
            }
            set
            {
                if (value == "")
                {
                    this.weigth = -1;
                    return;
                }
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        this.weigth = -1;
                        return;
                    }
                }
                int weigth = Convert.ToInt32(value);
                if (weigth > 0)
                {
                    this.weigth = weigth;
                    return;
                }
                this.weigth = -1;
            }
        }
        // свойство для чтения и записи из/в поле color
        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                foreach(var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        this.color = "";
                        return;
                    }
                }
                this.color = value;
            }
        }
        // свойство для чтения и записи из/в поле price
        public string Price 
        { 
            get
            {
                return this.price.ToString();
            }
            set
            {
                if (value == "")
                {
                    this.price = -1;
                    return;
                }
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        this.price = -1;
                        return;
                    }
                }
                int price = Convert.ToInt32(value);
                if (price > 0)
                {
                    this.price = price;
                    return;
                }
                this.price = -1;
            }
        }
        // свойство для чтения и записи из/в поле yearOfBuild
        public string YearOfBuild 
        { 
            get
            {
                return this.yearOfBuild.ToString();
            }
            set
            {
                if (value == "")
                {
                    this.yearOfBuild = -1;
                    return;
                }
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        this.yearOfBuild = -1;
                        return;
                    }
                }
                int yearOfBuild = Convert.ToInt32(value);
                if (yearOfBuild > 0)
                {
                    this.yearOfBuild = yearOfBuild;
                    return;
                }
                this.yearOfBuild = -1;
            }
        }
        #endregion properties

        #region constructors
        // конструктор без параметров
        public MainSpecs()
        {
            this.Weigth = "-1";
            this.Color = "";
            this.Price = "-1";
            this.YearOfBuild = "-1";
        }
        // перегруженный конструктор
        public MainSpecs(string weight, string color, string price, string yearOfBuild)
        {
            this.Weigth = weight;
            this.Color = color;
            this.Price = price;
            this.YearOfBuild = yearOfBuild;
        }
        #endregion constructors

        #region other methods
        // переопределённый метод для текстового представления объекта
        public override string ToString()
        {
            return String.Format("Масса: {0}; Цвет: {1}; Цена: {2}; Год выпуска: {3}",
                this.Weigth, this.Color, this.Price, this.YearOfBuild);
        }
        // реализация интерфейса определения корректности объекта
        public bool Correct()
        {
            if (this.Weigth != "-1" && this.Color != "" && this.Price != "-1")
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

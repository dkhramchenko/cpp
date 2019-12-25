using System;

namespace superProject
{
    // класс для информации о марке, реализует интерфейс проверки корректности
    class Brand : ICanBeChekcedForCorrect
    {
        #region fields
        private string name; // название марки
        private string countryOfOrigin; // страна происхождения
        private int yearOfBirth; // год создания
        #endregion fields

        #region properties
        // свойство для чтения и записи из/в поле name
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        this.name = "";
                        return;
                    }
                }
                this.name = value;
            }
        }
        // свойство для чтения и записи из/в поле countryOfOrigin
        public string CountryOfOrigin
        {
            get
            {
                return this.countryOfOrigin;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        this.countryOfOrigin = "";
                        return;
                    }
                }
                this.countryOfOrigin = value;
            }
        }
        // свойство для чтения и записи из/в поле yearOfBirth
        public string YearOfBirth
        {
            get
            {
                return this.yearOfBirth.ToString();
            }
            set
            {
                if (value == "")
                {
                    this.yearOfBirth = -1;
                    return;
                }
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        this.yearOfBirth = -1;
                        return;
                    }
                }
                int yearOfBirth = Convert.ToInt32(value);
                if (yearOfBirth > 0)
                {
                    this.yearOfBirth = yearOfBirth;
                    return;
                }
                this.yearOfBirth = -1;
            }
        }
        #endregion properties

        #region constructors
        // конструктор без параметров
        public Brand()
        {
            this.Name = "";
            this.CountryOfOrigin = "";
            this.YearOfBirth = "-1";
        }
        // перегруженный конструктор
        public Brand(string name, string countryOfOrigin, string yearOfBirth)
        {
            this.Name = name;
            this.CountryOfOrigin = countryOfOrigin;
            this.YearOfBirth = yearOfBirth;
        }
        #endregion constructors

        #region other methods
        // переопределённый метод для текстового представления объекта
        public override string ToString()
        {
            return String.Format("Название: {0}; Страна: {1}; Год создания: {2}",
                this.Name, this.CountryOfOrigin, this.YearOfBirth);
        }
        // реализация интерфейса определения корректности объекта
        public bool Correct()
        {
            if (this.Name != "" && this.CountryOfOrigin != "" && this.YearOfBirth != "-1")
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}
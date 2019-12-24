using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    // класс для информации о марке, реализует интерфейс проверки корректности
    class Brand : ICanBeChekcedForCorrect
    {
        #region fields
        private string name = ""; // название марки
        private string countryOfOrigin = ""; // страна происхождения
        private int yearOfBirth = -1; // год создания
        #endregion fields

        #region properties
        // свойство для чтения и записи из/в поле name
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        return;
                    }
                }
                name = value;
            }
        }
        // свойство для чтения и записи из/в поле countryOfOrigin
        public string CountryOfOrigin
        {
            get
            {
                return countryOfOrigin;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        return;
                    }
                }
                countryOfOrigin = value;
            }
        }
        // свойство для чтения и записи из/в поле yearOfBirth
        public string YearOfBirth
        {
            get
            {
                return yearOfBirth.ToString();
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
                int yearOfBirth = Convert.ToInt32(value);
                if (yearOfBirth > 0)
                {
                    this.yearOfBirth = yearOfBirth;
                }
            }
        }
        #endregion properties

        #region constructors
        // сразу четыре перегруженных конструктора
        public Brand(string name = "", string countryOfOrigin = "", string yearOfBirth = "-1")
        {
            Name = name;
            CountryOfOrigin = countryOfOrigin;
            YearOfBirth = yearOfBirth;
        }
        #endregion constructors

        #region other methods
        // переопределённый метод для текстового представления объекта
        public override string ToString()
        {
            return String.Format("Название: {0}; Страна: {1}; Год создания: {2}",
                Name, CountryOfOrigin, YearOfBirth);
        }
        // реализация интерфейса определения корректности объекта
        public bool Correct()
        {
            if (Name != "" && CountryOfOrigin != "" && YearOfBirth != "-1")
            {
                return true;
            }
            return false;
        }
        #endregion
    }
}

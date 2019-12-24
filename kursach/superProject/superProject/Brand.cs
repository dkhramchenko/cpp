using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    class Brand : ICanBeChekcedForCorrect
    {
        #region fields
        private string name = "";
        private string countryOfOrigin = "";
        private int yearOfBirth = -1;
        #endregion fields

        #region properties
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
                if (yearOfBirth <= 0)
                {
                    return;
                }
                this.yearOfBirth = yearOfBirth;
            }
        }
        #endregion properties

        #region constructors
        public Brand(string name = "", string countryOfOrigin = "", string yearOfBirth = "-1")
        {
            Name = name;
            CountryOfOrigin = countryOfOrigin;
            YearOfBirth = yearOfBirth;
        }
        #endregion constructors

        #region other methods
        public override string ToString()
        {
            return String.Format("Название: {0}; Страна: {1}; Год создания: {2}",
                Name, CountryOfOrigin, YearOfBirth);
        }
        public bool Correct()
        {
            if (Name == "" || CountryOfOrigin == "" || YearOfBirth == "-1")
            {
                return false;
            }
            return true;
        }
        #endregion
    }
}

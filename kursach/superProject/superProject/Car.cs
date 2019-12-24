using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    class Car : Transport, ICanBeChekcedForCorrect
    {
        #region fields
        private string bodyType = "";
        #endregion fields

        #region properties
        public string BodyType 
        { 
            get
            {
                return bodyType;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        return;
                    }
                    bodyType = value;
                }
            }
        }
        #endregion properties

        #region constructors
        public Car(Brand brand, MainSpecs mainSpecs, string bodyType = "sedan") : base(brand, mainSpecs)
        {
            BodyType = bodyType;
        }
        #endregion constructors

        #region other methods
        public override bool Correct()
        {
            if (base.Correct() && bodyType != "")
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("Легковой Автомобиль\n" + 
                "Марка:\n{0}\n" +
                "Основные характеристики:\n{1}\n" +
                "Тип кузова: {2}\n" ,
                Brand, MainSpecs, BodyType
                );
        }
        #endregion other methods
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace superProject
{
    // класс легкового автомобиля, наследник транспорта, реализует интерфейс проверки корректности
    class Car : Transport, ICanBeChekcedForCorrect
    {
        #region fields
        private string bodyType = ""; // тип кузова
        #endregion fields

        #region properties
        // свойство для чтения и записи из/в поле bodyType
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
                }
                bodyType = value;
            }
        }
        // индексатор для доступа свойству по имени
        public string this[string propertyName]
        {
            get
            {
                if (propertyName == "Brand")
                {
                    return Brand.ToString();
                }
                if (propertyName == "MainSpecs")
                {
                    return MainSpecs.ToString();
                }
                if (propertyName == "BodyType")
                {
                    return BodyType;
                }
                return null;
            }
        }
        #endregion properties

        #region constructors
        // сразу два перегруженных конструктора, вызывающих конструктор базового класса
        public Car(Brand brand, MainSpecs mainSpecs, Image image, string bodyType = "sedan") : base(brand, mainSpecs, image)
        {
            BodyType = bodyType;
        }
        #endregion constructors

        #region other methods
        // реализация интерфейса определения корректности объекта
        public override bool Correct()
        {
            if (base.Correct() && bodyType != "")
            {
                return true;
            }
            return false;
        }
        // метод для текстового представления объекта
        public override string ToString(string mode = "short")
        {
            if (mode == "short")
            {
                return String.Format("{0} Тип кузова: {1}", base.ToString(), BodyType);
            }
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

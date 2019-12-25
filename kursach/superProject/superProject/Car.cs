using System;
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
                return this.bodyType;
            }
            set
            {
                foreach (var ch in value)
                {
                    if (!Char.IsLetter(ch))
                    {
                        this.bodyType = "";
                        return;
                    }
                }
                bodyType = value;
            }
        }
        // индексатор для получения строкового представляния свойств по их имененам
        public string this[string propertyName]
        {
            get
            {
                if (propertyName == "Brand")
                {
                    return this.Brand.ToString();
                }
                if (propertyName == "MainSpecs")
                {
                    return this.MainSpecs.ToString();
                }
                if (propertyName == "Image")
                {
                    return this.Image.ToString();
                }
                if (propertyName == "BodyType")
                {
                    return this.BodyType;
                }
                return null;
            }
        }
        #endregion properties

        #region constructors
        // конструктор без параметров. Вызывает конструктор без параметров базового класса Transport
        public Car() : base()
        {
            this.BodyType = "";
        }
        // перегруженный конструктор. Вызывает перегруженный конструктор базового класса Transport
        public Car(Brand brand, MainSpecs mainSpecs, Image image, string bodyType) : base(brand, mainSpecs, image)
        {
            this.BodyType = bodyType;
        }
        #endregion constructors

        #region other methods
        // реализация интерфейса определения корректности объекта
        public override bool Correct()
        {
            if (base.Correct() && this.BodyType != "")
            {
                return true;
            }
            return false;
        }
        // переопределённый метод для текстового представления объекта
        public override string ToString(string mode = "short")
        {
            if (mode == "short")
            {
                return String.Format("{0} Тип кузова: {1}", base.ToString(), this.BodyType);
            }
            return String.Format("Легковой Автомобиль\n" + 
                "Марка:\n{0}\n" +
                "Основные характеристики:\n{1}\n" +
                "Тип кузова: {2}\n" ,
                this.Brand, this.MainSpecs, this.BodyType
                );
        }
        #endregion other methods
    }
}

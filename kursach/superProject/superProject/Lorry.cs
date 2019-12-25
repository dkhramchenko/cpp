using System;
using System.Drawing;

namespace superProject
{
    // класс грузовика, наследник транспорта, реализует интерфейс проверки корректности и интерфейс грузоперевозок
    class Lorry : Transport, ICanBeChekcedForCorrect, ICargoCarrier
    {
        #region fields
        private int truckLength; // длина прицепа
        #endregion fields

        #region properties
        // свойство для чтения и записи из/в поле truckLength
        public string TruckLength
        { 
            get
            {
                return this.truckLength.ToString(); 
            }
            set
            {
                if (value == "")
                {
                    this.truckLength = -1;
                    return;
                }
                foreach (var ch in value)
                {
                    if (!Char.IsDigit(ch))
                    {
                        this.truckLength = -1;
                        return;
                    }
                }
                int truckLength = Convert.ToInt32(value);
                if (truckLength > 0)
                {
                    this.truckLength = truckLength;
                    return;
                }
                this.truckLength = -1;
            }
        }
        #endregion properties

        #region constructors
        // конструктор без параметров. Вызывает конструктор без параметров базового класса Transport
        public Lorry() : base()
        {
            this.TruckLength = "-1";
        }
        // перегруженный конструктор. Вызывает перегруженный конструктор базового класса Transport
        public Lorry(Brand brand, MainSpecs mainSpecs, Image image, string trucklength = "-1") : base(brand, mainSpecs, image)
        {
            this.TruckLength = trucklength;
        }
        #endregion

        #region other methhods
        // реализация интерфейса определения корректности объекта
        public override bool Correct()
        {
            if (base.Correct() && this.TruckLength != "-1")
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
                return String.Format("{0} Длина прицепа: {1}", base.ToString(), this.TruckLength);
            }
            return String.Format("Грузовой автомобиль\n" +
                "Марка:\n{0}\n" +
                "Основные характеристики:\n{1}\n" +
                "Длина прицепа: {2}\n",
                this.Brand, this.MainSpecs, this.TruckLength
                );
        }
        // реализация интерфейса грузоперевозок
        public double MaxCargoWeight()
        {
            return 2 * Convert.ToInt32(this.MainSpecs.Weigth);
        }
        // реализация интерфейса грузоперевозок
        public double MaxCargoLength()
        {
            return 0.8 * Convert.ToDouble(this.TruckLength);
        }
        #endregion
    }
}

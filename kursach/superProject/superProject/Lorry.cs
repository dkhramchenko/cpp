using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace superProject
{
    // класс грузовика, наследник транспорта, реализует интерфейс проверки корректности и интерфейс грузоперевозок
    class Lorry : Transport, ICanBeChekcedForCorrect, ICargoCarrier
    {
        #region fields
        private int truckLength = -1; // длина прицепа
        #endregion fields

        #region properties
        // свойство для чтения и записи из/в поле truckLength
        public string TruckLength
        { 
            get
            {
                return truckLength.ToString(); 
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
                int truckLength = Convert.ToInt32(value);
                if (truckLength > 0)
                {
                    this.truckLength = truckLength;
                }
            }
        }
        #endregion properties

        #region constructors
        // сразу два перегруженных конструктора, вызывающих конструктор базового класса
        public Lorry(Brand brand, MainSpecs mainSpecs, Image image, string trucklength = "-1") : base(brand, mainSpecs, image)
        {
            TruckLength = trucklength;
        }
        #endregion

        #region other methhods
        // реализация интерфейса определения корректности объекта
        public override bool Correct()
        {
            if (base.Correct() && TruckLength != "-1")
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
                return String.Format("{0} Длина прицепа: {1}", base.ToString(), TruckLength);
            }
            return String.Format("Грузовой автомобиль\n" +
                "Марка:\n{0}\n" +
                "Основные характеристики:\n{1}\n" +
                "Длина прицепа: {2}\n",
                Brand, MainSpecs, TruckLength
                );
        }
        // реализация интерфейса грузоперевозок
        public double maxCargoWeight()
        {
            return 2 * Convert.ToInt32(MainSpecs.Weigth);
        }
        // реализация интерфейса грузоперевозок
        public double maxCargoLength()
        {
            return 0.8 * truckLength;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    // абстрактный класс транспорта, реализует интерфейс проверки корректности
    abstract class Transport : ICanBeChekcedForCorrect
    {
        #region fields
        private Brand brand; // информация о марке
        private MainSpecs mainSpecs; // основные характеристики
        #endregion fields

        #region properties
        // свойство для чтения и записи из/в поле brand
        public Brand Brand
        {
            get
            {
                return brand;
            }
            set
            {
                if (value.Correct())
                {
                    brand = value;
                }
            }
        }
        // свойство для чтения и записи из/в поле mainSpecs
        public MainSpecs MainSpecs
        {
            get
            {
                return mainSpecs;
            }
            set
            {
                if (value.Correct())
                {
                    mainSpecs = value;
                }
            }
        }
        #endregion properties

        #region constructors
        // конструктор
        public Transport(Brand brand, MainSpecs mainSpecs)
        {
            Brand = brand;
            MainSpecs = mainSpecs;
        }
        #endregion constructors

        #region other methods
        // абстрактный метод для текстового представления объекта
        public abstract override string ToString();
        // реализация интерфейса определения корректности объекта
        public virtual bool Correct()
        {
            if (Brand.Correct() && MainSpecs.Correct())
            {
                return true;
            }
            return false;
        }
        #endregion other methods
    }
}

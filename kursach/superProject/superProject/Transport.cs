using System;
using System.Drawing;

namespace superProject
{
    // абстрактный класс транспорта, реализует интерфейс проверки корректности
    abstract class Transport : ICanBeChekcedForCorrect
    {
        #region properties
        // свойство для чтения и записи информации о марке
        public Brand Brand
        {
            get;
            set;
        }
        // свойство для чтения и записи информации об основных характеристиках
        public MainSpecs MainSpecs
        {
            get;
            set;
        }
        // свойство для чтения и записи картинки
        public Image Image
        {
            get;
            set;
        }
        #endregion properties

        #region constructors
        // конструктор без параметров
        public Transport()
        {
            this.Brand = new Brand();
            this.MainSpecs = new MainSpecs();
            this.Image = null;
        }
        // перегруженный конструктор
        public Transport(Brand brand, MainSpecs mainSpecs, Image image)
        {
            this.Brand = brand;
            this.MainSpecs = mainSpecs;
            this.Image = image;
        }
        #endregion constructors

        #region other methods
        // метод для текстового представления объекта
        public virtual string ToString(string mode = "short")
        {
            return String.Format("Марка: {0}; Цена: {1}; Цвет: {2};",
                this.Brand.Name, this.MainSpecs.Price, this.MainSpecs.Color);
        }
        // реализация интерфейса определения корректности объекта
        public virtual bool Correct()
        {
            if (this.Brand.Correct() && this.MainSpecs.Correct() && this.Image != null)
            {
                return true;
            }
            return false;
        }
        #endregion other methods
    }
}

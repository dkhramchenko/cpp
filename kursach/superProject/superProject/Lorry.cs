using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    class Lorry : Transport, ICanBeChekcedForCorrect, ICargoCarrier
    {
        #region fields
        private int truckLength = -1;
        #endregion fields

        #region properties
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
        public Lorry(Brand brand, MainSpecs mainSpecs, string trucklength = "-1") : base(brand, mainSpecs)
        {
            TruckLength = trucklength;
        }
        #endregion

        #region other methhods
        public override bool Correct()
        {
            if (base.Correct() && TruckLength != "-1")
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return String.Format("Грузовой автомобиль\n" +
                "Марка:\n{0}\n" +
                "Основные характеристики:\n{1}\n" +
                "Длина прицепа: {2}\n",
                Brand, MainSpecs, TruckLength
                );
        }
        public double maxCargoWeight()
        {
            return 2 * Convert.ToInt32(MainSpecs.Weigth);
        }
        public double maxCargoLength()
        {
            return 0.8 * truckLength;
        }
        #endregion
    }
}

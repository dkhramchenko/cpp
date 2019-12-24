using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    abstract class Transport : ICanBeChekcedForCorrect
    {
        #region fields
        private Brand brand;
        private MainSpecs mainSpecs;
        #endregion fields

        #region properties
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
        public Transport(Brand brand, MainSpecs mainSpecs)
        {
            Brand = brand;
            MainSpecs = mainSpecs;
        }
        #endregion constructors

        #region other methods
        public abstract override string ToString();
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

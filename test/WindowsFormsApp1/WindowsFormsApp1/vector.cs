using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Vector
    {
        public double[] data;
        public double Length()
        {
            double r = 0;
            for (int i = 0; i < data.Length; ++i)
            {
                r += data[i] * data[i];
            }
            return System.Math.Sqrt(r);
        }
        public double this[int i]
        {
            get
            {
                return data[i];
            }
            set
            {
                data[i] = value;
            }
        }
        string Text()
        {
            string r = "(";
            for (int i = 0; i < data.Length; ++i)
            {
                r += data[i].ToString() + ";";
            }
            r += ")";
            return r;
        }
    }
}

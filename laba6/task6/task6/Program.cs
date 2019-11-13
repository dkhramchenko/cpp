using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            task65();
            Console.ReadKey();
        }

        static void task61()
        {
            double[] a = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            double p = 3.5;
            double q = 7.5;
            int amount = 0;
            foreach (var el in a)
            {
                if (el < q && el > p)
                {
                    ++amount;
                }
            }
            Console.WriteLine(amount);
        }

        static void task62()
        {
            double[] a = new double[] { -1, -2, -3, -4, -5, 6, 7, 8 };
            double el = 0;
            int index = -1;
            for (int i = 0; i < 8; ++i)
            {
                if (a[i] < 0)
                {
                    el = a[i];
                    index = i;
                }
            }
            Console.WriteLine(el.ToString() + " " + index.ToString());
        }

        static void task63()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[size];
            for (int i = 0; i < size; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sum = 0;
            for (int i = 0; i < size; ++i)
            {
                if (a[i] < 0)
                {
                    break;
                }
                else
                {
                    sum += a[i] * a[i];
                }
            }
            Console.WriteLine(sum);
        }
        static void task64()
        {
            double[] a = new double[] { 1, 2, 3, 4, 10, 5, 6, 7, 8, 9 };
            double sum = 0;
            for (int i = 0; i < 10; ++i)
            {
                if (a[i] == a.Max())
                {
                    break;
                }
                else
                {
                    sum += a[i];
                }
            }
            Console.WriteLine(sum);
        }
        static void task65()
        {
            int size = Convert.ToInt32(Console.ReadLine());
            double[] a = new double[size];
            for (int i = 0; i < size; ++i)
            {
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            double sr = a.Average();
            for (int i = Array.IndexOf(a, a.Max()) + 1; i < size; ++i)
            {
                a[i] = sr;
            }
            for (int i = 0; i < size; ++i)
            {
                Console.Write(a[i].ToString() + " ");
            }
        }
    }
}

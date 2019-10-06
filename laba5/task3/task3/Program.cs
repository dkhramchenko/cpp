using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int x = r.Next(1, 7);
            Console.WriteLine("Бросание кубика: " + x);
            while (x != 6)
            {
                x = r.Next(1, 7);
                Console.WriteLine("Бросание кубика: " + x);
            }
            Console.ReadKey();
        }
    }
}

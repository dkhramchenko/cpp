using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks123
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Console.ReadKey();
        }
        static void Task1()
        {
            // Тип DateTime
            System.DateTime dat1 = new System.DateTime(2019, 09, 11, 10, 45, 22); // создание переменной с помощью конструктора класса DateTime
            System.DateTime dat2 = Convert.ToDateTime("07.03.2018 10:35:12"); // создание переменной с помощью конвертации строки
            Console.WriteLine("Прошло = {0} дней, часов, минут и секунд", dat1 - dat2);
        }
    }
}

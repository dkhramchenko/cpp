﻿using System;
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
            Task2();
            Console.ReadKey();
        }
        static void Task1()
        {
            // Тип DateTime
            System.DateTime dat1 = new System.DateTime(2019, 09, 11, 10, 45, 22); // создание переменной с помощью конструктора класса DateTime
            System.DateTime dat2 = Convert.ToDateTime("07.03.2018 10:35:12"); // создание переменной с помощью конвертации строки
            Console.WriteLine("Прошло = {0} дней, часов, минут и секунд", dat1 - dat2);
        }
        static void Task2()
        {
            // символ в виде шестнадцатиричного кода \xf \x74
            // обычный символ, имеющий графическое представление F
            // управляющая последовательность \n \b
            // символ в кодировке Unicode \uA81B
            char b = 'B', c = '\x63', d = '\u0032';
            Console.WriteLine("{0}{1}{2}", b, c, d);
            Console.WriteLine("{0}{1}{2}", char.ToLower(b), char.ToUpper(c), char.GetNumericValue(d));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }
        static void Task1()
        {
            Console.WriteLine("sdfdsfdsfdsfs"); // вывели текст при стандартных настройках
            Console.ForegroundColor = ConsoleColor.DarkRed; // сменили цвет текста на красный
            Console.WriteLine("sdasdasda");
            Console.BackgroundColor = ConsoleColor.DarkMagenta; // сменили цвет фона на розовый
            Console.WriteLine("sdasdas");
            Console.ResetColor(); // восстановили настройки поумолчанию
            Console.WriteLine("asdasdas");
            Console.ReadLine();
        }
    }
}

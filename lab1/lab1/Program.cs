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
            Task2();
            task3();
            task31();
            task32();
            Console.ReadLine();
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
        }
        static void Task2()
        {
            int i = 10, y = 20; // создание двух переменных типа int и их инициализация
            bool b = true; // создание переменной типа bool и её иницализация истиной
            int z = 10; // создание переменной типа int и её инициализация значением 10
            // bool b = false; нельзя создать переменную с имеменем, которое уже занято

            var name = "Введите имя"; // создание переменной name и инициализация значением, тип определяется автоматически
            var age = 19; // создание переменной age и инициализация значением, тип определяется автоматически
            var isStudent = true; // создание переменной isStudent и инициализация значением, тип определяется автоматически

            var nameType = name.GetType(); // создание переменной nameType и инициализация значением, тип определяется автоматически
            var ageType = age.GetType(); // создание переменной ageType и инициализация значением, тип определяется автоматически
            var isStudentType = isStudent.GetType(); // создание переменной isStudentType и инициализация значением, тип определяется автоматически

            Console.WriteLine("объект name имеет тип " + nameType.ToString()); // вывод типа переменной name на экран
            Console.WriteLine("объект age имеет тип " + ageType.ToString()); // вывод типа переменной age на экран
            Console.WriteLine("объект isStudent имеет тип " + isStudentType.ToString()); // вывод типа переменной isStudent на экран

            var x = 10;
            // int x = 10;
        }
        static void task3()
        {
            var x = "Выведение типа компилятором";
            var y = 78.9F;
            float f = 78.9F;
            var z = 78.9;
            double d = 78.9;
            var w = false;

            Console.WriteLine("тип текстовой строки = " + x.GetType());
            Console.WriteLine("тип вещественного числа с символом f или F =" + y.GetType());
            Console.WriteLine("тип вещественного числа с символом f или F =" + f.GetType());
            Console.WriteLine("тип вещественного числа без символа f или F =" + z.GetType());
            Console.WriteLine("тип вещественного числа без символа f или F =" + d.GetType());
            Console.WriteLine(w.GetType());
            y = 67;
            Console.WriteLine("переменная объявлена тип выведен и не может быть изменен" + y.GetType());
        }
        static void task31()
        {
            decimal x = 56.78M; // символ m или М добавляется к типу demical
            double y = 89.9;
            y += Convert.ToDouble(x);
            Console.WriteLine(y);
        }
        static void task32()
        {
            uint ui = 123U; // для явной спецификации типа используется символ U или u
            long l = 123L; // для явной спецификации типа используется символ L или l
            ulong ul = 123UL; // для явной спецификации типа используется символ UL или 
            ui += Convert.ToUInt32(l) + Convert.ToUInt32(ul); // преобразование типов
            Console.WriteLine(ui);
        }
    }
}

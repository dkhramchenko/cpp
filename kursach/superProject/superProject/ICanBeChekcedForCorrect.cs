using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    // интерфейс для реализации проверки корректности 
    interface ICanBeChekcedForCorrect 
    {
        // метод, проверяющий корректность объекта
        bool Correct(); 
    }
}
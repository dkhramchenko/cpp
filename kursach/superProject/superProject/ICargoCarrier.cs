using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace superProject
{
    // интерфейс для перевозящего грузы транспорта
    interface ICargoCarrier 
    {
        // метод, вычисляющий максимальный вес груза
        double MaxCargoWeight();
        // метод, вычисляющий максимальную длину груза
        double MaxCargoLength(); 
    }
}

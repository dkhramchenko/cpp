using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    interface IFuelConsumer
    {
        double TankRange();
        int FuelConsumption { get; set; }
        int TankCapacity { get; set; }
    }
}

using After_abstract_Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_abstract_Factory.Interfaces
{
    interface IAbstractCarFactory
    {
        Car GetCar(string type);
        void GetCarWheelSize(string type);
    }
}

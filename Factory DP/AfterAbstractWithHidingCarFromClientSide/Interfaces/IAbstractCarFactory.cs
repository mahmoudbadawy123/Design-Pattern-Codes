using AfterAbstractWithHidingCarFromClientSide;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterAbstractWithHidingCarFromClientSide.Interfaces
{
    interface IAbstractCarFactory
    {
        Car GetCar(string type);
        void GetCarWheelSize(string type);
        void CarDetails(string type);
    }
}

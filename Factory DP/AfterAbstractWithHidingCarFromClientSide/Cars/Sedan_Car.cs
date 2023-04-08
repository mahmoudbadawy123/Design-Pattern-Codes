using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterAbstractWithHidingCarFromClientSide
{
    class Sedan_Car : Car
    {
        public Sedan_Car()
        {
            CarName = "BMW";
            CarModelYear = 2020;
        }

        public override void RunCar()
        {
            Console.WriteLine($"#########################################");
            Console.WriteLine($"{CarName} is Running . Sedan overrided................!!! ");
            Console.WriteLine($"#########################################");
        }
    }
}

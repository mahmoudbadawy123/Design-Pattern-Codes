using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_Classic_Factory.Factory
{
    class CarFactory
    {
        public Car GetCar(string type)
        {
            switch (type)
            {
                case "1":
                    return new Truck_Car();
                case "2":
                    return new SUV_Car();
                case "3":
                    return new Sedan_Car();
                default:
                    Console.WriteLine("Your Choise type of car was wrong . ");
                    return null;
            }
        }
    }
}

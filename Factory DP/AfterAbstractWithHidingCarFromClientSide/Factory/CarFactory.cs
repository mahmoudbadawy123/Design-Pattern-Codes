using AfterAbstractWithHidingCarFromClientSide.Interfaces;
using AfterAbstractWithHidingCarFromClientSide.Wheels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfterAbstractWithHidingCarFromClientSide.Factory
{
    class CarFactory : IAbstractCarFactory
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
        public void CarDetails(string type) { 
            Car car = GetCar(type);
            car.RunCar();
            car.ShowCar();
        }
        public void GetCarWheelSize(string type)
        {
            switch (type)
            {
                case "1":
                     new LargeWheel().drawWheel();
                    break;
                case "2":
                     new MediumWheel().drawWheel();
                    break;
                case "3":
                     new SmallWheel().drawWheel();
                    break;
                default:
                    Console.WriteLine("Your Choise type of car was wrong . ");
                    break;
            }
        }
    }
}

using After_abstract_Factory.Factory;
using After_abstract_Factory.Interfaces;
using System;

namespace After_abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose type of car ==> 1=Truck or 2=SUV or 3=Sedan : ");
            string type = Console.ReadLine();
            IAbstractCarFactory AF = new CarFactory();
             var Car =   AF.GetCar(type);
            Car.RunCar();
            Car.ShowCar();
            AF.GetCarWheelSize(type);
            Console.ReadKey(true);
        }
    }
}

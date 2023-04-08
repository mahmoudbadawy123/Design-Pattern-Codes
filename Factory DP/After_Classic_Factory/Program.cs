using After_Classic_Factory.Factory;
using After_Classic_Factory.Interfaces;
using System;

namespace After_Classic_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose type of car ==> 1=Truck or 2=SUV or 3=Sedan : ");
            string type = Console.ReadLine();
            ICar car = new CarFactory().GetCar(type);
            car.RunCar();
            car.ShowCar();
            Console.ReadKey(true);
        }
    }
}

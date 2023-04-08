using AfterAbstractWithHidingCarFromClientSide.Factory;
using AfterAbstractWithHidingCarFromClientSide.Interfaces;
using System;

namespace AfterAbstractWithHidingCarFromClientSide
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose type of car ==> 1=Truck or 2=SUV or 3=Sedan : ");
            string type = Console.ReadLine();
            IAbstractCarFactory AF = new CarFactory();
            AF.CarDetails(type);
            AF.GetCarWheelSize(type);
            Console.ReadKey(true);
        }
    }
}

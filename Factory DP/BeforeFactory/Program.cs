using BeforeFactory.Interfaces;
using System;

namespace BeforeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose type of car ==> 1=Truck or 2=SUV or 3=Sedan : ");
            string type = Console.ReadLine();
            ICar car = null;
            switch (type)
            {
                case "1":
                    car = new Truck_Car();
                break;
                case "2":
                    car = new SUV_Car();
                    break;
                case "3":
                    car = new Sedan_Car();
                    break;
                default:
                    Console.WriteLine("Your Choise type of car was wrong . ");               
                    break;     
            }
            car.RunCar();
            car.ShowCar();
            Console.ReadKey(true);
        }
    }
}

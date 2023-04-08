using BeforeFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeforeFactory
{
   abstract class Car : ICar
    {
        public string CarName { get; set; }
        public int CarModelYear { get; set; }

        public void RunCar()
        {
            Console.WriteLine($"{CarName} is Running .");
        }
        public void ShowCar()
        {
            Console.WriteLine($"Car Model Year : {CarModelYear} is Showing .");
        }
    }
}

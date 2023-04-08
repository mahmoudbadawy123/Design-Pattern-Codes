using After_abstract_Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace After_abstract_Factory.Wheels
{
    class Wheel : IWheels
    {
        public string WheelSizeName { get; set; }
        public virtual void drawWheel()
        {
            Console.WriteLine($"Wheel Size is {WheelSizeName} ");
        }
    }
}

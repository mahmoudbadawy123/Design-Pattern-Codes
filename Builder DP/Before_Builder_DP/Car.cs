using System;
using System.Collections.Generic;
using System.Text;

namespace Before_Builder_DP
{
    internal class Car
    {
        private string BrandName;
        public Car(string _BrandName)
        {
            this.BrandName = _BrandName;
        }

        public void startOperations()
        {
            Console.WriteLine($"Car Model Name : {this.BrandName}");
        }

        public void BuildBody()
        {
            Console.WriteLine($"Build Body of {this.BrandName}");
        }

        public void InsertWheels()
        {
            Console.WriteLine($"Insert Wheels of {this.BrandName}");
        }

        public void InsertHeadLights()
        {
            Console.WriteLine($"Insert Head Lights of {this.BrandName}");
        }

        public void EndtOperations()
        {
            Console.WriteLine($"Endt Operations of {this.BrandName}");
        }
    }
}

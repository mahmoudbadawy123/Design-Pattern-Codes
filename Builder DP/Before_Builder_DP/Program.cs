using System;

namespace Before_Builder_DP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW");
            car.startOperations();
            car.InsertWheels();
            car.InsertHeadLights();
            car.BuildBody();
            car.EndtOperations();
        }
    }
}

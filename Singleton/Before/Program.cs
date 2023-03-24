using System;

namespace Before
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // with no Singleton it will create New 5 Instance in Memory
            Console.WriteLine($"########################");
            Console.WriteLine($"------------------------");
            Counter ObjA = new Counter();
            Counter ObjB = new Counter();
            Counter ObjC = new Counter();
            Counter ObjD = new Counter();
            Counter ObjE = new Counter();
            Console.WriteLine($"########################");
            Console.WriteLine($"Number Of Intances {Counter.NumberOfInstance}");
            Console.ReadKey(true);
        }
    }
}

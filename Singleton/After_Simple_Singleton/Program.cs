using System;

namespace After_Simple_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // with no Singleton it will create New 5 Instance in Memory
            Console.WriteLine($"########################");
            Console.WriteLine($"------------------------");
            Counter ObjA =  Counter.GetInstance();
            Counter ObjB =  Counter.GetInstance();
            Counter ObjC = Counter.GetInstance();
            Counter ObjD = Counter.GetInstance();
            Counter ObjE = Counter.GetInstance();
            Console.WriteLine($"########################");
            Console.WriteLine($"Number Of Intances {Counter.NumberOfInstance}");
            Console.ReadKey(true);
        }
    }
}

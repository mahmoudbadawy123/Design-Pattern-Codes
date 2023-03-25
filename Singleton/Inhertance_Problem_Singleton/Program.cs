using System;

namespace Inhertance_Problem_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // with no Singleton it will create New 5 Instance in Memory
            Console.WriteLine($"########### Before using Child #############");
            Console.WriteLine($"------------------------");
            Counter ObjA = Counter.GetInstance();
            Counter ObjB = Counter.GetInstance();
            Counter ObjC = Counter.GetInstance();
            Counter ObjD = Counter.GetInstance();
            Counter ObjE = Counter.GetInstance();
            Console.WriteLine($"Number Of Intances {Counter.NumberOfInstance}");
            Console.WriteLine($"########### After usning Child #############");
            Console.WriteLine($"------------------------");
            Counter ChildObjA = new Counter.ChildCls();
            Counter ChildObjB = new Counter.ChildCls();
            Counter ChildObjC = new Counter.ChildCls();
            Counter ChildObjD = new Counter.ChildCls();
            Counter ChildObjE = new Counter.ChildCls();
            Console.WriteLine($"########################");
            Console.WriteLine($"Number Of Intances {Counter.NumberOfInstance}");
            Console.ReadKey(true);
        }
    }
}

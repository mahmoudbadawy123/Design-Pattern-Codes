﻿using System;
using System.Threading.Tasks;

namespace SingletonWithOutThreadSafety
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"########### With using Parallel Or Threads #############");
            Console.WriteLine($"------------------------");
            Parallel.Invoke(
                 () => Method_1(),
                 () => Method_2(),
                 () => Method_3()
                 );
            Console.WriteLine($"Number Of Intances {Counter.NumberOfInstance}");
            Console.ReadKey(true);
        }

        public static void Method_1()
        {
            Counter ObjA = Counter.GetInstance();

        }
        public static void Method_2()
        {
            Counter ObjB = Counter.GetInstance();
        }

        public static void Method_3()
        {
            Counter ObjC = Counter.GetInstance();
        }
    }
}

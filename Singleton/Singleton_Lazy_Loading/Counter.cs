﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_Lazy_Loading
{
    //Sealed Will Stop any kind of Inhertance in Singleton Class
    internal sealed class Counter
    {
        public int Count = 0; //it is not shared so it is repeated in any new intance
        public static int NumberOfInstance = 0; //it is shared between all instances to Count Instrances

        // Eager loading add ReadOnly + New intance
        //public static Counter Instance = null;
        //public static readonly Counter Instance = new Counter();
        public static readonly Lazy<Counter> Instance = new Lazy<Counter>(()=> new Counter());

        // Defination Of Instance Lock 
        public static readonly object InstanceLock = new object();
        private Counter()
        {
            Count++;
            NumberOfInstance++;
            Console.WriteLine($"New Instance Number : " + Count);
        }
        public static Counter GetInstance()
        {
            return Instance.Value;
        }
    }
}

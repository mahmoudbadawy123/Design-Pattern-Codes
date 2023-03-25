using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton_After_ThreadSafety
{
    //Sealed Will Stop any kind of Inhertance in Singleton Class
    internal sealed class Counter
    {
        public int Count = 0; //it is not shared so it is repeated in any new intance
        public static int NumberOfInstance = 0; //it is shared between all instances to Count Instrances
        public static Counter Instance = null;
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
            lock (InstanceLock)
            {
                if (Instance == null)
                {
                    Instance = new Counter();
                }
            }
            return Instance;
        }
    }
}

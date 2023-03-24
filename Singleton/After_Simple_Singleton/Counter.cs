using System;
using System.Collections.Generic;
using System.Text;

namespace After_Simple_Singleton
{
    internal class Counter
    {
        public  int Count = 0; //it is not shared so it is repeated in any new intance
        public static int NumberOfInstance = 0; //it is shared between all instances to Count Instrances
        public static Counter Instance = null;

        private Counter()
        {
            Count++;
            NumberOfInstance++;
            Console.WriteLine($"New Instance Number : " + Count);
        }


        public static Counter GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Counter();
            }
            return Instance;
        }    
    }
}

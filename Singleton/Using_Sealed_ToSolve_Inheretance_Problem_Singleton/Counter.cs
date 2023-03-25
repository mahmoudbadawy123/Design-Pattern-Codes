using System;
using System.Collections.Generic;
using System.Text;

namespace Using_Sealed_ToSolve_Inheretance_Problem_Singleton
{
    //Sealed Will Stop any kind of Inhertance in Singleton Class
    internal sealed class Counter
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
        //Sealed Will Stop any kind of Inhertance in Singleton Class
        //public class ChildCls : Counter
        //{

        //}

    }
}

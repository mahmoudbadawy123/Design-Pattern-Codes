using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SingleTon_LazyLoading_With_GetData_Method
{
    //Sealed Will Stop any kind of Inhertance in Singleton Class
    internal sealed class CourencyConverter
    {
        public static int NumberOfInstance = 0; //it is shared between all instances to Count Instrances
        public static readonly Lazy<CourencyConverter> Instance = new Lazy<CourencyConverter>(()=> new CourencyConverter());
        public static readonly object InstanceLock = new object();
        public IEnumerable<ExchangeRate> _ExchangeRate { get; set; }
        private CourencyConverter()
        {
            NumberOfInstance++;
            Console.WriteLine($"New Instance Number : " + NumberOfInstance);
            getLookUpExchangeRate();
        }
        public static CourencyConverter GetInstance()
        {
            return Instance.Value;
        }


       private void getLookUpExchangeRate()
        {
            Thread.Sleep(3000);  // Wait 3 Sec Simulate Heavy Get Function
            _ExchangeRate = new[]
            {
                new ExchangeRate("DK","EGP",101.1m),
                new ExchangeRate("USD","EGP",30.75m),
                new ExchangeRate("SAR","EGP",8.30m),
            };
        }

        public decimal Convert(string BaseCurrenct , decimal Amount)
        {
            var  ExchangeRate = _ExchangeRate.FirstOrDefault(_ => _.BaseCurrency == BaseCurrenct);
            return  ExchangeRate.Rate * Amount ;
        }
    }
}

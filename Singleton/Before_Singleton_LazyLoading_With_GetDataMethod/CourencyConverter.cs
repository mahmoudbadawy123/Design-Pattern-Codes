using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Before_Singleton_LazyLoading_With_GetDataMethod
{
    internal  class CourencyConverter
    {
        public static int NumberOfInstance = 0; //it is shared between all instances to Count Instrances
        public IEnumerable<ExchangeRate> _ExchangeRate { get; set; }
        public CourencyConverter()
        {
            NumberOfInstance++;
            Console.WriteLine($"New Instance Number : " + NumberOfInstance);
            getLookUpExchangeRate();
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

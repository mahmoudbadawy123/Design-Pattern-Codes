using System;
using System.Collections.Generic;
using System.Text;

namespace Before_Singleton_LazyLoading_With_GetDataMethod
{
    internal class ExchangeRate
    {
        public string BaseCurrency { get;}
        public string TargetCurrency { get; }
        public decimal Rate { get; }

        public ExchangeRate(string _BaseCurrency , string _TargetCurrency , decimal _Rate)
        {
            BaseCurrency= _BaseCurrency;
            TargetCurrency= _TargetCurrency;
            Rate= _Rate;
        }
    }
}

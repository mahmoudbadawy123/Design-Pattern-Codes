using System;

namespace SingleTon_LazyLoading_With_GetData_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter BaseCurrency ( DK - USD - SAR) it will Convert to EGP :");
                var BaseCurrency = Console.ReadLine();
                Console.WriteLine("Enter Amount of BaseCurrency :");
                var Amount = decimal.Parse(Console.ReadLine());
                var ExchangeAmount = CourencyConverter.GetInstance().Convert(BaseCurrency, Amount);
                Console.WriteLine($"BaseCurrency : {Amount} {BaseCurrency}   --> TargetCurrency : {ExchangeAmount} EGP ");
            }
        }
    }
}

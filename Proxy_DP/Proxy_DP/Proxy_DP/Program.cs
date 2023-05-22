using System;

namespace Proxy_DP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ProxySmsService ProxySms = new ProxySmsService();
            Console.WriteLine(ProxySms.SendSms("1", "01029684521", "SMS 1"));
            Console.WriteLine(ProxySms.SendSms("1", "01025284121", "SMS 2"));
            Console.WriteLine(ProxySms.SendSms("1", "01055685521", "SMS 3"));
        }
    }
}

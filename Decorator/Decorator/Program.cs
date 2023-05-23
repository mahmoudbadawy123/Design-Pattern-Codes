using Decorator.Decorator;
using Proxy_DP;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSmsService Service = new ConcreteSmsService();
            NotificationEmailDecorator Notify = new NotificationEmailDecorator();
            Notify.setService(Service);
            Console.WriteLine(Notify.SendSms("1", "01029684521", "SMS 1"));
        }
    }
}

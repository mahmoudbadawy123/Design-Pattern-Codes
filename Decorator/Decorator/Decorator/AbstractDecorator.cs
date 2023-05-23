using Proxy_DP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
    public abstract class AbstractDecorator : AbsSmsService
    {
        protected  AbsSmsService _notification;

        public void setService(AbsSmsService notification)
        {
            _notification = notification;
        }
        public override string SendSms(string CustomerId, string MobileNum, string Sms)
        {
            if(_notification != null)
            {
                return _notification.SendSms(CustomerId, MobileNum, Sms);
            }
            return $"Notification Service is not Intialized .";
        }


    }
}

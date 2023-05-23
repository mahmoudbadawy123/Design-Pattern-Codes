using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorator
{
   public class NotificationEmailDecorator : AbstractDecorator
    {

        public override string SendSms(string CustomerId, string MobileNum, string Sms)
        {
            StringBuilder Result = new StringBuilder();
            Result.Append(base.SendSms(CustomerId, MobileNum, Sms));
            Result.Append("\n");
            Result.Append(SendNotification(CustomerId, Sms));
            return Result.ToString(); 
        }

        public string SendNotification(string CustomerId, string Sms)
        {
            return $" ---> Sms : {Sms} is Sent to CustomerId is {CustomerId} at {DateTime.Now.ToLongDateString()}.";
        }
    }
}

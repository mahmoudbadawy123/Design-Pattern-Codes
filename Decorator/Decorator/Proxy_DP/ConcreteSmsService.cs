using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_DP
{
    public class ConcreteSmsService : AbsSmsService
    {
        public override string SendSms(string CustomerId, string MobileNum, string Sms)
        {
            return $" CustomerId is {CustomerId} Sms is Sent to ({MobileNum}) .";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_DP
{
   public abstract class AbsSmsService
    {
        public abstract string SendSms(String CustomerId, String MobileNum, string Sms);
    }
}

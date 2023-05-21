using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_DP
{
    public class ProxySmsService : AbsSmsService
    {

        private AbsSmsService _SmsService;
        // Count Call for Each Customer
        Dictionary<string, int> Count = new Dictionary<string, int>();
        public override string SendSms(string CustomerId, string MobileNum, string Sms)
        {
            if (_SmsService == null)
            {
                _SmsService = new ConcreteSmsService();
            }

            if (!Count.ContainsKey(CustomerId))
            {
                Count.Add(CustomerId, 1);
                return _SmsService.SendSms(CustomerId, MobileNum, Sms);
            }
            else
            {
                var Customer = Count.Where(_ => _.Key == CustomerId).FirstOrDefault();
                if (Customer.Value >= 2)
                {
                    return "Not sent  because your message limit is 2 messages only .";
                }
                else
                {
                    // Should Set Value of coustmer Sms Count value by this Method
                    Count[CustomerId] = Customer.Value + 1;
                    return _SmsService.SendSms(CustomerId, MobileNum, Sms);
                }
            }
            return _SmsService.SendSms(CustomerId, MobileNum, Sms);
        }
    }
}
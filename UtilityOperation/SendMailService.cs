using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityOperation
{
    public class SendMailService
    {
        public SendMailService() { }
        public string SendMailtoCustomer(string email) {
        
        Console.WriteLine($"Sending mail to {email}...");
            return $"Mail sent to {email}";
        }
    }
}

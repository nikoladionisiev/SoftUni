using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _03._Telephony
{
    class Smartphone : ICallable, IBrowsable
    {
       
        string IBrowsable.Browse(string url)
        {
            if (url.Any(ch => char.IsDigit(ch)))
            {
                return "Invalid URL!";
            }
            return $"Browsing: {url}";
        }

        string ICallable.Call(string phoneNumber)
        {
            if (!phoneNumber.All(ch => char.IsDigit(ch)))
            {
                throw new Exception("Invalid number.");
            }
            return $"Calling... {phoneNumber}";
        }
    }
}

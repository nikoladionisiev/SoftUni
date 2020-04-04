using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace _03._Telephony
{
    class StationaryPhone : ICallable
    {
        public string Call(string phoneNumber)
        {
            if (!phoneNumber.All(ch => char.IsDigit(ch)))
            {
                return "Invalid number.";
            }
            return $"Dialing... {phoneNumber}";
        }
    }
}

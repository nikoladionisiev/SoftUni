using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Military_Elite.Exceptions
{
    public class InvalidCorpsException : Exception
    {
        private const string DEF_EXC_MSG;

        public InvalidCorpsException():base(DEF_EXC_MSG)
        {
        }

        public InvalidCorpsException(string message) : base(message)
        {
        }
    }
}

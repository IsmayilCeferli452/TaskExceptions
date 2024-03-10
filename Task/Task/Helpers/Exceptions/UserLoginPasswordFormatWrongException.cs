using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Helpers.Exceptions
{
    public class UserLoginPasswordFormatWrongException : Exception
    {
        public UserLoginPasswordFormatWrongException(string message) : base(message) { }
    }
}

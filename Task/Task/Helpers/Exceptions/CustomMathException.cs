using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Helpers.Exceptions
{
    public class CustomMathException : Exception
    {
        public CustomMathException(string message) : base(message) { }
    }
}

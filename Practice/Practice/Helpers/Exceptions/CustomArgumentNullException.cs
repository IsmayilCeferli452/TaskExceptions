using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.Helpers.Exceptions
{
    public class CustomArgumentNullException : Exception
    {
        public CustomArgumentNullException(string message):base(message) { }
    }
}

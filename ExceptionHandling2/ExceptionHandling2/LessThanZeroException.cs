using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    public class LessThanZeroException : Exception
    {
        public LessThanZeroException()
            : base () { }
        public LessThanZeroException(string message)
            : base (message) { }
    }
}

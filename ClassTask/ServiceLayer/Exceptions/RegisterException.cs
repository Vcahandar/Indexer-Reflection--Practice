using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Exceptions
{
    public class RegisterException : Exception
    {
        public RegisterException(string massage) : base(massage) { }
        
    }
}

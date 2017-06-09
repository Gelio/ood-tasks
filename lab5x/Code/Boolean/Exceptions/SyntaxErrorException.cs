using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOD_5A1.Boolean.Exceptions
{
    class SyntaxErrorException : Exception
    {
        public SyntaxErrorException() : base("SYNTAX_ERROR")
        {

        }
    }
}

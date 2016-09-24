using System;
using System.Collections.Generic;
using System.Text;

namespace METAR_Decode
{
    class ParserException : Exception
    {
       

        public ParserException() : base("Illegal METAR/SPECI")
        {
            
        }

        public ParserException(String s) : base(s)
        {

        }
    }
}

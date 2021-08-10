using System;

namespace NewDSL
{
    public class ParserException : Exception
    {
        public ParserException(string s) : base(s)
        {
        }
    }
}
﻿using System;

namespace Parser.Exceptions
{
    public class ParserException : Exception
    {
        public ParserException()
        {
        }

        public ParserException(string message) : base(message)
        {
        }
    }
}
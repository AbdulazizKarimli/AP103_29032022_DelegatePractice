using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Exceptions
{
    internal class ProductCountIsZeroException : Exception
    {
        public ProductCountIsZeroException(string message) : base(message)
        {
        }
    }
}

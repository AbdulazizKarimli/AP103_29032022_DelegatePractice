using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask.Exceptions
{
    internal class NotFoundException : Exception
    {
        public NotFoundException(string message):base(message)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateTask.Exceptions
{
    internal class EmployeeAlreadyExistsException : Exception
    {
        public EmployeeAlreadyExistsException(string message) : base(message)
        {
        }
    }
}

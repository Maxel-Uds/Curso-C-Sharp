using System;

namespace exemplo2.Entities.Exceptions
{
    public class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base(message)
        {
        }
    }
}
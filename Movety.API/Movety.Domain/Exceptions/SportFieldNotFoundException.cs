using System;

namespace Movety.Domain.Exceptions
{
    public class SportFieldNotFoundException : Exception
    {
        public SportFieldNotFoundException()
        {
        }

        public SportFieldNotFoundException(string message) : base(message)
        {
        }
    }
}
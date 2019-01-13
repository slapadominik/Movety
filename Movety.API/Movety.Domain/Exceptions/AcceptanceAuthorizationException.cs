using System;

namespace Movety.Domain.Exceptions
{
    public class AcceptanceAuthorizationException : Exception
    {
        public AcceptanceAuthorizationException()
        {
        }

        public AcceptanceAuthorizationException(string message) : base(message)
        {
        }
    }
}
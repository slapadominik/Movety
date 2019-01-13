using System;

namespace Movety.Domain.Exceptions
{
    public class MaxParticipantsException : Exception
    {
        public MaxParticipantsException()
        {
        }

        public MaxParticipantsException(string message) : base(message)
        {
        }
    }
}
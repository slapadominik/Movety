using System;

namespace Movety.Domain.Exceptions
{
    public class TrainingProposalNotFoundException : Exception
    {
        public TrainingProposalNotFoundException()
        {
        }

        public TrainingProposalNotFoundException(string message) : base(message)
        {
        }
    }
}
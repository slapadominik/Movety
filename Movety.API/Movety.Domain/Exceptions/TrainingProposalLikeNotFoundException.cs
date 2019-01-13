using System;

namespace Movety.Domain.Exceptions
{
    public class TrainingProposalLikeNotFoundException : Exception
    {
        public TrainingProposalLikeNotFoundException()
        {
        }

        public TrainingProposalLikeNotFoundException(string message) : base(message)
        {
        }
    }
}
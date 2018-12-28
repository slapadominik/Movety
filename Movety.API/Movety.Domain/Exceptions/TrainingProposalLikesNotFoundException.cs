using System;

namespace Movety.Domain.Exceptions
{
    public class TrainingProposalLikesNotFoundException : Exception
    {
        public TrainingProposalLikesNotFoundException()
        {
        }

        public TrainingProposalLikesNotFoundException(string message) : base(message)
        {
        }
    }
}
using AutoMapper;
using Movety.Persistence.DAO;

namespace Movety.Domain
{
    public class MappingDomainProfile : Profile
    {
        public MappingDomainProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<TrainingProposals,Persistence.DAO.TrainingProposals>();
        }
    }
}
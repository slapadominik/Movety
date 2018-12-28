using AutoMapper;
using Movety.Domain.Entities;
using Movety.Persistence.DAO;
using Athlethe = Movety.Domain.Entities.Athlethe;


namespace Movety.Domain
{
    public class MappingDomainProfile : Profile
    {
        public MappingDomainProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<TrainingProposal,Persistence.DAO.TrainingProposals>();
            CreateMap<Athlethe, Persistence.DAO.Athlethe>();
            CreateMap<Persistence.DAO.TrainingProposals, TrainingProposal>();
            CreateMap<Persistence.DAO.Athlethe, Athlethe>();
        }
    }
}
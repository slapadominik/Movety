using AutoMapper;
using Movety.Domain.Entities;
using Movety.Persistence.DAO;
using Athlethe = Movety.Domain.Entities.Athlethe;
using User = Movety.Persistence.DAO.User;


namespace Movety.Domain
{
    public class MappingDomainProfile : Profile
    {
        public MappingDomainProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<TrainingProposal,Persistence.DAO.TrainingProposals>();
            CreateMap<Persistence.DAO.TrainingProposals, TrainingProposal>()
                .ForMember(x => x.Author, opt => opt.Ignore());

            CreateMap<Athlethe, Persistence.DAO.Athlethe>();
            CreateMap<Persistence.DAO.Athlethe, Athlethe>();

            CreateMap<TrainingProposalAcceptance, Persistence.DAO.TrainingProposalsAcceptance>();
            CreateMap<Persistence.DAO.TrainingProposalsAcceptance, TrainingProposalAcceptance>();
        }
    }
}
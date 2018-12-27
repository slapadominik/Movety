using AutoMapper;
using Movety.API.DTO.Output;


namespace Movety.API
{
    public class MappingAPIProfile : Profile
    {
        public MappingAPIProfile()
        {
            CreateMap<Domain.Entities.TrainingProposal, TrainingProposalResponse>();
            CreateMap<Domain.Entities.Location, DTO.Output.Location>();
            CreateMap<Domain.Entities.SportField, DTO.Output.SportField>();

        }
    }
}
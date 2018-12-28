using System;
using AutoMapper;
using Movety.API.DTO.Output;
using Movety.Domain.Entities;


namespace Movety.API
{
    public class MappingAPIProfile : Profile
    {
        public MappingAPIProfile()
        {
            CreateMap<Domain.Entities.TrainingProposal, TrainingProposalResponse>();
            CreateMap<Domain.Entities.Location, DTO.Output.Location>();
            CreateMap<Domain.Entities.SportField, DTO.Output.SportField>();
            CreateMap<Domain.Entities.TrainingProposalLikes, DTO.Output.TrainingProposalLikes>()
                .ForMember(x => x.AthletesBrief, opt => opt.MapFrom(src => src.Athletes));

            CreateMap<Athlethe, AthleteBrief>()
                .ForMember(dest => dest.Age, opt => opt.MapFrom(src => DateTime.Now.Year - src.Birthdate.Year));
        }
    }
}
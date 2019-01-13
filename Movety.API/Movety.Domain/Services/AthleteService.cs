using System;
using System.Collections.Generic;
using AutoMapper;
using Movety.Domain.Entities;
using Movety.Domain.Exceptions;
using Movety.Domain.Services.Interfaces;
using Movety.Persistence.Repositories.Interfaces;

namespace Movety.Domain.Services
{
    public class AthleteService : IAthleteService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AthleteService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public IEnumerable<Athlethe> GetAll()
        {
            return _mapper.Map<IEnumerable<Athlethe>>(_unitOfWork.Athletes.GetAll());
        }

        public Athlethe Get(Guid id)
        {
            var athleteDAO = _unitOfWork.Athletes.Get(id);
            if (athleteDAO == null)
            {
                throw new UserNotFoundException();
            }

            return _mapper.Map<Athlethe>(athleteDAO);
        }
    }
}
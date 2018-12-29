using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movety.API.DTO.Output;
using Movety.Domain.Services.Interfaces;

namespace Movety.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProposalsLikesController : ControllerBase
    {
        private readonly ITrainingProposalsLikesService _trainingProposalsService;
        private readonly IMapper _mapper;

        public TrainingProposalsLikesController(ITrainingProposalsLikesService trainingProposalsLikesService, IMapper mapper)
        {
            _trainingProposalsService = trainingProposalsLikesService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public ActionResult<TrainingProposalLikes> GetByTrainingProposalId(Guid id)
        {
            var trainingProposalsLikeDomain = _trainingProposalsService.GetByTrainingProposalId(id);
            if (trainingProposalsLikeDomain == null)
            {
                return NotFound($"Training proposal with id [{id}] doesn't have likes.");
            }
            var response =_mapper.Map<TrainingProposalLikes>(trainingProposalsLikeDomain);
            return Ok(response);
        }


    }
}
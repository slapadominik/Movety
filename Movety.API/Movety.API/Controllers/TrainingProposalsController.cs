using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movety.API.DTO.Input;
using Movety.API.DTO.Output;
using Movety.Domain.Entities;
using Movety.Domain.Services.Interfaces;

namespace Movety.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProposalsController : ControllerBase
    {
        private readonly ITrainingProposalsService _trainingProposalsService;
        private readonly ITrainingProposalsLikesService _trainingProposalLikesService;
        private readonly IMapper _mapper;

        public TrainingProposalsController(ITrainingProposalsService trainingProposalsService, ITrainingProposalsLikesService trainingProposalLikesService, IMapper mapper)
        {
            _trainingProposalsService = trainingProposalsService;
            _trainingProposalLikesService = trainingProposalLikesService;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<TrainingProposalResponse> GetAll()
        {
            try
            {
                var trainingProposals = _trainingProposalsService.GetAll();
                var trainingProposalResponse = _mapper.Map<List<TrainingProposalResponse>>(trainingProposals);
                return Ok(trainingProposalResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<TrainingProposalResponse> GetById(Guid id)
        {
            try
            {
                var trainingProposal = _trainingProposalsService.Get(id);
                var trainingProposalResponse = _mapper.Map<TrainingProposalResponse>(trainingProposal);
                return Ok(trainingProposalResponse);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}/likes")]
        public ActionResult<DTO.Output.TrainingProposalLikes> GetLikesByTrainingProposalId(Guid id)
        {
            var trainingProposalsLikeDomain = _trainingProposalLikesService.GetByTrainingProposalId(id);
            if (trainingProposalsLikeDomain == null)
            {
                return NotFound($"Training proposal with id [{id}] doesn't have likes.");
            }
            var response = _mapper.Map<DTO.Output.TrainingProposalLikes>(trainingProposalsLikeDomain);
            return Ok(response);
        }

    }
}
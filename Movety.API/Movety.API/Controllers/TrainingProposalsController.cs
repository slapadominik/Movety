using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movety.API.DTO.Input;
using Movety.API.DTO.Output;
using Movety.Domain.Entities;
using Movety.Domain.Services.Interfaces;
using AthleteBrief = Movety.API.DTO.Output.AthleteBrief;
using TrainingProposalAcceptance = Movety.API.DTO.Input.TrainingProposalAcceptance;
using TrainingProposalLikes = Movety.API.DTO.Output.TrainingProposalLikes;

namespace Movety.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingProposalsController : ControllerBase
    {
        private readonly ITrainingProposalsService _trainingProposalsService;
        private readonly ITrainingProposalsLikesService _trainingProposalLikesService;
        private readonly ITrainingProposalsAcceptanceService _trainingProposalsAcceptanceService;
        private readonly IAthleteService _athleteService;
        private readonly IMapper _mapper;

        public TrainingProposalsController(ITrainingProposalsService trainingProposalsService, IAthleteService athleteService, ITrainingProposalsLikesService trainingProposalLikesService, ITrainingProposalsAcceptanceService trainingProposalsAcceptanceService, IMapper mapper)
        {
            _trainingProposalsService = trainingProposalsService;
            _trainingProposalLikesService = trainingProposalLikesService;
            _trainingProposalsAcceptanceService = trainingProposalsAcceptanceService;
            _athleteService = athleteService;
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
            TrainingProposalLikes likes = new TrainingProposalLikes
                {TrainingProposalId = id, AthletesBrief = new List<AthleteBrief>()};
            likes.AthletesBrief = _mapper.Map<List<AthleteBrief>>(trainingProposalsLikeDomain.Athletes);
            return Ok(likes);
        }


        [HttpPost("acceptances")]
        public ActionResult<TrainingProposalAcceptance> AddTrainingProposalAcceptance([FromBody] TrainingProposalAcceptanceRequest acceptance)
        {
            try
            {
                var acceptanceDomain = _mapper.Map<Domain.Entities.TrainingProposalAcceptance>(acceptance.TrainingProposalAcceptance);
                _trainingProposalsAcceptanceService.Add(acceptance.RequesterId, acceptanceDomain);
                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}/acceptances")]
        public ActionResult<AcceptanceAthletesBriefs> GetAcceptancesByTrainingProposalId(Guid id)
        {
            try
            {
                var acceptancesDomain = _trainingProposalsAcceptanceService.GetByTrainingProposalId(id);
                AcceptanceAthletesBriefs acceptances = new AcceptanceAthletesBriefs {TrainingProposalId = id, Users = new List<AthleteBrief>()};
                foreach (var acceptanceDomain in acceptancesDomain)
                {
                    var athlete = _athleteService.Get(acceptanceDomain.UserId);
                    acceptances.Users.Add(_mapper.Map<AthleteBrief>(athlete));
                }
                return Ok(acceptances);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
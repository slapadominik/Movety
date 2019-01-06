using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movety.API.DTO.Input;
using Movety.API.DTO.Output;
using Movety.Domain.Services.Interfaces;

namespace Movety.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ITrainingProposalsLikesService _trainingProposalLikesService;
        private readonly ITrainingProposalsService _trainingProposalsService;
        private readonly IMapper _mapper;

        public UsersController(ITrainingProposalsLikesService trainingProposalsLikesService, ITrainingProposalsService trainingProposalsService, IMapper mapper)
        {
            _trainingProposalLikesService = trainingProposalsLikesService;
            _trainingProposalsService = trainingProposalsService;
            _mapper = mapper;
        }

        [HttpGet("{id}/likes")]
        public ActionResult<TrainingProposalsLikedByUser> GetLikedTrainingProposalsByUserId(Guid id)
        {
            var trainingProposalsDomain = _trainingProposalLikesService.GetLikedTrainingProposalsByUserId(id);
            if (!trainingProposalsDomain.Any())
            {
                return NotFound($"User with id {id} hasn't liked any training proposal yet.");
            }

            var result = new TrainingProposalsLikedByUser
            {
                UserId = id,
                TrainingProposals = _mapper.Map<List<TrainingProposalResponse>>(trainingProposalsDomain)
            };
            return Ok(result);
        }

        // POST api/values
        [HttpPost("likes")]
        public ActionResult<TrainingProposalLike> AddTrainingProposalLike([FromBody] TrainingProposalLike trainingProposalLike)
        {
            try
            {
                _trainingProposalLikesService.Add(trainingProposalLike.UserId, trainingProposalLike.TrainingProposalId);
                return CreatedAtAction("GetLikedTrainingProposalsByUserId", trainingProposalLike);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}/trainingproposals")]
        public ActionResult<TrainingProposalResponse> GetNewTrainingProposalsForUser(Guid id)
        {
            try
            {
                var trainingProposalsDomain = _trainingProposalsService.GetNewTrainingProposalsForUser(id);
                if (!trainingProposalsDomain.Any())
                {
                    return NotFound($"None new training proposals has been found for User {id} .");
                }

                var trainingProposalResponses = _mapper.Map<List<TrainingProposalResponse>>(trainingProposalsDomain);
                return Ok(trainingProposalResponses);
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}
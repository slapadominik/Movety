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
        private readonly IMapper _mapper;

        public UsersController(ITrainingProposalsLikesService trainingProposalsLikesService, IMapper mapper)
        {
            _trainingProposalLikesService = trainingProposalsLikesService;
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
        [HttpPost("{id}/likes")]
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
    }
}
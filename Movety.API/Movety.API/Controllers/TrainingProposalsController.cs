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
        private readonly IMapper _mapper;

        public TrainingProposalsController(ITrainingProposalsService trainingProposalsService, IMapper mapper)
        {
            _trainingProposalsService = trainingProposalsService;
            _mapper = mapper;
        }


        [HttpGet]
        public ActionResult<TrainingProposalResponse> Get()
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
        public ActionResult<TrainingProposalResponse> Get(Guid id)
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

        [HttpPost]
        public ActionResult Post([FromBody] TrainingProposalAddRequest request)
        {
            var trainingProposal = _mapper.Map<TrainingProposal>(request);

            try
            {
                _trainingProposalsService.Add(trainingProposal);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return Ok();
        }

    }
}
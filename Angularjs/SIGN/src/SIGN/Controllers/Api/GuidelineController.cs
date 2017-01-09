using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGN.Controllers.Api
{
    public class GuidelineController : Controller
    {
        private ILogger<GuidelineController> _logger;
        private ISIGNRepository _repository;

        public GuidelineController(
            ISIGNRepository repository,
            ILogger<GuidelineController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("api/guidelines")]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<Guideline> guidelines = _repository.GetGuidelines();
                return Ok(Mapper.Map<IEnumerable<GuidelineViewModel>>(guidelines));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve guidelines: {ex}");
                return BadRequest("Error in retrieving guidelines");
            }
        }

        [HttpGet("api/guidelines/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                Guideline guideline = _repository.GetGuideline(id);
                return Ok(Mapper.Map<GuidelineViewModel>(guideline));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve guideline: {ex}");
                return BadRequest("Error in retrieving guideline");
            }
        }

        [HttpPost("api/guidelines")]
        public async Task<IActionResult> Post([FromBody]GuidelineViewModel guideline)
        {
            if (ModelState.IsValid)
            {
                Guideline newGuideline = Mapper.Map<Guideline>(guideline);
                _repository.AddGuideline(newGuideline);
        
                if (await _repository.SaveChangesAsync())
                {
                    return Created($"api/guidelines/{guideline.Name}", Mapper.Map<GuidelineViewModel>(newGuideline));
                }

                return BadRequest("Failed to save guideline.");
            }

            return BadRequest(ModelState);
        }
    }
}

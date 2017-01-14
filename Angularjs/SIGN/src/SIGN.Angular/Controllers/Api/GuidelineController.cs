using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.Angular.ViewModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIGN.Angular.Controllers.Api
{
    public class GuidelineController : Controller
    {
        private ILogger<GuidelineController> _logger;
        private ISIGNService _signService; 

        public GuidelineController(
            ISIGNService signService,
            ILogger<GuidelineController> logger)
        {
            _signService = signService;
            _logger = logger;
        }

        [HttpGet("api/guidelines")]
        public IActionResult Get()
        {
            try
            {
                IEnumerable<Guideline> guidelines = _signService.GetGuidelines();
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
                Guideline guideline = _signService.GetGuideline(id);
                if (guideline != null)
                {
                    return Ok(Mapper.Map<GuidelineViewModel>(guideline));
                }
                else
                {
                    _logger.LogError($"Failed to retrieve guideline {id}");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve guideline {id} : {ex}");
                return BadRequest($"Error in retrieving guideline {id}");
            }
        }

        [HttpPost("api/guidelines")]
        public async Task<IActionResult> Post([FromBody]GuidelineViewModel guideline)
        {
            if (ModelState.IsValid)
            {
                Guideline newGuideline = Mapper.Map<Guideline>(guideline);
        
                if (await _signService.AddGuideline(newGuideline))
                {
                    return Created($"api/guidelines/{guideline.Name}", Mapper.Map<GuidelineViewModel>(newGuideline));
                }

                return BadRequest("Failed to save guideline.");
            }

            return BadRequest(ModelState);
        }
    }
}

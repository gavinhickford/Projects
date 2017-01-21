using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGN.Angular.ViewModels;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace SIGN.Angular.Controllers.Api
{
    [Route("/api/assessments/{id}")]
    public class AssessmentController : Controller
    {
        private ILogger<AssessmentController> _logger;
        private IGuidelineService _guidelineService;

        public AssessmentController(ISIGNRepository repository, IGuidelineService guidelineService, ILogger<AssessmentController> logger)
        {
            _guidelineService = guidelineService;
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Get(int id)
        {
            try
            {
                Assessment assessment = _guidelineService.GetAssessment(id);
                if (assessment != null)
                {
                    return Ok(Mapper.Map<AssessmentViewModel>(assessment));
                }
                else
                {
                    _logger.LogError($"Assessment {id} not found");
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to retrieve Assessment {id}: {ex}");
                return BadRequest($"Error in retrieving Assessment {id}.");
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(int id, [FromBody]AssessmentViewModel assessment)
        {
            if (ModelState.IsValid)
            {
                Assessment newAssessment = Mapper.Map<Assessment>(assessment);
                
                if (await _guidelineService.AddAssessment(id, newAssessment))
                {
                    return Created($"api/assessments/{id}/{assessment.Name}", Mapper.Map<AssessmentViewModel>(newAssessment));
                }

                return BadRequest("Failed to save assessment.");
            }

            return BadRequest(ModelState);
        }
    }
}

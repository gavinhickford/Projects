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
    /// <summary>
    /// Controller to handle requests about assessments
    /// </summary>
    [Route("/api/assessments/{id}")]
    public class AssessmentController : Controller
    {
        private ILogger<AssessmentController> _logger;
        private IAssessmentService _assessmentService;

        public AssessmentController(
            IAssessmentService assessmentService, 
            ILogger<AssessmentController> logger)
        {
            _assessmentService = assessmentService;
            _logger = logger;
        }

        /// <summary>
        /// Gets an assessment by id
        /// </summary>
        /// <param name="id">Assessment identifier</param>
        /// <returns>Assessment</returns>
        [HttpGet("")]
        public IActionResult Get(int id)
        {
            try
            {
                Assessment assessment = _assessmentService.GetAssessment(id);
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

        /// <summary>
        /// Saves an assessment
        /// </summary>
        /// <param name="id">The associated guideline id</param>
        /// <param name="assessment">Assessment details</param>
        /// <returns>Created (201) response</returns>
        [HttpPost("")]
        public async Task<IActionResult> Post(int id, [FromBody]AssessmentViewModel assessment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Assessment newAssessment = Mapper.Map<Assessment>(assessment);

                    if (await _assessmentService.AddAssessment(id, newAssessment))
                    {
                        return Created($"api/assessments/{id}/{assessment.Name}", Mapper.Map<AssessmentViewModel>(newAssessment));
                    }

                    return BadRequest("Failed to save assessment.");
                }

                return BadRequest(ModelState);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to save Assessment: {ex}");
                return BadRequest("Error in saving Assessment.");
            }
        }
    }
}

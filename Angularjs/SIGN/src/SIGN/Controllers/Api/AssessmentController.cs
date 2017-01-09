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
    [Route("/api/assessments/{id}")]
    public class AssessmentController : Controller
    {
        private ILogger<AssessmentController> _logger;
        private ISIGNRepository _repository;

        public AssessmentController(ISIGNRepository repository, ILogger<AssessmentController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Get(int id)
        {
            try
            {
                Assessment assessment = _repository.GetAssessment(id);
                return Ok(Mapper.Map<AssessmentViewModel>(assessment));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get Assessment: {ex}");
            }

            return BadRequest("Failed to retrieve assessment.");
        }

        [HttpPost("")]
        public async Task<IActionResult> Post(int id, [FromBody]AssessmentViewModel assessment)
        {
            if (ModelState.IsValid)
            {
                Assessment newAssessment = Mapper.Map<Assessment>(assessment);
                _repository.AddAssessment(id, newAssessment);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"api/assessments/{id}/{assessment.Name}", Mapper.Map<AssessmentViewModel>(newAssessment));
                }

                return BadRequest("Failed to save assessment.");
            }

            return BadRequest(ModelState);
        }
    }
}

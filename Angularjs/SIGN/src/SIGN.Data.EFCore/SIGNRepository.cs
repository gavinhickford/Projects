using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.Data.EFCore
{
    public class SIGNRepository : ISIGNRepository
    {
        private ISIGNContext _context;
        private ILogger<SIGNRepository> _logger;

        public SIGNRepository(ISIGNContext context, ILogger<SIGNRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void AddAssessment(int guidelineId, Assessment assessment)
        {
            _logger.LogInformation($"Adding assessment: name = {assessment.Name}");
            Guideline guideline = GetGuideline(guidelineId);

            if (guideline != null)
            {
                 guideline.Assessments.Add(assessment);
                _context.Assessments.Add(assessment);
            }
        }

        public void SaveGuideline(Guideline guideline)
        {
            _logger.LogInformation($"Saving guideline: name = {guideline.Name}");
            Guideline existingGuideline = GetGuideline(guideline.Id);
            if (existingGuideline != null)
            {
                existingGuideline.Name = guideline.Name;
                existingGuideline.Number = guideline.Number;
                existingGuideline.Author = guideline.Author;
                existingGuideline.DatePublished = guideline.DatePublished;
                existingGuideline.Status = guideline.Status;
            }
            else
            {
                _context.Add(guideline);
            }
        }

        public Assessment GetAssessment(int id)
        {
            _logger.LogInformation($"Retrieving Assessment: id = {id}");

            return _context.Assessments
                .FirstOrDefault(a => a.Id == id);
        }

        public Guideline GetGuideline(int id)
        {
            _logger.LogInformation($"Retrieving Guideline: id = {id}");
                
            return _context.Guidelines
                .Include(g => g.Assessments)
                .FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Guideline> GetGuidelines()
        {
            _logger.LogInformation("Retrieving Guidelines");
            return _context.Guidelines.ToList();
        }

        public IEnumerable<Guideline> GetGuidelinesByAuthor(string authorName)
        {
            _logger.LogInformation($"Retrieving Guidelines by author: {authorName}");
            return _context.Guidelines
                .Where(g => g.Author == authorName)
                .ToList();
        }
        public async Task<bool> SaveChangesAsync()
        {
            try
            {
                return (await _context.SaveChangesAsync(true)) > 0;
            }
            catch (System.Data.SqlClient.SqlException se)
            {
                _logger.LogError(se.Message);
                return false;
            }
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Step GetStep(int id)
        {
            return _context.Steps
                .Include(s => s.Detail)
                .FirstOrDefault(s => s.Id == id);
        }

        public Decision GetDecision(int stepId, bool choice)
        {
            return _context.Decisions
           .Include(d => d.Step)
           .Include(d => d.Action)
           .Include(d => d.Action.NextStep)
           .FirstOrDefault(d => d.Step.Id == stepId && d.Condition == choice);
        }

        public void AddStep(Step step)
        {
            _context.Add(step);
        }

        public void AddDecision(Decision decision)
        {
            _context.Add(decision);
        }

        public void AddStepAction(StepAction stepAction)
        {
            _context.Add(stepAction);
        }

        public void AddRecommendationGrade(RecommendationGrade grade)
        {
            _context.Add(grade);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System;
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
            Guideline guideline = GetGuideline(guidelineId);

            if (guideline != null)
            {
                 guideline.Assessments.Add(assessment);
                _context.Assessments.Add(assessment);
            }
        }

        public void SaveGuideline(Guideline guideline)
        {
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
            return _context.Guidelines.ToList();
        }

        public IEnumerable<Guideline> GetGuidelinesByAuthor(string AuthorName)
        {
            return _context.Guidelines
                .Where(g => g.Author == AuthorName)
                .ToList();
        }
        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync(true)) > 0;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public Step GetStep(int id)
        {
            return _context.Steps.FirstOrDefault(s => s.Id == id);
        }

        public StepAction GetAction(int stepId, bool choice)
        {
            var decisions = _context.Decisions
                .Include(d => d.Step)
                .Include(d => d.Action)
                .Include(d => d.Action.NextStep);

            Decision decision = decisions.FirstOrDefault(d => d.Step.Id == stepId && d.Condition == choice);

            if (decision != null)
            {
                return decision.Action;
            }

            return null;
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

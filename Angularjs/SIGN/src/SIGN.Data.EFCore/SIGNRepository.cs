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
        private SIGNContext _context;
        private ILogger<SIGNRepository> _logger;

        public SIGNRepository(SIGNContext context, ILogger<SIGNRepository> logger)
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

        public void AddGuideline(Guideline guideline)
        {
            _context.Add(guideline);
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

        public async Task<bool> SaveChangesAsync()
        {
            return (await _context.SaveChangesAsync()) > 0;
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}

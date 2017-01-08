using Microsoft.EntityFrameworkCore;
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

        public SIGNRepository(SIGNContext context)
        {
            _context = context;
        }

        public void AddGuideline(Guideline guideline)
        {
            _context.Add(guideline);
            _context.SaveChanges();
        }

        public Guideline GetGuideline(int id)
        {
            return _context.Guidelines
                .Include(g => g.Assessments)
                .FirstOrDefault(g => g.Id == id);
        }

        public IEnumerable<Guideline> GetGuidelines()
        {
            return _context.Guidelines.ToList();
        }
    }
}

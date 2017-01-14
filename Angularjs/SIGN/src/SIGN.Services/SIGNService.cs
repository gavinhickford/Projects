using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIGN.Services
{
    public class SIGNService : ISIGNService
    {
        private ISIGNRepository _repository;

        public SIGNService(ISIGNRepository repository)
        {
            _repository = repository;
        }

        public Guideline GetGuideline(int id)
        {
            return _repository.GetGuideline(id);
        }

        public IEnumerable<Guideline> GetGuidelines()
        {
            return _repository.GetGuidelines();
        }

        public IEnumerable<Guideline> GetMyGuidelines(string authorName)
        {
            return _repository.GetGuidelinesByAuthor(authorName);
        }

        public async Task<bool> AddGuideline(Guideline guideline)
        {
            _repository.AddGuideline(guideline);
            return await _repository.SaveChangesAsync();
        }

        public Assessment GetAssessment(int id)
        {
            return _repository.GetAssessment(id);
        }

        public async Task<bool> AddAssessment(int guidelineId, Assessment assessment)
        {
            _repository.AddAssessment(guidelineId, assessment);
            return await _repository.SaveChangesAsync();
        }
    }
}

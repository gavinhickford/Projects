using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using System.Collections.Generic;

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
    }
}

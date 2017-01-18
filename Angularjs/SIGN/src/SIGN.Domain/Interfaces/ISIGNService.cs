using SIGN.Domain.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIGN.Domain.Interfaces
{
    public interface ISIGNService
    {
        IEnumerable<Guideline> GetGuidelines();
        IEnumerable<Guideline> GetMyGuidelines(string username);
        Guideline GetGuideline(int id);
        Task<bool> SaveGuideline(Guideline guideline);
        Assessment GetAssessment(int id);
        Task<bool> AddAssessment(int guidelineId, Assessment assessment);

    }
}

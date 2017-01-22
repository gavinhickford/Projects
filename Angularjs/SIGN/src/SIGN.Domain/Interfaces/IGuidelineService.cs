using SIGN.Domain.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SIGN.Domain.Interfaces
{
    public interface IGuidelineService
    {
        IEnumerable<Guideline> GetGuidelines();
        IEnumerable<Guideline> GetMyGuidelines(string username);
        Guideline GetGuideline(int id);
        Task<bool> SaveGuideline(Guideline guideline);
    }
}

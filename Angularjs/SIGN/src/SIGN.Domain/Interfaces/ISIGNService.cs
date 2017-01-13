using SIGN.Domain.Classes;
using System.Collections.Generic;

namespace SIGN.Domain.Interfaces
{
    public interface ISIGNService
    {
        IEnumerable<Guideline> GetGuidelines();

        IEnumerable<Guideline> GetMyGuidelines(string username);

        Guideline GetGuideline(int id);
    }
}

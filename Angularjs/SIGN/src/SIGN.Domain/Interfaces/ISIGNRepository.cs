using SIGN.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.Domain.Interfaces
{
    public interface ISIGNRepository
    {
        IEnumerable<Guideline> GetGuidelines();

        Guideline GetGuideline(int id);

        void AddGuideline(Guideline guideline);
    }
}

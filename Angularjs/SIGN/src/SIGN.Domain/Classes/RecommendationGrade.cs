using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.Domain.Classes
{
    public class RecommendationGrade : BaseEntity
    {
        public string Grade { get; set; }
        public string Text { get; set; }
    }
}

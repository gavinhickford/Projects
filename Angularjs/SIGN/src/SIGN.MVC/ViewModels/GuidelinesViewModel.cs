using SIGN.Domain.Classes;
using System.Collections.Generic;

namespace SIGN.MVC.ViewModels
{
    public class GuidelinesViewModel
    {
        public IEnumerable<Guideline> Guidelines { get; set; }
    }
}

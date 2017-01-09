using AutoMapper;
using SIGN.Domain.Classes;
using SIGN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SIGN.Tests.ViewModels
{
    public class GuildelineViewModelTests
    {
        [Fact]
        public void GuidelineViewModel_NameMissing_FailsValidation()
        {
            Guideline guideline = new Guideline
            {
                DatePublished = new DateTime(2000, 1, 1),
                Number = 110
            };
            
            GuidelineViewModel viewModel = Mapper.Map<GuidelineViewModel>(guideline);

            Assert.Equal(viewModel.Name, null);
        }
    }
}

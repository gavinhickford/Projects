using AutoMapper;
using AngularVM = SIGN.Angular.ViewModels;
using MVCVM = SIGN.MVC.ViewModels;
using SIGN.Domain.Classes;

namespace SIGN.Mocks
{
    public static class TestMappings
    {
        public static void Initialise()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<AngularVM.GuidelineViewModel, Guideline>().ReverseMap();
                config.CreateMap<MVCVM.GuidelineViewModel, Guideline>().ReverseMap();
            });
        }
    }
}

using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.MVC.ViewModels;

namespace SIGN.MVC.Controllers.Web
{
    public class GuidelineController : Controller
    {
        private ISIGNService _signService;

        public GuidelineController(ISIGNService signService)
        {
            _signService = signService;
        }

        [Authorize]
        public IActionResult AllGuidelines()
        {
            GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _signService.GetGuidelines();
            return View(model);
        }

        [Authorize]
        public IActionResult MyGuidelines()
        {
            GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _signService.GetMyGuidelines(User.Identity.Name);
            return View(model);
        }

        [Authorize]
        public IActionResult GuidelineDetails(int id)
        {
            Guideline guideline = _signService.GetGuideline(id);
            GuidelineViewModel model = Mapper.Map<GuidelineViewModel>(guideline);

            return View(model);
        }

        [Authorize]
        public IActionResult AddGuideline()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddGuideline(GuidelineViewModel newGuideline)
        {
            newGuideline.Author = User.Identity.Name;
            _signService.SaveGuideline(Mapper.Map<Guideline>(newGuideline));
            return View("Guidelines");
        }
    }
}

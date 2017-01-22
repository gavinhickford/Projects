using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.MVC.ViewModels;
using System.Threading.Tasks;

namespace SIGN.MVC.Controllers.Web
{
    public class GuidelineController : Controller
    {
        private IGuidelineService _guidelineService;

        public GuidelineController(IGuidelineService guidelineService)
        {
            _guidelineService = guidelineService;
        }

        [HttpGet, Authorize]
        public IActionResult AllGuidelines()
        {
            GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _guidelineService.GetGuidelines();
            return View(model);
        }

        [HttpGet, Authorize]
        public IActionResult MyGuidelines()
        {
            GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _guidelineService.GetMyGuidelines(User.Identity.Name);
            return View(model);
        }

        [HttpGet, Authorize]
        public IActionResult Details(int id)
        {
            Guideline guideline = _guidelineService.GetGuideline(id);
            GuidelineViewModel model = Mapper.Map<GuidelineViewModel>(guideline);
            return View(model);
        }

        [HttpGet, Authorize]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(GuidelineViewModel newGuideline)
        {
            if (ModelState.IsValid)
            {
                await _guidelineService.SaveGuideline(Mapper.Map<Guideline>(newGuideline));
                return RedirectToAction("AllGuidelines");
            }

            return View(newGuideline);
        }

        [HttpGet, Authorize]
        public IActionResult Edit(int id)
        {
            Guideline guideline = _guidelineService.GetGuideline(id);
            if (guideline == null)
            {
                return RedirectToAction("AllGuidelines");
            }

            GuidelineViewModel model = Mapper.Map<GuidelineViewModel>(guideline);
            return View(model);
        }

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public IActionResult Edit(GuidelineViewModel guideline)
        {
            if (ModelState.IsValid)
            {
                _guidelineService.SaveGuideline(Mapper.Map<Guideline>(guideline));
                return RedirectToAction("Details", new { id = guideline.Id });
            }

            return View(guideline);
        }
    }
}
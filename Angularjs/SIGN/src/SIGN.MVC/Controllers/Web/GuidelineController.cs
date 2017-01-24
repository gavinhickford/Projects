using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SIGN.Domain.Classes;
using SIGN.Domain.Interfaces;
using SIGN.MVC.ViewModels;
using System;
using System.Threading.Tasks;

namespace SIGN.MVC.Controllers.Web
{
    public class GuidelineController : Controller
    {
        private IGuidelineService _guidelineService;
        private ILogger<GuidelineController> _logger;

        public GuidelineController(
            IGuidelineService guidelineService,
            ILogger<GuidelineController> logger)
        {
            _guidelineService = guidelineService;
            _logger = logger;
        }

        [HttpGet, Authorize]
        public IActionResult AllGuidelines()
        {
            try
            {
                GuidelinesViewModel model = new GuidelinesViewModel();
                model.Guidelines = _guidelineService.GetGuidelines();
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the guidelines: {ex.Message}");
                return Redirect("/error");
            }
        }

        [HttpGet, Authorize]
        public IActionResult MyGuidelines()
        {
            try
            {
                GuidelinesViewModel model = new GuidelinesViewModel();
            model.Guidelines = _guidelineService.GetMyGuidelines(User.Identity.Name);
            return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the guidelines for author: {ex.Message}");
                return Redirect("/error");
            }
        }

        [HttpGet, Authorize]
        public IActionResult Details(int id)
        {
            try
            {
                Guideline guideline = _guidelineService.GetGuideline(id);
                GuidelineViewModel model = Mapper.Map<GuidelineViewModel>(guideline);
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the guideline details page: {ex.Message}");
                return Redirect("/error");
            }
        }

        [HttpGet, Authorize]
        public IActionResult Add()
        {
            try
            {
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the add guideline page: {ex.Message}");
                return Redirect("/error");
            }
        }

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(GuidelineViewModel newGuideline)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _guidelineService.SaveGuideline(Mapper.Map<Guideline>(newGuideline));
                    return RedirectToAction("AllGuidelines");
                }

                return View(newGuideline);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error saving the guideline: {ex.Message}");
                return Redirect("/error");
            }
        }

        [HttpGet, Authorize]
        public IActionResult Edit(int id)
        {
            try
            {
                Guideline guideline = _guidelineService.GetGuideline(id);
                if (guideline == null)
                {
                    return RedirectToAction("AllGuidelines");
                }

                GuidelineViewModel model = Mapper.Map<GuidelineViewModel>(guideline);
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error getting the edit guideline page: {ex.Message}");
                return Redirect("/error");
            }
        }

        [HttpPost, Authorize, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(GuidelineViewModel guideline)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    guideline.Author = User.Identity.Name;
                    await _guidelineService.SaveGuideline(Mapper.Map<Guideline>(guideline));
                    return RedirectToAction("AllGuidelines");
                }

                return View(guideline);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error saving the guideline: {ex.Message}");
                return Redirect("/error");
            }
        }
    }
}
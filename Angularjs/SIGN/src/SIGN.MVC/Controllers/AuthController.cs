using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIGN.Domain.Classes;
using SIGN.MVC.ViewModels;
using System.Threading.Tasks;

namespace SIGN.MVC.Controllers
{
    /// <summary>
    /// Controller to handle authentication
    /// </summary>
    public class AuthController  : Controller
    {
        private SignInManager<SIGNUser> _signInManager;

        public AuthController(SignInManager<SIGNUser> signInManager)
        {
            _signInManager = signInManager;
        }

        /// <summary>
        /// Login Action
        /// </summary>
        /// <returns>The Login View if not logged in</returns>
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Guidelines", "App");
            }

            return View();
        }

        /// <summary>
        /// Posts login details 
        /// </summary>
        /// <param name="viewModel">Login viewmodel</param>
        /// <param name="returnUrl">Url to redirect to when logged in</param>
        /// <returns>Redirects after login</returns>
        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel viewModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var signInResult = await _signInManager.PasswordSignInAsync(
                    userName: viewModel.Username,
                    password: viewModel.Password,
                    isPersistent: true,
                    lockoutOnFailure: false);

                if (signInResult.Succeeded)
                {
                    if (string.IsNullOrWhiteSpace(returnUrl))
                    {
                        return RedirectToAction("AllGuidelines", "Guideline");
                    }
                    else
                    {
                        Redirect(returnUrl);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Username or Password is incorrect");
                }
            }

            return View();
        }

        /// <summary>
        /// Logout action
        /// </summary>
        /// <returns>Redirect to Home page</returns>
        public async Task<IActionResult> Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await _signInManager.SignOutAsync();
            }

            return RedirectToAction("Index", "App");
        }
    }
}

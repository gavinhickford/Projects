﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SIGN.Domain.Classes;
using SIGN.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SIGN.Controllers
{
    public class AuthController  : Controller
    {
        private SignInManager<SIGNUser> _signInManager;

        public AuthController(SignInManager<SIGNUser> signInManager)
        {
            _signInManager = signInManager;
        }

        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Guidelines", "App");
            }

            return View();
        }

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
                        return RedirectToAction("Guidelines", "App");
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
    }
}

﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignalR.EntityLayer.Entities;
using SignalRWebUI.ViewModels.Dtos.IdentityDtos;

namespace SignalRWebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterDto registerDto)
        {
           var appUser =  new AppUser()
           {
               Ad = registerDto.Ad,
               Surname = registerDto.Surname,
               UserName = registerDto.Username,
               Email = registerDto.Mail
           };
            var result = await _userManager.CreateAsync(appUser, registerDto.Password);
            if (result.Succeeded) {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;

namespace WellBeingWorkout.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var userFound = await _userService.LoginUserAsync(user);
            return RedirectToAction("AllChallenges", "Challenge", new {userId = userFound});
        }

    }
}

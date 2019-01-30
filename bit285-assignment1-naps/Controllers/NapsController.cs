using System;
using System.Linq;
using bit285assignment1naps.Models;
using Microsoft.AspNetCore.Mvc;

namespace bit285assignment1naps.Controllers
{
    public class NapsController : Controller
    {
        Repository repository;

        //public NapsController (Repository repo)
        //{
        //    repository = repo;
        //}

        [HttpGet]
        public ViewResult AccountInfo()
        {
            return View("AccountInfo");
        }

        [HttpPost]
        public IActionResult AccountInfo(User user)
        {
            if (ModelState.IsValid)
            {
                return View("PasswordInfo", user);
            }
            else
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult PasswordInfo(User user)
        {
            //User newUser = new User
            //{
            //    FirstName = user.FirstName,
            //    LastName = user.LastName,
            //    Program = user.Program,
            //    BirthYear = user.BirthYear,
            //    Password = user.Password
            //};

            //if (ModelState.IsValid)
            //{
            return RedirectToAction("GeneratePassword", user);
            //}
            //else
            //{
            //    return View();
            //}


        }

        [HttpGet]
        public IActionResult GeneratePassword(User user)
        {
            PasswordSuggestionService pss = new PasswordSuggestionService();
            user.Password = pss.generatePassword(user);

            return View("SelectPasswords", user);
        }

        [HttpPost]
        public IActionResult SelectPassword(User user)
        {
            return View("ConfirmAccount", user);
        }

        [HttpPost]
        public IActionResult ConfirmAccount()
        {
            return View("Login");
        }
    }
}  
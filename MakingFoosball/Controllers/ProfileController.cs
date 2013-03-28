using System;
using System.Web.Security;
using DataAccess;
using DataAccess.Repositories;
using System.Web.Mvc;
using DataAccess.Repositories.Interfaces;
using System.Linq;
using MakingFoosball.Models;
using WebMatrix.WebData;

namespace MakingFoosball.Controllers
{
    public class ProfileController : Controller
    {
        private readonly IUserRepository _userRepo;

        public ProfileController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(User user)
        {
            if (FormsAuthentication.Authenticate(user.Username, user.Password))
                FormsAuthentication.RedirectFromLoginPage(user.Username, false);
            return View();
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterModel user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    WebSecurity.CreateAccount(user.UserName, user.Password);
                    WebSecurity.Login(user.UserName, user.Password);
                    return RedirectToAction("Index", "Home");
                }
                //TODO: Change Exception to MembershipCreateUserException
                catch (Exception)
                {
                    ModelState.AddModelError("", "User account couldn't be registered.");
                }   
            }

            return View(user);
        }
    }
}

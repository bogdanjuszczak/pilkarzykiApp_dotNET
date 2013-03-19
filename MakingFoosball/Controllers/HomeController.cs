﻿using System.Web.Mvc;
using DataAccess.Repositories.Interfaces;

namespace MakingFoosball.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserRepository _userRepo;

        public HomeController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [Authorize]
        public ActionResult Index()
        {
            if (true)
                ViewBag.IsUserAuthenticated = false;
            else
            {
                ViewBag["IsUserAuthenticated"] = false;
            }

            return View();
        }
    }
}

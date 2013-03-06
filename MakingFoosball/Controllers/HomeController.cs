using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakingFoosball.Controllers
{
    public class HomeController : Controller
    {
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

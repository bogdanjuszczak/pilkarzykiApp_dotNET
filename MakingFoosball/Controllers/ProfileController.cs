using MakingFoosball.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MakingFoosball.Controllers
{
    public class ProfileController : Controller
    {
        public ActionResult Create()
        {
            var p = new FoosballAppEntities().Users;
            return View();            
        }
    }
}

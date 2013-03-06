using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccess;
using DataAccess.Repositories;

namespace MakingFoosball.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            var p = new FoosballAppEntities().Users;
            var ur = new UsersRepository();
            //ur.CreateUser("abc2", "gffad");
            return View();            
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            //FoosballAppEntities
            var userRepo = new UsersRepository();
            userRepo.CreateUser(user);
            return Redirect("/");
        }
    }
}

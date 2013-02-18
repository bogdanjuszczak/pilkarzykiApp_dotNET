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
        public ActionResult Create()
        {
            var p = new FoosballAppEntities().Users;
            var ur = new UsersRepository();
            ur.CreateUser("abc2", "gffad");
            return View();            
        }
    }
}

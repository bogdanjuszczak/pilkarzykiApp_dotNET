using DataAccess;
using DataAccess.Repositories;
using System.Web.Mvc;

namespace MakingFoosball.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View();            
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            var userRepo = new UserRepository();
            //userRepo.CreateUser(user);
            return Redirect("/");
        }
    }
}

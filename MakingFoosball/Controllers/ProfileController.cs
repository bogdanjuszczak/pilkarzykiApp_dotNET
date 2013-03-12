using DataAccess;
using DataAccess.Repositories;
using System.Web.Mvc;

namespace MakingFoosball.Controllers
{
    public class ProfileController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();            
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            var userRepo = new UserRepository();
            //userRepo.CreateUser(user);
            return Redirect("/");
        }
    }
}

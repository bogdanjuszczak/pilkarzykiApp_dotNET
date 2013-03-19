using DataAccess;
using DataAccess.Repositories;
using System.Web.Mvc;
using DataAccess.Repositories.Interfaces;
using System.Linq;

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
        public ActionResult Register()
        {
            var p = _userRepo.GetAll();

            return View();            
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            var userRepo = new UserRepository();
            //userRepo.CreateUser(user);
            return Redirect("/UI/");
        }
    }
}

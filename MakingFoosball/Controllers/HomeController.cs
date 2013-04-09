using System.Web.Mvc;
using DataAccess.Helpers;
using DataAccess.Models;
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

        [HttpGet]
        public ActionResult Index()
        {
            var userModel = User.Identity.Name;
            return View();
        }

        [HttpPost]
        public void Index(LoginModel user)
        {
            LoginHelper.Login(user);
        }

        [ChildActionOnly]
        public ActionResult LoginRenderAction()
        {
            if (User.Identity.IsAuthenticated)
                return PartialView("_UserProfile");
            return PartialView("_LoginOrRegister");
        }
    }
}

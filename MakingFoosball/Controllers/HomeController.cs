using System.Web.Mvc;
using System.Web.Security;
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

        public ActionResult Index()
        {
            //if (User.Identity.IsAuthenticated)
            //    ViewBag.IsUserAuthenticated = false;
            //else
            //{
            //    ViewBag["IsUserAuthenticated"] = false;
            //}

            return View();
        }
    }
}

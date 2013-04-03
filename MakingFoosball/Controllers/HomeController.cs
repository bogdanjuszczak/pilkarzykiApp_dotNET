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



            var userModel = User.Identity.Name;
            //Membership.GetUser()
            //if (User.Identity.IsAuthenticated)
            //    ViewBag.User = User;
            //else
            //{
            //    ViewBag["IsUserAuthenticated"] = false;
            //}



            return View();
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

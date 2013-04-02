using DataAccess;
using DataAccess.Helpers;
using DataAccess.Models;
using DataAccess.Repositories.Interfaces;
using System.Web.Mvc;
using System.Web.Security;

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
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        //TODO: Change User to view-specific one
        public void LogIn(LoginModel user)
        {
            LoginHelper.Login(user);
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                MembershipCreateStatus createStatus;
                Membership.CreateUser(user.Username, user.Password, null, null, null, true, null, out createStatus);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    FormsAuthentication.SetAuthCookie(user.Username, false);
                    return RedirectToAction("Index", "Home");
                }
                //TODO: Handle errors
                //ModelState.AddModelError("", ErrorCodeToString(createStatus));
                ModelState.AddModelError("", "Something went wrong!");
            }

            // If we got this far, something failed, redisplay form
            return View(user);
        }
    }
}

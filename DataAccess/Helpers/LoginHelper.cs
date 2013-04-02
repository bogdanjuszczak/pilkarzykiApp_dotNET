using System.Web.Security;
using DataAccess.Models;

namespace DataAccess.Helpers
{
    public class LoginHelper
    {
        public static void Login(LoginModel user)
        {
            if (Membership.ValidateUser(user.UserName, user.Password))
            {
                FormsAuthentication.RedirectFromLoginPage(user.UserName, user.RememberMe);
            }
        }
    }
}
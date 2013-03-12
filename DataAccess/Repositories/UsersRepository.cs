using Common.Enums;
using DataAccess.Repositories.Interfaces;
using System.Linq;

namespace DataAccess.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public CreateUserStatus CreateUser(User user)
        {
            var _user = GetUserByUsername(user.Username);

            if (user != null)
                return CreateUserStatus.DuplicatedUsername;

            using (var ctx = new FoosballAppEntities())
            {
                ctx.Users.Add(new User() { Username = user.Username, Password = user.Password });
                ctx.SaveChanges();    
            }

            return CreateUserStatus.UserCreatedOK;
        }

        public User GetUserByUsername(string username)
        {
            using (var ctx = new FoosballAppEntities())
            {
                return ctx.Users.SingleOrDefault(u => u.Username == username);
            }
        }
    }
}

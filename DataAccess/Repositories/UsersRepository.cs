using Common.Enums;
using DataAccess.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public CreateUserStatus CreateUser(string username, string password)
        {
            var user = GetUserByUsername(username);

            if (user != null)
                return CreateUserStatus.DuplicatedUsername;

            using (var ctx = new FoosballAppEntities())
            {
                ctx.Users.Add(new User() { Username = username, Password = password });
                ctx.SaveChanges();    
            }

            return CreateUserStatus.UserCreatedOK;
        }

        private User GetUserByUsername(string username)
        {
            using (var ctx = new FoosballAppEntities())
            {
                return ctx.Users.SingleOrDefault(u => u.Username == username);
            }
        }
    }
}

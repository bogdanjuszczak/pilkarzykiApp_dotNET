using System.Linq;
using DataAccess.Repositories.Interfaces;

namespace DataAccess.Repositories
{
    public class UserRepository : GenericRepository<FoosballAppEntities, User>, IUserRepository
    {
        public User GetSingle(string userName)
        {
            return GetAll().SingleOrDefault(u => u.Username == userName);
        }
    }
}
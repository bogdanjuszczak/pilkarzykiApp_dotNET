using Common.Enums;

namespace DataAccess.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        CreateUserStatus CreateUser(User user);
        User GetUserByUsername(string username);
    }
}

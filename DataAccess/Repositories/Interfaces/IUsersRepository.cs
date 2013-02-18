using Common.Enums;

namespace DataAccess.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        CreateUserStatus CreateUser(string username, string password);
    }
}

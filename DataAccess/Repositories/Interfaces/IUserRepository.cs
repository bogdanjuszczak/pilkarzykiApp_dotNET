namespace DataAccess.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User>
    {
        User GetSingle(string userName);
    }
}
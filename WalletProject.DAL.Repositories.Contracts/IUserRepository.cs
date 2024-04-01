using WalletProject.Common.Entities.Users.DB;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<User> GetAsync(long id);

    }
}

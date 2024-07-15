using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Users.UserUpdateModels;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<User> GetAsync(string name);
        Task<User> GetUserAsync(Guid id);
        Task DeleteNameAsync(string name);
        Task DeleteIdAsync(Guid id);
        Task UpdateAsync(Guid id, UserUpdateModel userUpdate);
    }
}

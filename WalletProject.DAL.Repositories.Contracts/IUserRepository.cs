using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Users.UserUpdateModels;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<User> GetAsync(string  name);
        void Delete(string name);
        Task UpdateAsync(Guid id,UserUpdateModel userUpdate);
    }
}

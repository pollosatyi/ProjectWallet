using WalletProject.Common.Entities.Users.DB;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task CreateAsync(User user);
        Task<User> GetAsync(string  name);
        void Delete(string name);
        void Update(string name);
        Task UpdateAsync(Guid id,User userUpdate);
    }
}

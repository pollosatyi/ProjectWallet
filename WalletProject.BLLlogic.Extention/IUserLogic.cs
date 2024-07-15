using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Users.UserInputModels;
using WalletProject.Common.Entities.Users.UserUpdateModels;

namespace WalletProject.BLLlogic.Extention
{
    public interface IUserLogic
    {
        Task CreateAsync(UserInputModel userInputModel);

        Task<User> GetAsync(string name);

        Task<User> GetUserAsync(Guid id);

        Task DeleteNameAsync(string name);

        Task DeleteIdAsync(Guid id);

        Task UpdateAsync(Guid id, UserUpdateModel userUpdateModel);
    }
}

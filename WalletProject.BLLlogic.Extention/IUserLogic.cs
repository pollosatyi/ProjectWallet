using WalletProject.Common.Entities.Users.UserInputModels;

namespace WalletProject.BLLlogic.Extention
{
    public interface IUserLogic
    {
        Task CreateAsync(UserInputModel userInputModel);

        Task GetAsync(Guid id);
    }
}

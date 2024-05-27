using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IWalletRepository
    {
        Task CreateWalletDalAsync(Wallet wallet);
        Task<Wallet> GetWalletDalAsync(Guid id);
        Task UpdateBankAccountBalanceDalAsync(Guid idAccount,double balance);
    }
}

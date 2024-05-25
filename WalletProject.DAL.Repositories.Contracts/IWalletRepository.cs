using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IWalletRepository
    {
        Task CreateAsync(Wallet wallet);
        Task<Wallet> GetWalletAsync(Guid id);
        Task<Wallet> UpdateRepositoryAsync(Guid idWallet, Guid idAccount,WalletInputModel walletInputModel);
    }
}

using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IWalletRepository
    {
        Task CreateAsync(Wallet wallet);
    }
}

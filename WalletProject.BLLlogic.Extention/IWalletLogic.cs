using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;

namespace WalletProject.BLLlogic.Extention
{
    public interface IWalletLogic
    {
        Task CreateWalletBllAsync(WalletInputModel walletInputModel);
        Task<Wallet> GetAsync(Guid id);
        Task UpdateBankAccountBalanceBllAsync(Guid idAccount,double balance);
    }
}

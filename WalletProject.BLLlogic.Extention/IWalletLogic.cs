using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;

namespace WalletProject.BLLlogic.Extention
{
    public interface IWalletLogic
    {
        Task CreateAsync(WalletInputModel walletInputModel);
        Task<Wallet> GetAsync(Guid id);
        Task UpdateAsync(Guid idWallet,Guid idAccount,WalletInputModel walletInputModel);
    }
}

using WalletProject.Common.Entities.Wallets.WalletInputModels;

namespace WalletProject.BLLlogic.Extention
{
    public interface IWalletLogic
    {
         Task CreateAsync(WalletInputModel walletInputModel);
    }
}

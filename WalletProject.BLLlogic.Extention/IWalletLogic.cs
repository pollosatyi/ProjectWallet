using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;

namespace WalletProject.BLLlogic.Extention
{
    public interface IWalletLogic
    {
        Task CreateAsync(WalletInputModel walletInputModel);
        Task<List<BankAccount>> GetListBankAccountsAsync(Guid id);
        Task<Wallet> GetAsync(Guid id);
        Task Delete(Guid idWallet);
    }
}

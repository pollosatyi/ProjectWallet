using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IWalletRepository
    {
        Task CreateAsync(Wallet wallet);
        Task<Wallet> GetAsync(Guid id);
        Task<List<BankAccount>> GetListBankAccountsAsync(Guid id);
        Task Delete(Guid idWallet);
    }
}

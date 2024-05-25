using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.BLLLogic
{
    public class WalletLogic : IWalletLogic
    {
        private IWalletRepository _walletRepository;

        public WalletLogic(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task CreateAsync(WalletInputModel walletInputModel)
        {
            BankAccount bankAccount = new BankAccount()
            {
                Currency = walletInputModel.BankAccountModel.Currency,
                Balance=walletInputModel.BankAccountModel.Balance


            };
            Wallet wallet = new Wallet();
            wallet.Accounts.Add(bankAccount);
            


            
            await _walletRepository.CreateAsync(wallet);
        }

        public Task<Wallet> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}

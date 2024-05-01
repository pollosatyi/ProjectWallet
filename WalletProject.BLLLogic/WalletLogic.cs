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
            //BankAccount bankAccount = new BankAccount();
            //var AccountsInput = new List<BankAccount>();
            //AccountsInput.Add(bankAccount);
            Wallet wallet = new Wallet(walletInputModel.BankAccountModel.Currency,walletInputModel.BankAccountModel.Balance)
            {
                
              

                 
            };
            await _walletRepository.CreateAsync(wallet);
        }

    }
}

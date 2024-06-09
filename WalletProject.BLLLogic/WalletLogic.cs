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
            try
            {
                Wallet wallet = new Wallet() {
                    UserId = walletInputModel.UserId

                };
                await _walletRepository.CreateAsync(wallet);

            }
            catch (Exception ex)
            {
                Console.WriteLine("CreateWalletBllAsync не работает");
            }

        }

        public async Task Delete(Guid idWallet)
        {
            await _walletRepository.Delete(idWallet);
        }

        public async Task<Wallet> GetAsync(Guid id)
        {
           return await _walletRepository.GetAsync(id);
        }

        public async Task<List<BankAccount>> GetListBankAccountsAsync(Guid id)
        {
           return await _walletRepository.GetListBankAccountsAsync(id);    
        }

    }
}

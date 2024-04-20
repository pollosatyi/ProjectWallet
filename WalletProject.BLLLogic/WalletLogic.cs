using WalletProject.BLLlogic.Extention;
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
            Wallet wallet = new Wallet()
            {
                 
            };
            await _walletRepository.CreateAsync(wallet);
        }

    }
}

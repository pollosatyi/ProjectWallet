using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.DAL.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly DbContextWallet _dbContextWallet;

        public WalletRepository(DbContextWallet dbContextWallet)
        {
            _dbContextWallet = dbContextWallet;
        }

        public async Task CreateAsync(Wallet wallet)
        {
            try
            {
                await _dbContextWallet.wallets.AddAsync(wallet);
                await _dbContextWallet.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("WalletRepository не работает");
            }
        }
    }
}

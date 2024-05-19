using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.DAL.Repositories
{
    public class WalletRepository : IWalletRepository
    {
        private readonly DBContext _dbContext;

        public WalletRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(Wallet wallet)
        {
            try
            {
                await _dbContext.Wallets.AddAsync(wallet);
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("WalletRepository не работает");
            }
        }
    }
}

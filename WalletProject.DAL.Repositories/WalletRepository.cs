using Microsoft.EntityFrameworkCore;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;
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

        public async Task CreateWalletDalAsync(Wallet wallet)
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

        public async Task<Wallet> GetWalletDalAsync(Guid id)
        {
            try
            {
                return await _dbContext.Wallets.FirstOrDefaultAsync(x=>x.Id==id);

            }catch (Exception ex)
            {
                throw new Exception("кошелька с таким id нет");
            }

        }

        public async Task UpdateBankAccountBalanceDalAsync(Guid idAccount, double balance)
        {
            try
            {
                var newWallet = await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == idAccount);
                newWallet.Balance += balance;
                if(newWallet.Balance<0) { newWallet.Balance = 0; }
                
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("UpdateBankAccountBalanceDalAsync не работает");
            }
        }

        
    }
}

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

        public async Task<Wallet> GetWalletAsync(Guid id)
        {
            try
            {
                return await _dbContext.Wallets.FirstOrDefaultAsync(x=>x.Id==id);

            }catch (Exception ex)
            {
                throw new Exception("кошелька с таким id нет");
            }

        }

        public async Task UpdateRepositoryAsync(Guid idWallet,Guid idAccount, WalletInputModel walletInputModel)
        {
            try
            {
                


               var newWallet=  await _dbContext.Wallets.FirstOrDefaultAsync(x => x.Id == idWallet && x.Accounts.Where(y => y.Id == idAccount).Any());
                for (int i = 0; i < newWallet.Accounts.Count(); i++)
                {
                    if (newWallet.Accounts[i].Id == idAccount)
                    {
                        newWallet.Accounts[i].Balance += walletInputModel.BankAccountModel.Balance;
                        if (newWallet.Accounts[i].Balance < 0) { newWallet.Accounts[i].Balance = 0; }
                        break;
                    }

                }
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("UpdateRepository не работает");
            }
        }
    }
}

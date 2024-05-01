using Microsoft.EntityFrameworkCore;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.DAL.Repositories
{
    public class DbContextWallet : DbContext
    {
        public DbSet<Wallet> wallets { get; set; }
        public DbSet<BankAccount>bankAccounts { get; set; }
        public DbSet<BankAccountModel>bankAccountModels { get; set; }

        public DbContextWallet(DbContextOptions<DbContextWallet> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.DAL.Repositories.Configuration;

namespace WalletProject.DAL.Repositories
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Wallet>Wallets { get; set; }
        public DbSet<BankAccount> Accounts { get; set; }

       
        
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new WalletConfiguration());
            modelBuilder.ApplyConfiguration(new BankConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}

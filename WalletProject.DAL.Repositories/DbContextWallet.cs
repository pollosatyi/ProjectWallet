using Microsoft.EntityFrameworkCore;
using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.DAL.Repositories
{
    public class DbContextWallet : DbContext
    {
        public DbSet<Wallet> wallets {  get; set; }

        public DbContextWallet(DbContextOptions<DbContextWallet> options) : base(options) {
            Database.EnsureCreated();
        }
    }
}

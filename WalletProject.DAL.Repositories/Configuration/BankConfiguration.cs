using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.DAL.Repositories.Configuration
{
    public class BankConfiguration : IEntityTypeConfiguration<BankAccount>
    {
        

        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.HasKey(x=>x.Id);
            builder
                .HasOne(x => x.Wallet)
                .WithMany(x => x.Accounts).
                 HasForeignKey(y => y.WalletId); ;
        }
    }
}

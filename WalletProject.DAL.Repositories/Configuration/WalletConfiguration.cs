using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.DAL.Repositories.Configuration
{
    public class WalletConfiguration : IEntityTypeConfiguration<Wallet>
    {
        public void Configure(EntityTypeBuilder<Wallet> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasOne(x => x.User)
                .WithOne(y => y.Wallet)
                .HasForeignKey<Wallet>(x=>x.UserId);
            builder
                .HasMany(x => x.Accounts)
                .WithOne(x => x.Wallet);
        }


    }
}

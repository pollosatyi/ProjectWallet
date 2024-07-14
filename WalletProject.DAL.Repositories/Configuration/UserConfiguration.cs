using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.DAL.Repositories.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder
                .HasOne(x => x.Wallet)
                .WithOne(y => y.User)
                .HasForeignKey<User>(x=>x.WalletId);
        }

        
    }
}

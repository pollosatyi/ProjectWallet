using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IWalletRepository
    {
        Task CreateAsync(Wallet wallet);
    }
}

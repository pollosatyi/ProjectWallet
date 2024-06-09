using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;

namespace WalletProject.DAL.Repositories.Contracts
{
    public interface IBankAccountRepository
    {
        Task CreateAsync(BankAccount bankAccont);
        Task<BankAccount> GetAsync(Guid id);
        Task PutAsync(Guid id, double balance);
    }
}

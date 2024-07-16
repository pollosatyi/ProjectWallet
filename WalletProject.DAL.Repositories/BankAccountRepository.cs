using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.DAL.Repositories
{
    public class BankAccountRepository : IBankAccountRepository
    {
        private DBContext _dbContext;

        public BankAccountRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateAsync(BankAccount bankAccount)
        {
            try
            {
                _dbContext.Accounts.Add(bankAccount);
               // var wallet = _dbContext.Wallets.FirstOrDefaultAsync(x => x.Id == bankAccount.WalletId);
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                Console.WriteLine("BankAccountRepository не работает");
            }

        }

        public async Task<BankAccount> GetAsync(Guid id)
        {
           var bankAccount=new BankAccount();
            try
            {
               bankAccount=  await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == id);
                if (bankAccount == null)
                {
                    Console.WriteLine("счета с таким id нет");
                }
            } catch (Exception ex)
            {
                Console.WriteLine("GetAsync не работает");
            }
            return bankAccount;
        }

        public async Task PutAsync(Guid id, double balance)
        {
            try
            {
                var bankAccount = new BankAccount();
                bankAccount = await _dbContext.Accounts.FirstOrDefaultAsync(x => x.Id == id);
                if (bankAccount == null)
                {
                    Console.WriteLine("Такого счета нет");return;
                }
                bankAccount.Balance += balance;
                await _dbContext.SaveChangesAsync();

            } catch (Exception ex)
            {
                Console.WriteLine("PutAsync не работает");
            }

        }
    }
}

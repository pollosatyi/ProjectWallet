﻿using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
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
            await using var transaction = await _dbContext.Database.BeginTransactionAsync();
            try
            {
                var user = _dbContext.Users.FirstOrDefault(u => u.Id == wallet.UserId);

                if (user == null)
                {
                    throw new Exception("User not found");
                }
                if (user.WalletId!= Guid.Empty)
                {
                    throw new Exception("У этого пользователя есть кошелек");
                }
                await _dbContext.Wallets.AddAsync(wallet);
                await _dbContext.SaveChangesAsync();
                user.WalletId = wallet.Id;
                await _dbContext.SaveChangesAsync();

                await transaction.CommitAsync();

            }
            catch (Exception ex)
            {
                await transaction.RollbackAsync();
                throw new Exception("WalletRepository не работает");
            }
        }

       

        public async Task Delete(Guid idWallet)
        {
            try
            {
                var wallet = await _dbContext.Wallets.FirstOrDefaultAsync(x => x.Id == idWallet);
                var user=_dbContext.Users.FirstOrDefault(u => u.WalletId==idWallet);
                if (user != null)
                {
                    user.WalletId = Guid.Empty;
                }
                _dbContext.Wallets.Remove(wallet);
               
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Delete не работает");
            }
            
        }

        public async Task<Wallet> GetAsync(Guid id)
        {
            try
            {
                return await _dbContext.Wallets.FirstOrDefaultAsync(x => x.Id == id);
               // return  wallet;

            }
            catch (Exception ex)
            {
                throw new Exception("кошелька с таким id нет");
            }

        }

        public async Task<List<BankAccount>> GetListBankAccountsAsync(Guid id)
        {
            try
            {
                var list=new List<BankAccount>();
                var wallet= await _dbContext.Wallets.FirstOrDefaultAsync(x => x.Id == id);
                if (wallet == null)
                {
                    throw new Exception("кошелька с таким id нет");
                }
                foreach(var x in wallet.Accounts)
                {
                    list.Add(x);
                }
                return list;

            }
            catch (Exception ex)
            {
                throw new Exception("GetListBankAccountsAsync ошибка");
            }

        }
    }
}

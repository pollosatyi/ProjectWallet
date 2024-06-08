﻿using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.Common.Entities.Wallets.DbWallet;
using WalletProject.Common.Entities.Wallets.WalletInputModels;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.BLLLogic
{
    public class WalletLogic : IWalletLogic
    {
        private IWalletRepository _walletRepository;

        public WalletLogic(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public async Task CreateWalletBllAsync(WalletInputModel walletInputModel)
        {
            try
            {
                Wallet wallet = new Wallet() {
                    UserId = walletInputModel.UserId

                };
                await _walletRepository.CreateAsync(wallet);

            }
            catch (Exception ex)
            {
                Console.WriteLine("CreateWalletBllAsync не работает");
            }

        }

        public async Task DeleteWalletBll(Guid idWallet)
        {
            await _walletRepository.DeleteWalletDal(idWallet);
        }

        public async Task<Wallet> GetWalletBllAsync(Guid id)
        {
            var wallet = await _walletRepository.GetWalletDalAsync(id);
            return wallet;
            
        }

        public async Task UpdateBankAccountBalanceBllAsync(Guid idAccount, double balance)
        {
           await _walletRepository.UpdateBankAccountBalanceDalAsync(idAccount,balance);
        }
    }
}

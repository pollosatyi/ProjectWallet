using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.BLLLogic
{
    public class BankAccountLogic : IBankAccountLogic
    {
        private IBankAccountRepository _bankAccountRepository;
        private IWalletRepository _walletRepository;
        public BankAccountLogic(
            IBankAccountRepository bankAccountRepository,
            IWalletRepository walletRepository)
        {
            _bankAccountRepository = bankAccountRepository;
            _walletRepository = walletRepository;
        }

        public async Task CreateAsync(BankAccountModel bankAccountModel)
        {
            var wallet = await _walletRepository.GetWalletDalAsync(bankAccountModel.WalletId);

            if (wallet == null)
            {
                throw new Exception();
            }

            BankAccount bankAccount = new BankAccount()
            {
                Currency = bankAccountModel.Currency,
                Balance = bankAccountModel.Balance,
                WalletId = bankAccountModel.WalletId
            };

            await _bankAccountRepository.CreateAsync(bankAccount);


        }
    }
}

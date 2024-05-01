using WalletProject.Common.Entities.Enum;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;

namespace WalletProject.Common.Entities.Wallets.DbWallet
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public List<BankAccount> Accounts { get; set; }
        // public User User { get; set; }

        public Wallet(Currency currency=(Currency)1,double balance=0)
        {
            BankAccount bankAccount = new BankAccount(currency,balance)
            {
                Currency = (Currency)currency,
                Balance = balance
            };
            Accounts = new List<BankAccount>
            {
                bankAccount
            };
        }
    }
}

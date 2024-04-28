using WalletProject.Common.Entities.Enum;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;

namespace WalletProject.Common.Entities.Wallets.DbWallet
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public List<BankAccount> Accounts { get; set; }
        // public User User { get; set; }

        //public Wallet()
        //{
        //    BankAccount bankAccount = new BankAccount()
        //    {
        //        Currency = 0,
        //        Balance = 0
        //    };
        //    Accounts.Add(bankAccount);
        //}
    }
}

using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.Accounts;

namespace WalletProject.Common.Entities.Wallets.DbWallet
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public List<BankAccount> accounts { get; set; }

        

    }
}

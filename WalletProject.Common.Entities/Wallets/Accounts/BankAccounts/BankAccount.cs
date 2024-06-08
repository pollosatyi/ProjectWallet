using WalletProject.Common.Entities.Enum;
using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.Common.Entities.Wallets.Accounts.BankAccounts
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public CurrencyEnum Currency { get; set; }

        public double Balance { get; set; }

        public Guid WalletId { get; set; }
        public Wallet Wallet { get; set; }

    }


}

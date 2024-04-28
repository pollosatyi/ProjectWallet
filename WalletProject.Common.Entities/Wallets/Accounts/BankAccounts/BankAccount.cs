using WalletProject.Common.Entities.Enum;

namespace WalletProject.Common.Entities.Wallets.Accounts.BankAccounts
{
    public class BankAccount
    {
        public Guid Id { get; set; }
        public Currency Currency { get; set; }

        public double Balance { get; set; }

    }


}

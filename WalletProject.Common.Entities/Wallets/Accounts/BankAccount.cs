
using WalletProject.Common.Entities.Enum;

namespace WalletProject.Common.Entities.Wallets.Accounts
{
    public class BankAccount
    {
        public Currency currency {  get; set; }
        
        public double balance {  get; set; }
    }
}

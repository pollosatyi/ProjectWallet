
using WalletProject.Common.Entities.Enum;

namespace WalletProject.Common.Entities.Wallets.Accounts
{
    public class BankAccount
    {   public long Id {  get; set; }
        public Currency Currency {  get; set; }
        
        public double Balance {  get; set; }
    }
}

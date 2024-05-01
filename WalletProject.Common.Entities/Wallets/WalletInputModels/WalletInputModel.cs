using WalletProject.Common.Entities.Enum;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;


namespace WalletProject.Common.Entities.Wallets.WalletInputModels
{
    public class WalletInputModel
    {
        public BankAccountModel BankAccountModel { get; set; }

        public WalletInputModel(Currency currency=(Currency)1,double balance=0)
        {
            
        }
    }

}

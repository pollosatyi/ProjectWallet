using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletProject.Common.Entities.Enum;

namespace WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels
{
    public class BankAccountModel
    {
        
        public Currency Currency { get; set; }

        public double Balance { get; set; }

        public BankAccountModel(Currency currency=(Currency)1,double balance = 0)
        {
            Currency = currency;
            Balance = balance;
            
        }
    }
}

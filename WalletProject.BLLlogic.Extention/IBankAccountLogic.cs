using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;

namespace WalletProject.BLLlogic.Extention
{
    public interface IBankAccountLogic
    {
        Task CreateAsync(BankAccountModel bankAccountModel);
    }
}

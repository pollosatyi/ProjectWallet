﻿using WalletProject.Common.Entities.Enum;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccountModels;
using WalletProject.Common.Entities.Wallets.Accounts.BankAccounts;

namespace WalletProject.Common.Entities.Wallets.DbWallet
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public List<BankAccount> Accounts { get; set; } = new();
        public User User { get; set; }

        public Guid UserId { get; set; }



    }
}

using WalletProject.Common.Entities.Enum;
using WalletProject.Common.Entities.Wallets.DbWallet;

namespace WalletProject.Common.Entities.Users.DB
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Sex Sex { get; set; }
        public Wallet? Wallet { get; set; }
    }
}

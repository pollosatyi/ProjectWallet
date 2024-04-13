using WalletProject.Common.Entities.Users.DB;

namespace WalletProject.Common.Entities.Wallets.DbWallet
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public User user { get; set; }
        public List<BankA>

        //public double Rub { get; set; }
        //public double Usd { get; set; }
        //public double Eur { get; set; }
        //public double SumWallet { get; set; }

    }
}

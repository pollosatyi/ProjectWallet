namespace WalletProject.Common.Entities.Wallets.DbWallet
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public double Rub { get; set; }
        public double Usd { get; set; }
        public double Eur { get; set; }
        public double SumWallet { get; set; }

    }
}

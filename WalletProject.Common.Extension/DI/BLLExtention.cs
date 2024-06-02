using Microsoft.Extensions.DependencyInjection;
using WalletProject.BLLlogic.Extention;
using WalletProject.BLLLogic;
namespace WalletProject.Common.Extension.DI
{
    public static class BLLExtention
    {
        public static void ConfigureBll(this IServiceCollection services)
        {
            services.AddScoped<IUserLogic, UserLogic>();
            services.AddScoped<IBankAccountLogic, BankAccountLogic>();
            services.AddScoped<IWalletLogic, WalletLogic>();

        }

    }
}

using Microsoft.Extensions.DependencyInjection;
using WalletProject.BLLlogic.Extention;
using WalletProject.BLLLogic;
namespace WalletProject.Common.Extension.DI
{
    public static class BLLExtention
    {
        public static void ConfigureBllUser( this IServiceCollection services)
        {
            services.AddScoped<IUserLogic, UserLogic>();
        }

        public static void ConfigureBllWallet(this IServiceCollection services)
        {
            services.AddScoped<IWalletLogic, WalletLogic>();
        }

    }
}

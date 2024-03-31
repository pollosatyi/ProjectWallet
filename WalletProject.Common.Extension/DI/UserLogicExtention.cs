using Microsoft.Extensions.DependencyInjection;
using WalletProject.BLLlogic.Extention;
using WalletProject.BLLLogic;
namespace WalletProject.Common.Extension.DI
{
    public static class UserLogicExtention
    {
        public static IServiceCollection ConfigureBll( this IServiceCollection services)
        {
            return services.AddScoped<IUserLogic, UserLogic>();
        }
    }
}

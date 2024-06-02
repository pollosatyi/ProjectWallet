using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WalletProject.DAL.Repositories;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.Common.Extension.DI
{
    public static class DALExtension
    {
        public static void ConfigureDAL(this IServiceCollection services, IConfiguration configuration)
        {
            string connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DBContext>(options => options.UseNpgsql(connection));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<IBankAccountRepository, BankAccountRepository>();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WalletProject.DAL.Repositories;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.Common.Extension.DI
{
    public static class DALExtension
    {
        public static void ConfigureDllUser(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            string connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DBContext>(options => options.UseNpgsql(connection));

        }

        public static void ConfigureDllWallet(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IWalletRepository, WalletRepository>();
            string connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DbContext>(options => options.UseNpgsql(connection));

        }
    }
}

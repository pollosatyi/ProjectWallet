using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Protocols;
using WalletProject.DAL.Repositories;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.Common.Extension.DI
{
    public static class DALExtension
    {
        public static void ConfigureDll(this IServiceCollection services,IConfiguration configuration )
        {
            services.AddScoped<IUserRepository,UserRepository>();
            string connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DBContext>(options => options.UseNpgsql(connection));

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using WalletProject.DAL.Repositories;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.Common.Extension.DI
{
    public static class DALExtension
    {
        
        public static void ConfigureDAL(this IServiceCollection services, IConfiguration configuration)
        {
            //private StreamWriter logStream = new StreamWriter("DBlog.txt", true);

            string connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DBContext>(options => options.UseNpgsql(connection));
            services.AddDbContext<DBContext>(options => options.LogTo(Console.WriteLine,LogLevel.Warning));
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IWalletRepository, WalletRepository>();
            services.AddScoped<IBankAccountRepository, BankAccountRepository>();


        }

        //public  void LogDb(string message)
        //{


        //}


         
    }
}

using Microsoft.EntityFrameworkCore;
using WalletProject.Common.Entities.Users.DB;

namespace WalletProject.DAL.Repositories
{
    public class DBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

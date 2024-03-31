using WalletProject.Common.Entities.Users.DB;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContext _dbContext;

        public UserRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task CreateAsync(User user)
        {
            try
            {

            }catch (Exception ex)
            {

            }
        }
    }
}

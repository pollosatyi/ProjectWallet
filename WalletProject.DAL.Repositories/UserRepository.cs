using Microsoft.EntityFrameworkCore;
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
        public async Task CreateAsync(User user)
        {
            try
            {
                await _dbContext.Users.AddAsync(user);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("UserRepository CreateAsync не работает");
            }
        }

        public async Task<User> GetAsync(string name)
        {
            try
            {
                return await _dbContext.Users.FirstOrDefaultAsync(x => x.FirstName == name);
            }
            catch (Exception ex)
            {
                throw new Exception("пользователя с таким именем нет");
            }
        }

        public void Delete(string name)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(x => x.FirstName == name);
                _dbContext.Users.Remove(user);
                _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Пользователь не удален");
            }

        }

        public void Update(string name)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(x => x.FirstName == name);
                user.FirstName = "sdfsfds";
                _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Данные пользователя не обновились");
            }
        }
    }
}

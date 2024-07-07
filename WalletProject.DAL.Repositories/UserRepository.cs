using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Users.UserUpdateModels;
using WalletProject.DAL.Repositories.Contracts;


namespace WalletProject.DAL.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DBContext _dbContext;
        private readonly ILogger<UserRepository> _logger;

        public UserRepository(DBContext dbContext, ILogger<UserRepository> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
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
                _logger.LogCritical();
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

        public async Task Delete(string name)
        {
            try
            {
                var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.FirstName == name);
                _dbContext.Users.Remove(user);
                await _dbContext.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Пользователь не удален");
            }

        }

        public async Task UpdateAsync(Guid id, UserUpdateModel userUpdateModel)
        {
            try
            {
                var user = _dbContext.Users.FirstOrDefault(x => x.Id == id);
                user.FirstName = userUpdateModel.FirstName;
                user.LastName = userUpdateModel.LastName;
                user.MiddleName = userUpdateModel.MiddleName;
                user.Phone = userUpdateModel.Phone;
                user.Email = userUpdateModel.Email;

                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Данные пользователя не обновились");
            }
        }

        public async Task<User> GetUserAsync(Guid id)
        {
            return _dbContext.Users.FirstOrDefault(x => x.Id == id);
        }
    }
}

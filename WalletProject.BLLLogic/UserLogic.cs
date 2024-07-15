
using Microsoft.Extensions.Logging;
using System.Security.Cryptography;
using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Users.UserInputModels;
using WalletProject.Common.Entities.Users.UserUpdateModels;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.BLLLogic
{
    public class UserLogic : IUserLogic
    {
        private IUserRepository _userRepository;
        private readonly ILogger<UserLogic> _logger;

        public UserLogic(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task CreateAsync(UserInputModel userInputModel)
        {
            
            
                User user = new User()
                {
                    FirstName = userInputModel.FirstName,
                    LastName = userInputModel.LastName,
                    MiddleName = userInputModel.MiddleName,
                    Phone = userInputModel.Phone,
                    Age = userInputModel.Age,
                    Email = userInputModel.Email,
                    Sex = userInputModel.Sex,
                    Password = GetHashedPassword(userInputModel.Password)

                };
                await _userRepository.CreateAsync(user);

            
                
            
        }

        public async Task Delete(string name)
        {
            _userRepository.Delete(name);
        }

        public async Task<User> GetAsync(string name)
        {
            var user = await _userRepository.GetAsync(name);
            return user;
        }

        public async Task<User> GetUserAsync(Guid id)
        {
           var user= await _userRepository.GetUserAsync(id); 
            return user;
        }

        public async Task UpdateAsync(Guid id, UserUpdateModel userUpdateModel)
        {
            await _userRepository.UpdateAsync(id, userUpdateModel);
        }

        private string GetHashedPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("Пустое поле");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }

        public async Task DeleteIdAsync(Guid id)
        {
            await _userRepository.DeleteIdAsync(id);
        }
    }
}

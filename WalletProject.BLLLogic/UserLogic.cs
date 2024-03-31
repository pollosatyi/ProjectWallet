using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WalletProject.BLLlogic.Extention;
using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Users.UserInputModels;
using WalletProject.DAL.Repositories.Contracts;

namespace WalletProject.BLLLogic
{
    public class UserLogic : IUserLogic
    {
        private IUserRepository _userRepository;

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
                Password = GetHashedPassword(userInputModel.Password)

            };

        }

        private string GetHashedPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if(password == null)
            {
                throw new ArgumentNullException("Пустое поле");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password,0x10,0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt,0,dst,1,0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
    }
}

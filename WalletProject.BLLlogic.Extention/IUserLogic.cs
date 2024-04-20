﻿using WalletProject.Common.Entities.Users.DB;
using WalletProject.Common.Entities.Users.UserInputModels;
using WalletProject.Common.Entities.Users.UserUpdateModels;

namespace WalletProject.BLLlogic.Extention
{
    public interface IUserLogic
    {
        Task CreateAsync(UserInputModel userInputModel);

        Task<User> GetAsync(string name);

        void Delete(string name);

        Task UpdateAsync(Guid id, UserUpdateModel userUpdateModel);
    }
}

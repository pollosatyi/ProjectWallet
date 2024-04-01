﻿using Microsoft.EntityFrameworkCore;
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
            }catch (Exception ex)
            {
                throw new Exception("UserRepository CreateAsync не работает");
            }
        }

        public async Task<User>GetAsync(Guid id)
        {
            try
            {
                return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
            }
            catch (Exception ex)
            {
                throw new Exception("Некорретный номер");
            }
        }
    }
}

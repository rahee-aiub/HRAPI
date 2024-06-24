using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Repository
{
    public class LoginUserRepository : ILoginUserRepository
    {
        private readonly IAppDbContext _connection;

        public LoginUserRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<LoginUser> CreateAsync(LoginUser model)
        {
            await _connection.LoginUsers.AddAsync(model);
            await _connection.SaveChangesAsync();
            return model;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var data = await _connection.LoginUsers.FindAsync(id);
            if (data == null)
            {
                return 0;
            }

            _connection.LoginUsers.Remove(data);
            return await _connection.SaveChangesAsync();


        }

        public async Task<List<LoginUser>> GetAllAsync()
        {
            var list = await _connection.LoginUsers.ToListAsync();
            return list;
        }

        public async Task<LoginUser> GetByIdAsync(string username)
        {
            return await _connection.LoginUsers.FindAsync(username) ?? new LoginUser();
        }

        public async Task<int> UpDateAsync(int id, LoginUser model)
        {
            var existingData = await _connection.LoginUsers.FindAsync(id);
            if (existingData == null)
            {
                return 0;
            }
            existingData.PasswordHash = model.PasswordHash;
            existingData.PasswordSalt = model.PasswordSalt;
            existingData.UPDATE_BY = model.UPDATE_BY;
            existingData.UPDATE_DATE = model.UPDATE_DATE;

            _connection.LoginUsers.Update(existingData);
            return await _connection.SaveChangesAsync();
        }


       
    }
}

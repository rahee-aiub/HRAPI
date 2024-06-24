using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models;

namespace HR.ApplicationLayer.Services
{
    public class LoginUserService : ILoginUserService
    {

        private readonly ILoginUserRepository _repository;

        public LoginUserService(ILoginUserRepository repository)
        {
            _repository = repository;
        }

        public async Task<LoginUser> CreateAsync(LoginUser loginuser)
        {



            return await _repository.CreateAsync(loginuser);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<LoginUser>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<LoginUser> GetByIdAsync(string username)
        {
            return await _repository.GetByIdAsync(username);
        }

        public async Task<int> UpDateAsync(int id, LoginUser loginuser)
        {
            return await _repository.UpDateAsync(id, loginuser);
        }

    
    }
}

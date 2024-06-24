using HR.Domain.Models;

namespace HR.ApplicationLayer.IServices
{
    public interface ILoginUserService
    {
        Task<List<LoginUser>> GetAllAsync();
        Task<LoginUser> GetByIdAsync(string username);
        Task<LoginUser> CreateAsync(LoginUser loginuser);
        Task<int> UpDateAsync(int id, LoginUser loginuser);
        Task<int> DeleteAsync(int id);
     
    }
}

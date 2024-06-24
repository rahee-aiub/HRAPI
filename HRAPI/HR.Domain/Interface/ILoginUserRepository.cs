using HR.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface ILoginUserRepository
    {
        Task<List<LoginUser>> GetAllAsync();
        Task<LoginUser> GetByIdAsync(string username);
        Task<LoginUser> CreateAsync(LoginUser model);
        Task<int> UpDateAsync(int id, LoginUser model);
        Task<int> DeleteAsync(int id);
      
    }
}

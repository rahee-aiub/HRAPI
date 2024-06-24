using HR.Domain.Models.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface ICompanyRepository
    {
        Task<List<Company>> GetAllAsync();
        Task<Company> GetByIdAsync(int id);
        Task<Company> CreateAsync(Company model);
        Task<int> UpDateAsync(int id, Company model);
        Task<int> DeleteAsync(int id);
    }
}

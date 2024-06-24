using HR.Domain.Models.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface IEmployeeSetupRepository
    {
        Task<List<EmployeeSetup>> GetAllAsync();
        Task<EmployeeSetup> GetByIdAsync(int id);
        Task<EmployeeSetup> CreateAsync(EmployeeSetup employee);
        Task<int> UpDateAsync(int id, EmployeeSetup employee);
        Task<int> DeleteAsync(int id);
    }
}

using HR.Domain.Models.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllAsync();
        Task<Department> GetByIdAsync(int id);
        Task<Department> CreateAsync(Department model);
        Task<int> UpDateAsync(int id, Department model);
        Task<int> DeleteAsync(int id);
    }
}

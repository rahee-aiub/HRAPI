using HR.Domain.Models.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface IDesignationRepository
    {
        Task<List<Designation>> GetAllAsync();
        Task<Designation> GetByIdAsync(int id);
        Task<Designation> CreateAsync(Designation model);
        Task<int> UpDateAsync(int id, Designation model);
        Task<int> DeleteAsync(int id);
    }
}

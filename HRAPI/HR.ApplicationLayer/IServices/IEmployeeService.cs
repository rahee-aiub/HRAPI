using HR.ApplicationLayer.Dtos.Setup;
using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.IServices
{
    public interface IEmployeeService
    {
        Task<List<EmployeeRequest>> GetAllAsync();
        Task<EmployeeRequest> GetByIdAsync(int id);
        Task<EmployeeRequest> CreateAsync(EmployeeRequest employee);
        Task<int> UpDateAsync(int id, EmployeeRequest employee);
        Task<int> DeleteAsync(int id);
    }
}

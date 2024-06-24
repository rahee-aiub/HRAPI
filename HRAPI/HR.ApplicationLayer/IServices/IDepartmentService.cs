using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.IServices
{
    public interface IDepartmentService
    {
        Task<List<Department>> GetAllAsync();
        Task<Department> GetByIdAsync(int id);
        Task<Department> CreateAsync(Department department);
        Task<int> UpDateAsync(int id, Department department);
        Task<int> DeleteAsync(int id);
    }
}

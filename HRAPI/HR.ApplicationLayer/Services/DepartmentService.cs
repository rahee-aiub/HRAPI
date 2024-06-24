using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.Services
{
    public class DepartmentService : IDepartmentService
    {

        private readonly IDepartmentRepository _repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<Department> CreateAsync(Department department)
        {
            return await _repository.CreateAsync(department);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Department>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Department> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> UpDateAsync(int id, Department department)
        {
            return await _repository.UpDateAsync(id, department);
        }
    }
}

using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.Services
{
    public class DesignationService : IDesignationService
    {

        private readonly IDesignationRepository _repository;

        public DesignationService(IDesignationRepository repository)
        {
            _repository = repository;
        }

        public async Task<Designation> CreateAsync(Designation Designation)
        {
            return await _repository.CreateAsync(Designation);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Designation>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Designation> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> UpDateAsync(int id, Designation designation)
        {
            return await _repository.UpDateAsync(id, designation);
        }
    }
}

using HR.ApplicationLayer.IServices;
using HR.Domain.Interface;
using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.Services
{
    public class CompanyService : ICompanyService
    {

        private readonly ICompanyRepository _repository;

        public CompanyService(ICompanyRepository repository)
        {
            _repository = repository;
        }

        public async Task<Company> CreateAsync(Company company)
        {
            return await _repository.CreateAsync(company);
        }

        public async Task<int> DeleteAsync(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<List<Company>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<int> UpDateAsync(int id, Company company)
        {
            return await _repository.UpDateAsync(id, company);
        }
    }
}

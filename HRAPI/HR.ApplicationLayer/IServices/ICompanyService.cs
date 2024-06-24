using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.IServices
{
    public interface ICompanyService
    {
        Task<List<Company>> GetAllAsync();
        Task<Company> GetByIdAsync(int id);
        Task<Company> CreateAsync(Company company);
        Task<int> UpDateAsync(int id, Company company);
        Task<int> DeleteAsync(int id);
    }
}

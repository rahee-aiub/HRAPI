using HR.Domain.Models.Setup;

namespace HR.ApplicationLayer.IServices
{
    public interface IDesignationService
    {
        Task<List<Designation>> GetAllAsync();
        Task<Designation> GetByIdAsync(int id);
        Task<Designation> CreateAsync(Designation designation);
        Task<int> UpDateAsync(int id, Designation designation);
        Task<int> DeleteAsync(int id);
    }
}

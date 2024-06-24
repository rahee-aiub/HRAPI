using HR.ApplicationLayer.Dtos.Recruitment;
using HR.Domain.Models.Recruitment;

namespace HR.ApplicationLayer.IServices
{
    public interface IShortlistedCandidateService
    {
        Task<List<ShortlistedCandidateRequest>> GetAllAsync();
        Task<ShortlistedCandidateRequest> GetByIdAsync(int id);
        Task<ShortlistedCandidateRequest> CreateAsync(ShortlistedCandidateRequest model);
        Task<int> UpDateAsync(int id, ShortlistedCandidateRequest model);
        Task<int> DeleteAsync(int id);
    }
}

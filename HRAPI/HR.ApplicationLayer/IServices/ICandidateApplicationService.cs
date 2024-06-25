using HR.ApplicationLayer.Dtos.Recruitment;
using HR.Domain.Models.Recruitment;

namespace HR.ApplicationLayer.IServices
{
    public interface ICandidateApplicationService
    {
        Task<List<CandidateApplicationRequest>> GetAllAsync();
        Task<CandidateApplicationRequest> GetByIdAsync(int id);
        Task<List<CandidateApplicationRequest>> GetByRecruitmentIdAsync(int id);
        Task<CandidateApplicationRequest> CreateAsync(CandidateApplicationRequest model);
        Task<int> UpDateAsync(int id, CandidateApplicationRequest model);
        Task<int> DeleteAsync(int id);
    }
}

using HR.ApplicationLayer.Dtos.Recruitment;
using HR.Domain.Models.Recruitment;

namespace HR.ApplicationLayer.IServices
{
    public interface IRecruitmentCircularService
    {
        Task<List<RecruitmentCircularRequest>> GetAllAsync();
        Task<RecruitmentCircularRequest> GetByIdAsync(int id);
        Task<RecruitmentCircularRequest> CreateAsync(RecruitmentCircularRequest recruitmentcircular);
        Task<int> UpDateAsync(int id, RecruitmentCircularRequest recruitmentcircular);
        Task<int> DeleteAsync(int id);
    }
}

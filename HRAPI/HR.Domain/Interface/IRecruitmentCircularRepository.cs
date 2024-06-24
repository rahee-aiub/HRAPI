using HR.Domain.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface IRecruitmentCircularRepository
    {
        Task<List<RecruitmentCircular>> GetAllAsync();
        Task<RecruitmentCircular> GetByIdAsync(int id);
        Task<RecruitmentCircular> CreateAsync(RecruitmentCircular model);
        Task<int> UpDateAsync(int id, RecruitmentCircular model);
        Task<int> DeleteAsync(int id);
    }
}

using HR.Domain.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface ICandidateApplicationRepository
    {
        Task<List<CandidateApplication>> GetAllAsync();
        Task<CandidateApplication> GetByIdAsync(int id);
        Task<List<CandidateApplication>> GetByRecruitmentIdAsync(int id);
        Task<CandidateApplication> CreateAsync(CandidateApplication model);
        Task<int> UpDateAsync(int id, CandidateApplication model);
        Task<int> DeleteAsync(int id);
    }
}

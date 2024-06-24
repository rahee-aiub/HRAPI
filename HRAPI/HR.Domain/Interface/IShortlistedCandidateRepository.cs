using HR.Domain.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface IShortlistedCandidateRepository
    {
        Task<List<ShortlistedCandidate>> GetAllAsync();
        Task<ShortlistedCandidate> GetByIdAsync(int id);
        Task<ShortlistedCandidate> CreateAsync(ShortlistedCandidate model);
        Task<int> UpDateAsync(int id, ShortlistedCandidate model);
        Task<int> DeleteAsync(int id);
    }
}

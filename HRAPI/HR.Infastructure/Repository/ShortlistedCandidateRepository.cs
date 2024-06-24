using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Domain.Models.Recruitment;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Repository
{
    public class ShortlistedCandidateRepository : IShortlistedCandidateRepository
    {
        private readonly IAppDbContext _connection;

        public ShortlistedCandidateRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<ShortlistedCandidate> CreateAsync(ShortlistedCandidate model)
        {
            await _connection.ShortlistedCandidates.AddAsync(model);
            await _connection.SaveChangesAsync();
            return model;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var data = await _connection.ShortlistedCandidates.FindAsync(id);
            if (data == null)
            {
                return 0;
            }

            _connection.ShortlistedCandidates.Remove(data);
            return await _connection.SaveChangesAsync();
        }

        public async Task<List<ShortlistedCandidate>> GetAllAsync()
        {
            var list = await _connection.ShortlistedCandidates.ToListAsync();
            return list;
        }

        public async Task<ShortlistedCandidate> GetByIdAsync(int id)
        {
            return await _connection.ShortlistedCandidates.FindAsync(id) ?? new ShortlistedCandidate();
        }

        public async Task<int> UpDateAsync(int id, ShortlistedCandidate model)
        {
            var existingData = await _connection.ShortlistedCandidates.FindAsync(id);
            if (existingData == null)
            {
                return 0;
            }
 
            existingData.ApplicationId = model.ApplicationId;
            existingData.JobCircularId = model.JobCircularId;
            existingData.CandidateId = model.CandidateId;
            existingData.ShortlistDate = model.ShortlistDate;
            existingData.InterviewCallDate = model.InterviewCallDate;
            existingData.InterviewDate = model.InterviewDate;
            existingData.InterviewSchedule = model.InterviewSchedule;
            existingData.AssessmentScore = model.AssessmentScore;
            existingData.InterviewerComments = model.InterviewerComments;
            existingData.InterviewMarks = model.InterviewMarks;
            existingData.NextSteps = model.NextSteps;
            existingData.Status = model.Status;
            existingData.Remarks = model.Remarks;
            existingData.AdditionalInformation = model.AdditionalInformation;


            _connection.ShortlistedCandidates.Update(existingData);
            return await _connection.SaveChangesAsync();
        }
    }
}

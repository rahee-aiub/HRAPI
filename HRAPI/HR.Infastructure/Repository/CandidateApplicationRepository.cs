using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Domain.Models.Recruitment;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Repository
{
    public class CandidateApplicationRepository : ICandidateApplicationRepository
    {
        private readonly IAppDbContext _connection;

        public CandidateApplicationRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<CandidateApplication> CreateAsync(CandidateApplication model)
        {
            await _connection.CandidateApplications.AddAsync(model);
            await _connection.SaveChangesAsync();
            return model;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var data = await _connection.CandidateApplications.FindAsync(id);
            if (data == null)
            {
                return 0;
            }

            _connection.CandidateApplications.Remove(data);
            return await _connection.SaveChangesAsync();
        }

        public async Task<List<CandidateApplication>> GetAllAsync()
        {
            var list = await _connection.CandidateApplications.ToListAsync();
            return list;
        }

        public async Task<CandidateApplication> GetByIdAsync(int id)
        {
            return await _connection.CandidateApplications.FindAsync(id) ?? new CandidateApplication();
        }
        public async Task<List<CandidateApplication>> GetByRecruitmentIdAsync(int id)
        {
            return await _connection.CandidateApplications.Where(k=>k.RecruitmentCircularId == id).ToListAsync() ?? new List<CandidateApplication>();
        }
        public async Task<int> UpDateAsync(int id, CandidateApplication model)
        {
            var existingData = await _connection.CandidateApplications.FindAsync(id);
            if (existingData == null)
            {
                return 0;
            }

            existingData.ApplicationId = model.ApplicationId;
            existingData.RecruitmentCircularId = model.RecruitmentCircularId;
            existingData.CandidateId = model.CandidateId;
            existingData.CandidateName = model.CandidateName;
            existingData.CandidateEmail = model.CandidateEmail;
            existingData.CandidatePhone = model.CandidatePhone;
            existingData.ResumeLink = model.ResumeLink;
            existingData.CoverLetter = model.CoverLetter;
            existingData.Status = model.Status;
            existingData.Skills = model.Skills;
            existingData.Education = model.Education;
            existingData.CurrentEmployer = model.CurrentEmployer;
            existingData.CurrentJobTitle = model.CurrentJobTitle;
            existingData.LinkedinProfile = model.LinkedinProfile;
            existingData.PortfolioLink = model.PortfolioLink;
            existingData.References = model.References;
            existingData.ExperienceYears = model.ExperienceYears;
            existingData.ApplicationDate = model.ApplicationDate;
            existingData.AdditionalInformation = model.AdditionalInformation;

            _connection.CandidateApplications.Update(existingData);
            return await _connection.SaveChangesAsync();
        }
    }
}

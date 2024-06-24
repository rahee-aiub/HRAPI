using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Domain.Models.Recruitment;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Repository
{
    public class RecruitmentCircularRepository : IRecruitmentCircularRepository
    {
        private readonly IAppDbContext _connection;

        public RecruitmentCircularRepository(IAppDbContext connection)
        {
            _connection = connection;
        }

        public async Task<RecruitmentCircular> CreateAsync(RecruitmentCircular model)
        {
            await _connection.RecruitmentCirculars.AddAsync(model);
            await _connection.SaveChangesAsync();
            return model;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var data = await _connection.RecruitmentCirculars.FindAsync(id);
            if (data == null)
            {
                return 0;
            }

            _connection.RecruitmentCirculars.Remove(data);
            return await _connection.SaveChangesAsync();


        }

        public async Task<List<RecruitmentCircular>> GetAllAsync()
        {
            var list = await _connection.RecruitmentCirculars.ToListAsync();
            return list;
        }

        public async Task<RecruitmentCircular> GetByIdAsync(int id)
        {
            return await _connection.RecruitmentCirculars.FindAsync(id);
        }

        public async Task<int> UpDateAsync(int id, RecruitmentCircular model)
        {
            var existingData = await _connection.RecruitmentCirculars.FindAsync(id);
            if (existingData == null)
            {
                return 0;
            }

            existingData.RecruitmentCircularId = model.RecruitmentCircularId;
            existingData.Title = model.Title;
            existingData.CompanyId = model.CompanyId;
            existingData.DID = model.DID;
            existingData.DesignationId = model.DesignationId;
            existingData.NoOfVacancies = model.NoOfVacancies;
            existingData.PublishDate = model.PublishDate;
            existingData.StartDate = model.StartDate;
            existingData.ExpireDate = model.ExpireDate;
            existingData.JobTitle = model.JobTitle;
            existingData.JobDescription = model.JobDescription;
            existingData.JobResponsibilites = model.JobResponsibilites;
            existingData.JobEducationalRequirement = model.JobEducationalRequirement;
            existingData.JobBaseSkillRequirement = model.JobBaseSkillRequirement;
            existingData.JobAdditionalSkillRequirement = model.JobAdditionalSkillRequirement;
            existingData.JobSalaryRange = model.JobSalaryRange;
            existingData.JobApplicationProcess = model.JobApplicationProcess;
            existingData.JobExperienceMinYear = model.JobExperienceMinYear;
            existingData.JobExperienceMaxYear = model.JobExperienceMaxYear;
            existingData.CompanyName = model.CompanyName;
            existingData.CompanyDescription = model.CompanyDescription;
            existingData.JobType = model.JobType;
            existingData.JobLocation = model.JobLocation;
            existingData.Benefits = model.Benefits;
            existingData.ContactEmail = model.ContactEmail;
            existingData.ContactPhone = model.ContactPhone;
            existingData.HowToApply = model.HowToApply;
            existingData.Industry = model.Industry;
            existingData.EmploymentType = model.EmploymentType;
            existingData.WorkHours = model.WorkHours;
            existingData.CompanyWebsite = model.CompanyWebsite;
            existingData.LocationAddress = model.LocationAddress;
            existingData.AdditionalInformation = model.AdditionalInformation;
            existingData.isActive = model.isActive;

            _connection.RecruitmentCirculars.Update(existingData);
            return await _connection.SaveChangesAsync();
        }
    }
}

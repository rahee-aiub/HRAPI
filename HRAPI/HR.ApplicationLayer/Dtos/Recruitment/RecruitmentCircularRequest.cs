using AutoMapper;
using FluentValidation;
using HR.Domain.Models.Recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HR.ApplicationLayer.Dtos.Recruitment
{
    public record RecruitmentCircularRequest
    {
        public int RecruitmentCircularId { get; set; }
        public string? Title { get; set; } = string.Empty;
        public int CompanyId { get; set; } = 0;
        public int DID { get; set; } = 0;
        public int DesignationId { get; set; } = 0;
        public int NoOfVacancies { get; set; } = 0;
        public DateTime? PublishDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string JobTitle { get; set; } = string.Empty;
        public string JobDescription { get; set; } = string.Empty;
        public string JobResponsibilites { get; set; } = string.Empty;
        public string JobEducationalRequirement { get; set; } = string.Empty;
        public string JobBaseSkillRequirement { get; set; } = string.Empty;
        public string JobAdditionalSkillRequirement { get; set; } = string.Empty;
        public string JobSalaryRange { get; set; } = string.Empty;
        public string JobApplicationProcess { get; set; } = string.Empty;
        public int JobExperienceMinYear { get; set; } = 0;
        public int JobExperienceMaxYear { get; set; } = 0;

        public string CompanyName { get; set; } = string.Empty;
        public string CompanyDescription { get; set; } = string.Empty;
        public string JobType { get; set; } = string.Empty;
        public string JobLocation { get; set; } = string.Empty;
        public string Benefits { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string ContactPhone { get; set; } = string.Empty;
        public string HowToApply { get; set; } = string.Empty;
        public string Industry { get; set; } = string.Empty;
        public string EmploymentType { get; set; } = string.Empty;
        public string WorkHours { get; set; } = string.Empty;
        public string CompanyWebsite { get; set; } = string.Empty;
        public string LocationAddress { get; set; } = string.Empty;
        public string AdditionalInformation { get; set; } = string.Empty;

        public int? isActive { get; set; }
        private class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<RecruitmentCircular, RecruitmentCircularRequest>().ReverseMap();
            }
        }
    }
    public class CreateRecruitmentCircularValidator : AbstractValidator<RecruitmentCircularRequest>
    {
        public CreateRecruitmentCircularValidator()
        {
            RuleFor(v => v.RecruitmentCircularId).NotEmpty();
        }
    }
}

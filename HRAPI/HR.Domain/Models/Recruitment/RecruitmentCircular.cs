using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Models.Recruitment
{
    public class RecruitmentCircular : BaseModel
    {
        public int RecruitmentCircularId { get; set; }
        public string? Title { get; set; }
        public int? CompanyId { get; set; }
        public int? DID { get; set; }
        public int? DesignationId { get; set; }
        public int? NoOfVacancies { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? JobTitle { get; set; }
        public string? JobDescription { get; set; }
        public string? JobResponsibilites { get; set; }
        public string? JobEducationalRequirement { get; set; }
        public string? JobBaseSkillRequirement { get; set; }
        public string? JobAdditionalSkillRequirement { get; set; }
        public string? JobSalaryRange { get; set; }
        public string? JobApplicationProcess { get; set; }
        public int? JobExperienceMinYear { get; set; }
        public int? JobExperienceMaxYear { get; set; }

        public string? CompanyName { get; set; }
        public string? CompanyDescription { get; set; }
        public string? JobType { get; set; }
        public string? JobLocation { get; set; }
        public string? Benefits { get; set; }
        public string? ContactEmail { get; set; }
        public string? ContactPhone { get; set; }
        public string? HowToApply { get; set; }
        public string? Industry { get; set; }
        public string? EmploymentType { get; set; }
        public string? WorkHours { get; set; }
        public string? CompanyWebsite { get; set; }
        public string? LocationAddress { get; set; }
        public string? AdditionalInformation { get; set; }

        public int? isActive { get; set; }
    }
}

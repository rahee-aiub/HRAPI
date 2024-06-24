using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Models.Recruitment
{
    public class CandidateApplication
    {
        public int ApplicationId { get; set; }
        public int RecruitmentCircularId { get; set; }
        public int CandidateId { get; set; }
        public string CandidateName { get; set; } = string.Empty;
        public string CandidateEmail { get; set; } = string.Empty;
        public string CandidatePhone { get; set; } = string.Empty;
        public string ResumeLink { get; set; } = string.Empty;
        public string CoverLetter { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Skills { get; set; } = string.Empty;
        public string Education { get; set; } = string.Empty;
        public string CurrentEmployer { get; set; } = string.Empty;
        public string CurrentJobTitle { get; set; } = string.Empty;
        public string LinkedinProfile { get; set; } = string.Empty;
        public string PortfolioLink { get; set; } = string.Empty;
        public string References { get; set; } = string.Empty;
        public int ExperienceYears { get; set; }
        public decimal CurrentSalary { get; set; }
        public decimal ExpectedSalary { get; set; }
        public DateTime ApplicationDate { get; set; }
        public string AdditionalInformation { get; set; } = string.Empty;
    }
}

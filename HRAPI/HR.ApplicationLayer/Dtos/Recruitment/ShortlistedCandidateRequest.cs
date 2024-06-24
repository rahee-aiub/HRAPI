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
    public record ShortlistedCandidateRequest
    {
        public int ShortlistId { get; set; }
        public int ApplicationId { get; set; }
        public int JobCircularId { get; set; }
        public int CandidateId { get; set; }
        public DateTime ShortlistDate { get; set; }
        public DateTime InterviewCallDate { get; set; }
        public DateTime InterviewDate { get; set; }
        public string InterviewSchedule { get; set; } = string.Empty;
        public string AssessmentScore { get; set; } = string.Empty;
        public string InterviewerComments { get; set; } = string.Empty;
        public int InterviewMarks { get; set; }
        public string NextSteps { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public string AdditionalInformation { get; set; } = string.Empty;
        private class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<ShortlistedCandidate, ShortlistedCandidateRequest>().ReverseMap();
            }
        }
    }
    public class ShortlistedCandidateValidator : AbstractValidator<ShortlistedCandidateRequest>
    {
        public ShortlistedCandidateValidator()
        {
            RuleFor(v => v.ShortlistId).NotEmpty();
        }
    }
}

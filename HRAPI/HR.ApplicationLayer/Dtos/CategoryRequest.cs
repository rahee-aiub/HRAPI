using AutoMapper;
using FluentValidation;
using HR.Domain.Models.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HR.ApplicationLayer.Dtos
{
    public record CategoryRequest
    {
        public string CategoryName { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        private class Mapping : Profile
        {
            public Mapping()
            {
                CreateMap<Category, CategoryRequest>().ReverseMap();
            }
        }
    }
    public class CreateCategoryValidator : AbstractValidator<CategoryRequest>
    {
        public CreateCategoryValidator()
        {
            RuleFor(v => v.CategoryName)
                .MaximumLength(200)
                .NotEmpty();
        }
    }
}

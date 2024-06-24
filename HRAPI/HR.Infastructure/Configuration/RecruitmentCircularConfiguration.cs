using HR.Domain.Models.Recruitment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infastructure.Configuration
{
    internal class RecruitmentCircularConfiguration : IEntityTypeConfiguration<RecruitmentCircular>
    {
        public void Configure(EntityTypeBuilder<RecruitmentCircular> builder)
        {
            builder.ToTable("RecruitmentCircular");

            builder.HasKey(k=>k.RecruitmentCircularId);          
            
            builder.Property(t => t.RecruitmentCircularId).ValueGeneratedOnAdd();

        }
    }
}

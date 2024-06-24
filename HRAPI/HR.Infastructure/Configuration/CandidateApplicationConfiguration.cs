using HR.Domain.Models.Recruitment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infastructure.Configuration
{
    internal class CandidateApplicationConfiguration : IEntityTypeConfiguration<CandidateApplication>
    {
        public void Configure(EntityTypeBuilder<CandidateApplication> builder)
        {
            builder.ToTable("CandidateApplication");

            builder.HasKey(k=>k.ApplicationId);          
            
            builder.Property(t => t.ApplicationId).ValueGeneratedOnAdd();

        }
    }
}

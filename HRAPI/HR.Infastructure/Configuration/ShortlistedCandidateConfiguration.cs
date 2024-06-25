using HR.Domain.Models.Recruitment;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infastructure.Configuration
{
    internal class ShortlistedCandidateConfiguration : IEntityTypeConfiguration<ShortlistedCandidate>
    {
        public void Configure(EntityTypeBuilder<ShortlistedCandidate> builder)
        {
            builder.ToTable("ShortlistedCandidate");

            builder.HasKey(k=>k.ShortlistId);          
            
            builder.Property(t => t.ShortlistId).ValueGeneratedOnAdd();

        }
    }
}

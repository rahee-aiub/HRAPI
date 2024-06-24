using HR.Domain.Models.Setup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infastructure.Configuration
{
    internal class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.ToTable("Company");
            builder.HasKey(k=>k.CompanyId);
            
            builder.Property(t => t.CompanyId).ValueGeneratedOnAdd();


        }
    }
}

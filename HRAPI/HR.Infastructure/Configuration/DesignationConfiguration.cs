using HR.Domain.Models.Setup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infastructure.Configuration
{
    internal class DesignationConfiguration : IEntityTypeConfiguration<Designation>
    {
        public void Configure(EntityTypeBuilder<Designation> builder)
        {
            builder.ToTable("Designation");
            builder.HasKey(k=>k.DesignationId);
            
            builder.Property(t => t.DesignationId).ValueGeneratedOnAdd();

            builder.Property(t => t.DesignationName).HasMaxLength(100).IsRequired();


        }
    }
}

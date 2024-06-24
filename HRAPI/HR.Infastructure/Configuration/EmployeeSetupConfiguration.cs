using HR.Domain.Models.Setup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infastructure.Configuration
{
    internal class EmployeeSetupConfiguration : IEntityTypeConfiguration<EmployeeSetup>
    {
        public void Configure(EntityTypeBuilder<EmployeeSetup> builder)
        {
            builder.ToTable("EMPLOYEE_SETUP");
            builder.HasKey(k=>k.EID);            
            builder.Property(t => t.EID).ValueGeneratedOnAdd();
        }
    }
}

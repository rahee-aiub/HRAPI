using HR.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infastructure.Configuration
{
    internal class LoginUserConfiguration : IEntityTypeConfiguration<LoginUser>
    {
        public void Configure(EntityTypeBuilder<LoginUser> builder)
        {
            builder.ToTable("LoginUser");
            builder.HasKey(k=>k.Username);
        }
    }
}

using HR.Domain.Models.Setup;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HR.Infastructure.Configuration
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(k=>k.CategoryId);
            
            builder.Property(t => t.CategoryId).ValueGeneratedOnAdd();
            builder.Property(t => t.CategoryName).HasMaxLength(200);

        }
    }
}

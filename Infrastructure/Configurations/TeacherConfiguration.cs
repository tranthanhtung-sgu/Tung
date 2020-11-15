using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Models;

namespace Infrastructure.Configuration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.ToTable("Teachers");
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.description).IsRequired(false);
            builder.Property(x=>x.photo).IsRequired();
            builder.Property(x=>x.firstName).IsRequired();
            builder.Property(x=>x.lastName).IsRequired();
            builder.Property(x=>x.email).IsRequired();
            builder.Property(x=>x.phone).IsRequired();
        }
    }
}
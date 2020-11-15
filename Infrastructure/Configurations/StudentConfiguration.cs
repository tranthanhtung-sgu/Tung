using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Models;

namespace Infrastructure.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(x=>x.Id);
            builder.Property(x=>x.dob).IsRequired();
            builder.Property(x=>x.Address).IsRequired(false);
            builder.Property(x=>x.firstName).IsRequired();
            builder.Property(x=>x.lastName).IsRequired();
            builder.Property(x=>x.email).IsRequired();
            builder.Property(x=>x.phone).IsRequired();
            builder.Property(x=>x.password).IsRequired();

        }
    }
}
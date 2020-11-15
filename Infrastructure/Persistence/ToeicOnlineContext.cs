using Microsoft.EntityFrameworkCore;
using Infrastructure.Configuration;
using Domain.Models;
using Infrastructure.Persistence.Extensions;

namespace Infrastructure.Persistence
{
    public class ToeicOnlineContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new StudentInClassConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new LevelConfiguration());
            

            // modelBuilder.Seed();
            //base.OnModelCreating(modelBuilder);
        }
        public ToeicOnlineContext (DbContextOptions<ToeicOnlineContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Level> Level { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Teacher> Teacher { get; set; }

    }
}
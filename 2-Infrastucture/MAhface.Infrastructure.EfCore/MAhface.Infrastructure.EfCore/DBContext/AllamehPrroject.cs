using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core.Entities.Study.Sections;
using MAhface.Domain.Core.Entities;
using MAhface.Infrastructure.EfCore.Configurations;

namespace MAhface.Infrastructure.EfCore.DBContext
{
    public class AllamehPrroject : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public AllamehPrroject(DbContextOptions<AllamehPrroject> options)
            : base(options)
        {
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Seasons> Seasons { get; set; }
        public DbSet<Sections> Sections { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<View> Views { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new SectionConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.IsSubclassOf(typeof(BaseEntity)))
                {
                    modelBuilder.Entity(entityType.Name).Property<int>("Code").ValueGeneratedOnAdd();
                }
            }
        }
    }
}

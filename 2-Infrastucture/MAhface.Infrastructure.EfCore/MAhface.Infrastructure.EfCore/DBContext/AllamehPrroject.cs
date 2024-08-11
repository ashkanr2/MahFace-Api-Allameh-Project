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
using MAhface.Domain.Core1.Entities;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;

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
        public DbSet<Image> Images { get; set; }
        public DbSet<View> Views { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseSqlServer(" Data Source=win1.hadaf.host\\MSSQLSERVER2019;Initial Catalog=mahface2_AllamehProject; User Id=mahface2_mahface2; password=wX8eP84hFw@%8W; TrustServerCertificate=True;Integrated Security=false;");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new SectionConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new ErrorLogConfiguration());

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

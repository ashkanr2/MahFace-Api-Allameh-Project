using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;

using MAhface.Domain.Core.Entities;
using MAhface.Infrastructure.EfCore.Configurations;
using MAhface.Domain.Core1.Entities;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;
using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Entities.Study.Episode;
using MAhface.Domain.Core1.Entities.Study.Course;

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
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<View> Views { get; set; }
        public DbSet<ErrorLog> ErrorLogs { get; set; }
        public DbSet<EmailSetting> EmailSetting { get; set; }
        public DbSet<Comment>Comments { get; set; }
        public DbSet<EmailLog> EmailLog { get; set; }
        public DbSet<StudentFavoriteCourses> StudentFavoriteCourses { get; set; }

        public DbSet<StudentCourses>StudentCourses { get; set; }
        public DbSet<Otp> Otps { get; set; }

        public DbSet<TeacherRequests> TeacherRequests { get; set; }


//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        //=> optionsBuilder.UseSqlServer(" Data Source=win1.hadaf.host\\MSSQLSERVER2019;Initial Catalog=mahface2_AllamehProject2; User Id=mahface2_mahface2; password=wX8eP84hFw@%8W; TrustServerCertificate=True;Integrated Security=false;");
//        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-NSLM4VO\\ASHKANPC;Initial Catalog=mahface2_AllamehProject2;TrustServerCertificate=True;Integrated Security=True;");


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new SectionConfiguration());
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new ErrorLogConfiguration());

          modelBuilder.Entity<User>().HasData(SeedData.SeedData.GetUsers().ToArray());
          //modelBuilder.Entity<Category>().HasData(SeedData.SeedData.GetCategories().ToArray());
          //modelBuilder.Entity<Teacher>().HasData(SeedData.SeedData.GetTeachers().ToArray());
          //modelBuilder.Entity<Courses>().HasData(SeedData.SeedData.GetCourses().ToArray());
           

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (entityType.ClrType.IsSubclassOf(typeof(BaseEntity)))
                {
                    modelBuilder.Entity(entityType.Name).Property<int>("Code").ValueGeneratedOnAdd();
                }
            }
            modelBuilder.Entity<EmailSetting>().HasData(new EmailSetting
            {
                Id = Guid.Parse("D4819E1B-3DAB-4D13-9EE5-DFB6C2AEE0FF"), // یک GUID ثابت وارد کنید
                EmailAddress = "mahface@ashkanrazavi.ir",
                Password = "Ashkan12345678",
                SMTPHost = "mail.ashkanrazavi.ir",
                SMTPPort = 587
            });

        }
    }
}

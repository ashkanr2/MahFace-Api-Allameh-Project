using MAhface.Domain.Core.Entities;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core.Entities.Study.Sections;
using MAhface.Infrastructure.EfCore.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.DBContext
{
    public class AllamehPrroject : IdentityDbContext<User, IdentityRole<Guid>, Guid>
    {
        public AllamehPrroject()
        {

        }
        public AllamehPrroject(DbContextOptions<AllamehPrroject> options)
            : base(options)
        {
        }

        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Courses> Courses { get; set; }
        public virtual DbSet<Seasons> Seasons { get; set; }
        public virtual DbSet<Sections> sections { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<View> Views { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseSqlServer(" Data Source=win1.hadaf.host\\MSSQLSERVER2019;Initial Catalog=mahfacea_db; User Id=mahfacea_sa; password=3zlq11G9rTw#wwQa; TrustServerCertificate=True;Integrated Security=false;");

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
                    //  modelBuilder.Entity(entityType.Name).Property<Guid>("").HasDefaultValue("");

                }
            }

        }


    }
}

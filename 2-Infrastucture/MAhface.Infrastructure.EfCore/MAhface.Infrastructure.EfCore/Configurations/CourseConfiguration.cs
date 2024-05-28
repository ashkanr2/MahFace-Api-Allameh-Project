using MAhface.Domain.Core.Entities.Study.Course;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(c => c.TeacherId).IsRequired(false);
            builder.Property(c => c.CourseLevelId).IsRequired(false);
            builder.Property(c => c.CategoryId).IsRequired(true);
            builder.Property(c => c.CourseDescription).IsRequired(true);
            builder.Property(c => c.Title).IsRequired(true);
            builder.Property(c => c.ImageUrl).IsRequired(false);
            builder.HasOne(c => c.Image)
          .WithOne()
          .HasForeignKey<Courses>(c => c.ImageId)
          .IsRequired(false); // Set it as not required
        }
    }
}

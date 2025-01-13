using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Section;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Configurations
{
    public class SectionConfiguration : IEntityTypeConfiguration<Sections>
    {
        public void Configure(EntityTypeBuilder<Sections> builder)
        {
            //// تنظیم کلید اصلی برای Section
            //builder.HasKey(x => x.Id);

            //// مشخص کردن اینکه CourseId همیشه باید مقدار داشته باشد
            //builder.Property(s => s.CourseId)
            //    .IsRequired();

            //// مشخص کردن اینکه SeasonId همیشه باید مقدار داشته باشد
            //builder.Property(s => s.Seasonn)
            //    .IsRequired();

            //// مشخص کردن اینکه Title می‌تواند مقدار نداشته باشد (در صورت نیاز)
            //builder.Property(s => s.Title)
            //    .HasMaxLength(255)  // حداکثر طول عنوان
            //    .IsRequired(false);

            //// مشخص کردن اینکه URL همیشه باید مقدار داشته باشد
            //builder.Property(s => s.URL)
            //    .IsRequired();

            //// مشخص کردن اینکه HashUrl می‌تواند مقدار نداشته باشد (اختیاری)
            //builder.Property(s => s.HashUrl)
            //    .IsRequired(false);

            //// مشخص کردن اینکه Description می‌تواند مقدار نداشته باشد (اختیاری)
            //builder.Property(s => s.Description)
            //    .IsRequired(false);

            //// تنظیم رابطه با جدول Season
            //builder.HasOne(s => s.Seasonn)
            //    .WithMany(season => season.Sectionss)
            //    .HasForeignKey(s => s.SeasionnId)  // تنظیم Foreign Key
            //    .OnDelete(DeleteBehavior.Restrict);  // تنظیم رفتار حذف (در صورت نیاز)

            //// تنظیم سایر ویژگی‌ها
            //builder.Property(s => s.CreatedDate)
            //    .IsRequired();  // ایجاد تاریخ باید همیشه مقدار داشته باشد

            //builder.Property(s => s.ISActive)
            //    .IsRequired();  // وضعیت فعال بودن باید همیشه مقدار داشته باشد
        }
    }
}

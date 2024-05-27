using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            //builder.HasData(new List<User>()
            //{
            //    new User()
            //    {
            //        Id = new Guid("50f3f4a6-32f0-49f7-a829-8ec259a56da6"),
            //        UserName = "Admin",
            //        IsSystemAccount = true,
            //        Email="admin@admin.com"


            //    }
            //});

            builder.HasKey(x => x.Id);



        }
    }
}

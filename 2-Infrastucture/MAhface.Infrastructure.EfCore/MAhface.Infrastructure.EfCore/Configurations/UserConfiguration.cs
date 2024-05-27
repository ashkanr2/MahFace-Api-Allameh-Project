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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Check if there are no users with IsSystemAccount = true
            if (!builder.Metadata.GetProperties().Any(p => p.Name == "IsSystemAccount"))
            {
                builder.HasData(new List<User>()
                {
                    new User()
                    {
                        Id = new Guid("50f3f4a6-32f0-49f7-a829-8ec259a56da6"),
                        UserName = "Admin",
                        IsSystemAccount = true,
                        Email = "admin@admin.com"
                        //password=admin
                    }
                });
            }

            builder.HasKey(x => x.Id);
            builder.Property(x => x.IsStudent).HasDefaultValue(true);
        }
    }
}

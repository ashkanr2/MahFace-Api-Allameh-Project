using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Configurations
{

    public class ErrorLogConfiguration : IEntityTypeConfiguration<ErrorLog>
    {

        public void Configure(EntityTypeBuilder<ErrorLog> entity)
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CreatedAt).IsRequired();
            entity.Property(e => e.Entityname).IsRequired(false);
            entity.Property(e => e.ActionType).IsRequired(false);
            entity.Property(e => e.ActionName).IsRequired(false);
            entity.Property(e => e.UserId).IsRequired(false);
            entity.Property(e => e.Exeption).IsRequired();
        }
    }
}

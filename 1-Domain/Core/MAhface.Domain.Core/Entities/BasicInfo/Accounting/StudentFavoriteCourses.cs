using MAhface.Domain.Core.Entities;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities.BasicInfo.Accounting
{
    [Table("StudentFavoriteCourses", Schema = "Study")]
    public class StudentFavoriteCourses:BaseEntity
    {
        public Guid Id { get; set; }

        public Courses Course { get; set; }
        public Guid CourseId { get; set; }

        public User User { get; set; }
        public Guid UserId { get; set; }
    }
}

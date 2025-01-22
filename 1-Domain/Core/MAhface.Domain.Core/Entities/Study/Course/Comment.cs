using MAhface.Domain.Core.Entities;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities.Study.Course
{
    public class Comment:BaseEntity
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Text { get; set; }

        public User  user { get; set; }
        public Guid UserId { get; set; }

        public Guid CourseId { get; set; }

        public Courses course { get; set; }
    }
}

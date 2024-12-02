using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class AddCourseVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int? CourseLevelId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid CategoryId { get; set; }
        public string CourseDescription { get; set; }
        public decimal Cost { get; set; }
        public string? ImageBase64 { get; set; }
    }

}

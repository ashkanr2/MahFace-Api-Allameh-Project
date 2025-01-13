using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class CourseVm
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int? CourseLevelId { get; set; }
        public Guid TeacherId { get; set; }
        public string TeacherName { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public decimal Cost { get; set; }
        public int TotalSeasons { get; set; }
        public int TotalSections { get; set; }
        public int TotalDuration { get; set; }
        public int StarsNumber { get; set; }
        public int TotalView { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CourseDescription { get; set; }
        public string Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageBase64 { get; set; }

    }


}

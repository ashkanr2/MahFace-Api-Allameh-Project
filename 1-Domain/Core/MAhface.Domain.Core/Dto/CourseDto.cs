using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MAhface.Domain.Core1.Dto;

namespace MAhface.Domain.Core.Dto
{
    public class CourseDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int? CourseLevelId { get; set; }
        public Guid TeacherId { get; set; }
        public Guid CategoryId { get; set; }
        public string CourseDescription { get; set; }
        public decimal Cost { get; set; }
        public int StarsNumber { get; set; }
        public ImageDto? ImageDto { get; set; }

        public int TotalSeasons { get; set; }
        public int TotalSections { get; set; }
        public int TotalDuration { get; set; }

        public string TeacherName { get; set; }
    }

}

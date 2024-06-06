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

        [MaxLength(30)]
        [DefaultValue(null)]
        [Required]
        public string Title { get; set; }

        [Required]
        public int? CourseLevelId { get; set; }

        [Required]
        public Guid? TeacherId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public string CourseDescription { get; set; }



        [DefaultValue(0)]
        public decimal Cost { get; set; }


        public List<StudentDto> Students { get; set; }

        public TeacherDto Teacher { get; set; }


        public CategoryDto category { get; set; }


        public ImageDto ImageDto { get; set; }
        public List<SeasonsDto> Seasons { get; set; }
    }
}

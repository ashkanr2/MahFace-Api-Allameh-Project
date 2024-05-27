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

namespace MAhface.Domain.Core.Dto
{
    public class CourseDto 
    {
         
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
        [AllowNull]
        public string ImageUrl { get; set; }

        //public Guid ImageId { get; set; }
        [DefaultValue(0)]
        public decimal Cost { get; set; }


        public List<StudentDto> Students { get; set; }

        public TeacherDto Teacher { get; set; }


        public CategoryDto category { get; set; }

        public List<SeasonsDto> Seasons { get; set; }
    }
}

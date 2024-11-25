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

        [MaxLength(30)]
        [Required]
        public string Title { get; set; }

        public int? CourseLevelId { get; set; }

        [Required]
        public Guid TeacherId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }


        public string  TecherFullName { get; set; }
        [Required]
        public string CourseDescription { get; set; }

        [DefaultValue(0)]
        public int View { get; set; }

        [DefaultValue(0)]
        public decimal Cost { get; set; }
        [AllowNull]
        [DefaultValue(null)]
        public string? ImageBase64 { get; set; }



        public int? StarsNumber { get; set; }

        [AllowNull]
        [DefaultValue(null)]
        public String? ImageUrl { get; set; }

        public Guid? ImageId { get; set; }
    }
}

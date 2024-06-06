using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace ApiEndPoint.ViewModel
{
    public class CourseVm
    {
        public Guid Id { get; set; }

        [MaxLength(30)]
        [Required]
        public string Title { get; set; }

        public int? CourseLevelId { get; set; }

        [Required]
        public Guid? TeacherId { get; set; }

        [Required]
        public Guid CategoryId { get; set; }

        [Required]
        public string CourseDescription { get; set; }

        [DefaultValue(0)]
        public int View { get; set; }

        [DefaultValue(0)]
        public decimal Cost { get; set; }
        [AllowNull]
        [DefaultValue(null)]
        public string? ImageBase64 { get; set; }
    }
}

using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.BasicInfo.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAhface.Domain.Core.Entities.Study.Season;
using MAhface.Domain.Core1.Entities.BasicInfo.Business;

namespace MAhface.Domain.Core.Entities.Study.Course
{
    [DisplayName("Course")]
    [Table("Course", Schema = "Study")]
    public class Courses : BaseEntity
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


        [DefaultValue(0)]
        public decimal Cost { get; set; }


        public List<Student> Students { get; set; }

        public Teacher Teacher { get; set; }


        public Category category { get; set; }

        public List<Seasons> Seasons { get; set; }

        public Image Image { get; set; }

        public Guid? ImageId { get; set; }

    }
}

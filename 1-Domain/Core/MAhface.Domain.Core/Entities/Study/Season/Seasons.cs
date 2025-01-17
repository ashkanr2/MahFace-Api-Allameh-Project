using MAhface.Domain.Core.Entities.Study.Course;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
using MAhface.Domain.Core1.Entities.Study.Episode;

namespace MAhface.Domain.Core.Entities.Study.Season
{
    [Table("Season", Schema = "Study")]
    public class Seasons : BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public Guid CourseId { get; set; }

        public Courses Course { get; set; }

       
        public  string   Title   { get; set; }

     
        public string SeasonsDescription {  get; set; }


        public List<Episode> Episodes { get; set; }

    }
}

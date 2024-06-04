using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Entities.Study.Season
{
    [Table("Season", Schema = "Study")]
    public class Seasons : BaseEntity
    {
        [Required]
        public Guid CourseId { get; set; }

        public Courses Course { get; set; }

       
        public  string   Title   { get; set; }

     
        public string   Descrption {  get; set; }


        //public List<Section> Sections { get; set; }

    }
}

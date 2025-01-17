using MAhface.Domain.Core.Entities.Study.Course;
using MAhface.Domain.Core.Entities.Study.Season;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities.Study.Episode
{
    public class Episode
    {
        [Key]
        public Guid Id { get; set; }
        public string Title { get; set; }

        public Guid SeasionnId { get; set; }

        public Seasons Season { get; set; }

        public Guid? CourseId { get; set; }
        public string URL { get; set; }
    }
}

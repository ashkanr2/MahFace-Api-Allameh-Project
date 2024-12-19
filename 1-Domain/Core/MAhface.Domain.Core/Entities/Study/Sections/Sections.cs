using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAhface.Domain.Core.Entities.Study.Season;

namespace MAhface.Domain.Core.Entities.Study.Section
{

    public class Sections : BaseEntity
    {
        [Required]
        public Guid CourseId { get; set; }

        public string Title { get; set; }

        public string HashUrl { get; set; }

        [Required]
        public Guid SeasionId { get; set; }

        [Required]
        public int CourseLevel { get; set; }

        public Seasons Season { get; set; }
    }

}

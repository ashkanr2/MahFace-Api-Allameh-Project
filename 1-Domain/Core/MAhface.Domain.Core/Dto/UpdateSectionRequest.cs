using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class UpdateSectionRequest
    {
        // Nullable property for updating the title of the section
        public string Title { get; set; }

        // Property for updating the course level
        //public int? CourseLevel { get; set; }

        // Property for updating the SeasonId
        public Guid? SeasionId { get; set; }
    }

}

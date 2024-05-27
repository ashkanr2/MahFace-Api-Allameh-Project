using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core.Entities.Study.Sections;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Entities.BasicInfo.Business
{
    [Table("Views", Schema = "Study")]
    public class View : BaseEntity
    {
        public Guid CourseId { get; set; }

        public Guid SectionId { get; set; }

        public Guid UserId { get; set; }

        [DefaultValue("00:00:00")]
        public TimeOnly LastVideoTime { get; set; }


        public User user { get; set; }
        public Sections section { get; set; }

    }
}

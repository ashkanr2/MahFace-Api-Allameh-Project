using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Entities.BasicInfo.Accounting
{

    [Table("Student", Schema = "BasicInfo")]
    public class Student : BaseEntity
    {

        public Guid UserId { get; set; }

        public User User { get; set; }

        public List<Courses> Courses { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class StudentCoursesVm
    {
        public Guid UserId { get; set; }

        public Guid CourseId { get; set; }
    }
    
    
    public class StudentMultipleCoursesVm
    {
        public Guid UserId { get; set; }

        public List<Guid> RequestIds { get; set; }
    }



}

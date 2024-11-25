using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class ViewDTO
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public TimeOnly LastVideoTime { get; set; }
    }

}

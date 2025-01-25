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

    public class StudentFavoriteCoursesVm
    {
        /// <summary>
        /// شناسه کاربر (دانش‌آموز) که دوره را به عنوان دوره مورد علاقه خود انتخاب کرده است.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// شناسه دوره‌ای که به عنوان دوره مورد علاقه برای دانش‌آموز انتخاب شده است.
        /// </summary>
        public Guid CourseId { get; set; }
    }

}

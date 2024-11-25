using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class SectionDto
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid SeasionId { get; set; }
        public Guid? CategoryId { get; set; }
        public int CourseLevel { get; set; }
    }



}

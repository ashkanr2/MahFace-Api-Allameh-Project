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
        public string Title { get; set; }
        public string HashUrl { get; set; }
        public Guid SeasionId { get; set; }
        public Guid CourseId { get; set; }
        public int CourseLevel { get; set; }
        public string SeasonName { get; set; } // You might want to include the season name as well
    }



}

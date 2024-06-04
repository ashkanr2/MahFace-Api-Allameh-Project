using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Dto
{
    public class SeasonsDto
    {
        public Guid? Id { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public string SeasonsDescription { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class TeacherRequestVm
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string UserDescription { get; set; }
        public DateTime UserRequestDate { get; set; }
        public string AdminDescription { get; set; }
        public DateTime? AdminResponseDate { get; set; }
        public string Status { get; set; } // Use AutoMapper to map StatusCode to the Enum display name
    }
}

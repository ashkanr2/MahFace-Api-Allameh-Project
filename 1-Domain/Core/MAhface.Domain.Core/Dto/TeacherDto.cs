using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MAhface.Domain.Core.Dto
{
    public class TeacherDto
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; } // Assuming you want to expose the user's name
        public bool IsActive { get; set; }
        public string Description { get; set; } // Optional, depending on your needs
        public DateTime CreatedDate { get; set; }
    }

}

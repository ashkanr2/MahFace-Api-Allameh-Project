using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class LoginResponseVm
    {
        public bool IsValid { get; set; }
        public string StatusMessage { get; set; }
        public Guid UserId { get; set; }
        public bool IsTeacher { get; set; }
        public bool IsAdmin { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ProfileImageBase64 { get; set; }
    }
}

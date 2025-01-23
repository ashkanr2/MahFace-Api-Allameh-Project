using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class AddUser
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
       
        public DateTime BirthDate { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
       
        public string? PhoneNumber { get; set; }
        [MaxLength(10)]
        public string? NationalCode { get; set; }
        [DefaultValue(0)]
        public int GenderEnum { get; set; }

    }
}

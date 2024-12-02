using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class EditUserVm
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        [MaxLength(10)]
        public string? NationalCode { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Base64Profile { get; set; }
        public bool IsTeacher { get; set; }
    

    }
}

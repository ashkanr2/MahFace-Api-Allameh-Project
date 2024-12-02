using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class UserDto
    {

        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsSystemAccount { get; set; }
        public bool IsSystemAdmin { get; set; }
        public bool IsStudent { get; set; }
        public bool IsTeacher { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public bool EmailConfirm { get; set; }
        public string PasswordHash { get; set; }
        public bool PhoneNumberConfirm { get; set; }   
        public string PhoneNumber{ get; set;}
        public ImageDto? Image { get; set; }
        public Guid? ImageId { get; set; }

        public string NationalCode { get; set; }

        public string Base64Profile { get; set; }

    }
}

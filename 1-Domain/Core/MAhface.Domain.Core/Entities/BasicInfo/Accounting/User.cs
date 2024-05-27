using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace MAhface.Domain.Core.Entities.BasicInfo.Accounting
{
    [DisplayName("User")]
    [Table("User", Schema = "BasicInfo")]
    public class User : IdentityUser<Guid>
    {



        [Required]
        [DefaultValue(false)]
        public bool IsSystemAccount { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsSystemAdmin { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool IsStudent { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool IsTeacher { get; set; }




    }
}

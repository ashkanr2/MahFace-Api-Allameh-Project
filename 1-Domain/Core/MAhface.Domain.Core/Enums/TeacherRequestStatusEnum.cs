using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Enums
{
    using System.ComponentModel.DataAnnotations;

    public enum TeacherRequestStatusEnum
    {
        [Display(Name = "در حال بررسی")]
        Pending = 1,

        [Display(Name = "تایید شده")]
        Approved = 2,

        [Display(Name = "رد شده")]
        Rejected = 3
    }


}

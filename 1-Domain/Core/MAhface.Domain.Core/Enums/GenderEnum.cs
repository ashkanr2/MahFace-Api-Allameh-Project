using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Enums
{
    public enum GenderEnum
    {
        [Display(Name = " ")]
        NotSelect = 0,

        [Display(Name = "مرد")]
        Male = 1,

        [Display(Name = "زن")]
        Female = 2,

        [Display(Name = "سایر")]
        Other = 3
    }
}

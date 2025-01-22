using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class AddCommentVm
    {
        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid CourseId { get; set; }

        [Required]
        [MaxLength(1000, ErrorMessage = "متن نظر نباید بیشتر از ۱۰۰۰ کاراکتر باشد.")]
        public string Text { get; set; }
    }
}

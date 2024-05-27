using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Entities
{
    public class BaseEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public int Code { get; set; }

        [AllowNull]
        public string? Description { get; set; }
        [Required]
        public Guid CreatedUserID { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [AllowNull]
        public Guid? DeletedUserID { get; set; }
        [AllowNull]
        public DateTime? DeletedDate { get; set; }
        [Required]
        public bool ISActive { get; set; }
        [Required]
        public bool IsDeleted { get; set; }

    }
}

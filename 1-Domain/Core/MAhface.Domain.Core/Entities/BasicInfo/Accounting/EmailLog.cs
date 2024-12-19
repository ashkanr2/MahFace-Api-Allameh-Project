using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities.BasicInfo.Accounting
{
    [Table("EmailLogs")]
    public class EmailLog
    {
        [Key]
        public Guid Id { get; set; } // Unique identifier for each log

        [Required]
        public string ToEmail { get; set; } // Recipient's email address

        [Required]
        public string Subject { get; set; } // Email subject

        public string Message { get; set; } // Body of the email (optional)

        [Required]
        public DateTime SentDate { get; set; } // Date and time when the email was sent

        public string Status { get; set; } // Status of the email (e.g., Sent, Failed)

        public string ErrorDetails { get; set; } // Error details in case of failure (optional)

        public Guid? SentByUserId { get; set; } // User who initiated sending the email (optional)

        [ForeignKey("SentByUserId")]
        public virtual User SentByUser { get; set; } // Navigation property to the user (optional)

        public bool IsSuccess { get; set; } // Indicates whether the email was sent successfully or not
    }
}

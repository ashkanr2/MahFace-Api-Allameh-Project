using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities.BasicInfo.Accounting
{
    public class Otp
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string OtpCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ExpireTime { get; set; }
    }

}

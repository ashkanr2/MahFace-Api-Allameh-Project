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
        public int OtpCode { get; set; }
        public string EmailOrPhoneNumber { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime ExpireTime { get; set; }
    }

}

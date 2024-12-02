using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IRipositories
{
    public interface IOtpRepository
    {
        Task<Otp> CreateOtpAsync(Otp otp);
        Task<Otp> GetOtpAsync(string otpCode);
        Task<bool> VerifyOtpAsync(string otpCode);
    }

}

using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IOtpService
    {
        Task<string> GenerateOtp(Guid userId, string emailOrPhoneNumber);
        Task<bool> ValidateOtp(Guid userId, int otpCode);
        Task<List<Otp>> GetAllOTP();
    }

}

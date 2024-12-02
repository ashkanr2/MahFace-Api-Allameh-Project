using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Interface.IServices
{
    public interface IOtpService
    {
        Task<string> GenerateOtp(Guid userId, string email, string phoneNumber);
        Task<bool> ValidateOtp(string otpCode);
    }

}

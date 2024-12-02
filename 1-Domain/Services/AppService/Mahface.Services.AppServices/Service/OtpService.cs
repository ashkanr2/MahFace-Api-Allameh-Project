using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Domain.Core1.Interface.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahface.Services.AppServices.Service
{
    public class OtpService : IOtpService
    {
        private readonly IOtpRepository _otpRepository;

        public OtpService(IOtpRepository otpRepository)
        {
            _otpRepository = otpRepository;
        }

        public async Task<string> GenerateOtp(Guid userId, string email, string phoneNumber)
        {
            var otpCode = new Random().Next(100000, 999999).ToString(); // Generate a 6-digit OTP
            var otp = new Otp
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                OtpCode = otpCode,
                Email = email,
                PhoneNumber = phoneNumber,
                CreatedTime = DateTime.UtcNow,
                ExpireTime = DateTime.UtcNow.AddMinutes(5) // OTP valid for 5 minutes
            };

            await _otpRepository.CreateOtpAsync(otp);

            //// Send email with OTP here
            //// Do not write email-sending logic per instructions

            return otpCode;
        }

        public async Task<bool> ValidateOtp(string otpCode)
        {
            return await _otpRepository.VerifyOtpAsync(otpCode);
        }
    }

}

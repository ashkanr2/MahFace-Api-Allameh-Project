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

        // متد ایجاد OTP
        public async Task<string> GenerateOtp(Guid userId, string emailOrPhoneNumber)
        {
            var otpCode = new Random().Next(1000, 9999);
            var otp = new Otp
            {
                Id = Guid.NewGuid(),
                UserId = userId,
                OtpCode = otpCode,
                EmailOrPhoneNumber = emailOrPhoneNumber,
                CreatedTime = DateTime.Now,
                ExpireTime = DateTime.Now.AddYears(3)
            };

            // ذخیره OTP در پایگاه داده
            await _otpRepository.CreateOtpAsync(otp);
            return otp.ToString();  
        }

        public async Task<List<Otp>> GetAllOTP()
        {
           return await _otpRepository.GetAllOTP();
        }

        // متد تایید OTP
        public async Task<bool> ValidateOtp(Guid userId, int otpCode)
        {
            // بررسی OTP و تطابق آن با ایمیل یا شماره موبایل
            return await _otpRepository.VerifyOtpAsync(userId, otpCode);
        }
    }

}

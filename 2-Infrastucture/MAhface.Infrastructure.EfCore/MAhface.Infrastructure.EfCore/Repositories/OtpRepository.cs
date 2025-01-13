using MAhface.Domain.Core1.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Interface.IRipositories;
using MAhface.Infrastructure.EfCore.DBContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Infrastructure.EfCore.Repositories
{
    public class OtpRepository : IOtpRepository
    {
        private readonly AllamehPrroject _context;

        public OtpRepository(AllamehPrroject context)
        {
            _context = context;
        }

        // متد برای ذخیره OTP در پایگاه داده
        public async Task<Otp> CreateOtpAsync(Otp otp)
        {
            _context.Otps.Add(otp);
            await _context.SaveChangesAsync();
            return otp;
        }

        public async Task<List<Otp>> GetAllOTP()
        {
          return  _context.Otps.ToList();
        }

        // متد برای تایید OTP (بررسی صحت کد OTP)
        public async Task<bool> VerifyOtpAsync(Guid userId, int otpCode)
        {
            
            var otp = await _context.Otps
                .FirstOrDefaultAsync(o => o.UserId == userId &&
                                          (o.OtpCode == otpCode) );

            if (otp == null || otp.ExpireTime < DateTime.Now)
            {
               
                return false;
            }

            return true; 
        }
    }

}

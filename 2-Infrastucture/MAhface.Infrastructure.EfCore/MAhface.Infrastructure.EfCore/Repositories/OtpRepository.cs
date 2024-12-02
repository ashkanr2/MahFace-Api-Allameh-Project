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

        public async Task<Otp> CreateOtpAsync(Otp otp)
        {
            _context.Otps.Add(otp);
            await _context.SaveChangesAsync();
            return otp;
        }

        public async Task<Otp> GetOtpAsync(string otpCode)
        {
            return await _context.Otps.FirstOrDefaultAsync(o => o.OtpCode == otpCode);
        }

        public async Task<bool> VerifyOtpAsync(string otpCode)
        {
            var otp = await _context.Otps.FirstOrDefaultAsync(o => o.OtpCode == otpCode);

            if (otp == null || otp.ExpireTime < DateTime.UtcNow)
            {
                return false;
            }

            return true;
        }
    }

}

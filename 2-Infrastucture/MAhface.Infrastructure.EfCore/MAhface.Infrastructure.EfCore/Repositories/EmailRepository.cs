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
    public class EmailRepository : IEMailRepository
    {
        private readonly AllamehPrroject _context;

        public EmailRepository(AllamehPrroject context)
        {
            _context = context;
        }
        public Task<EmailSetting> GetSetting()
        {
            return _context.EmailSetting.FirstOrDefaultAsync();
        }

        public async Task LogEmailAsync(EmailLog emailLog)
        {
            await _context.EmailLog.AddAsync(emailLog);
            await _context.SaveChangesAsync();
        }
    }
}

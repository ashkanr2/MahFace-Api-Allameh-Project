using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities.BasicInfo.Accounting
{
    public class EmailSetting
    {
        public Guid Id { get; set; }  
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string SMTPHost { get; set; }
        public int SMTPPort { get; set; }
    }

}

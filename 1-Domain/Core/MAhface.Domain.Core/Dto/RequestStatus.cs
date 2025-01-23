using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class RequestStatus
    {
        public Guid Id { get; set; }
        public int Status { get; set; }
        public string StatusDescripton { get; set; }

        public bool HasActiveRequest { get; set; }
        public string UserDescription { get; set; }
        public DateTime UserRequestDate { get; set; }

        public string? AdminDescription { get; set; }
        public DateTime? AdminResponseDate { get; set; }
    }
}

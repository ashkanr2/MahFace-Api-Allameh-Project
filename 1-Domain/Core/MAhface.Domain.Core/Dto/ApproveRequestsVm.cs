using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class ApproveRequestsVm
    {
        public List<Guid> RequestIds { get; set; }
        public Guid AdminId { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Entities.BasicInfo.Accounting
{
    [Table("Teacher", Schema = "BasicInfo")]
    public class Teacher : BaseEntity
    {

        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}

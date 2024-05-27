using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Entities.BasicInfo.Business
{
    [Table("Category", Schema = "BasicInfo")]
    public class Category : BaseEntity
    {

        public string Title { get; set; }

        public string Description { get; set; }

        [AllowNull]
        public Guid? ParentCategoryId { get; set; }

        public int? OrderNo { get; set; }

        public List<Courses> Courses { get; set; }
    }
}

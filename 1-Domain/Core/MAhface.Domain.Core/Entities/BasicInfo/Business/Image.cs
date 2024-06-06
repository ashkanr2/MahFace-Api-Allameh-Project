using MAhface.Domain.Core.Entities;
using MAhface.Domain.Core.Entities.Study.Course;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities.BasicInfo.Business
{
   [Table("Image", Schema = "BasicInfo")]
    public class Image:BaseEntity
    {
        //public Guid ImageId { get; set; }

       
        public string Url { get; set; }

        public string Base64File { get; set; }

    }
}

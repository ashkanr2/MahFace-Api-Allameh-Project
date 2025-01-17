using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class CreateSectionRequest
    {
   

        [Required]
        public Guid CreatedUserId { get; set; }

        [Required]
        public Guid SeasionId { get; set; }

        public string Title { get; set; } // Nullable title

        public string URL { get; set; }
    }

}

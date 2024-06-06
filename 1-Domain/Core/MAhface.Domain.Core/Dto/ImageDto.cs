using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class ImageDto
    {
        public Guid Id { get; set; }


        public string Url { get; set; }

        public string Base64File { get; set; }
    }
}

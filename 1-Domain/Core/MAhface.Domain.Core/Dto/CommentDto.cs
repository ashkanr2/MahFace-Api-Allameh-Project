using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

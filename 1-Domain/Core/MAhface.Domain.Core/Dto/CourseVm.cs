using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class CourseVm
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public int? CourseLevelId { get; set; }
        [DataMember]
        public Guid TeacherId { get; set; }
        [DataMember]
        public string TeacherName { get; set; }
        [DataMember]
        public Guid CategoryId { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public decimal Cost { get; set; }
        [DataMember]
        public int TotalSeasons { get; set; }
        [DataMember]
        public int TotalSections { get; set; }
        [DataMember]
        public int TotalDuration { get; set; }
        [DataMember]
        public int StarsNumber { get; set; }
        [DataMember]
        public int TotalView { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public string CourseDescription { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string? ImageUrl { get; set; }
        [DataMember]
        public string? ImageBase64 { get; set; }


    }


}

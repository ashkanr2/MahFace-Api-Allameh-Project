﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core.Dto
{
    public class SeasonsDto
    {
        public Guid? Id { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public TimeOnly? SumSections { get; set; }
        public string SeasonsDescription { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

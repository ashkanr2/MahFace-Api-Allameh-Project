﻿using MAhface.Domain.Core.Entities;
using MAhface.Domain.Core.Entities.BasicInfo.Accounting;
using MAhface.Domain.Core1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities.BasicInfo.Accounting
{
    public class TeacherRequests 
    {
        public Guid  Id { get; set; }
        public Guid UserId { get; set; }
        public User  User { get; set; }
        public string UserDescription { get; set; } 
        public DateTime UserRequestDate { get; set; } 

        public string? AdminDescription { get; set; } 
        public DateTime? AdminResponseDate { get; set; }

        public int StatusCode { get; set; }

        public bool IsDeleted { get; set; }
    }


}

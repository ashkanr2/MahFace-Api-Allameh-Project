﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Dto
{
    public class AddStatusVm
    {
        public bool IsValid { get; set; }

        public string StatusMessage { get; set; }

        public Guid? AddedId { get; set; }
    }
}

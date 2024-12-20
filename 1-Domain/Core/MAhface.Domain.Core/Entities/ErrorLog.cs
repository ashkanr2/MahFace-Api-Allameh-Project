﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAhface.Domain.Core1.Entities
{
    [Table("ErrorLog", Schema = "System")]
    public class ErrorLog
    {
        public Guid Id { get; set; }
        [AllowNull]
        public string? Entityname { get; set; }
        [AllowNull]
        public  string? ActionType { get; set; }
        [AllowNull]
        public string?  ActionName { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        [AllowNull]
        public Guid? UserId { get; set; }
        [Required]
        public string Exeption { get; set; }
    }
}

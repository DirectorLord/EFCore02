﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    internal class Student
    {
        public int Id { get; set; }
        [MaxLength(20)]
        [Required]
        [Column(TypeName= "VarChar")]
        public string FName { get; set; }
        [Required]
        [MaxLength(20)]
        [Column(TypeName = "VarChar")]
        public string LName { get; set; }
        [Required]
        [MaxLength(40)]
        [Column(TypeName = "VarChar")]
        public string Address { get; set; }
        [Required]
        public string Age { get; set; }
        public string Dep_Id { get; set; }
    }
}

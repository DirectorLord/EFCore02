using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    [PrimaryKey(nameof(inst_ID), nameof(Course_ID))]
    internal class Course_Inst
    {
        [ForeignKey(nameof(inst_ID))]
        public Instructor? Instructor { get; set; }
        [ForeignKey(nameof(Instructor))]
        public int? inst_ID { get; set; }
        [ForeignKey(nameof(Course_ID))]
        public Course? Course { get; set; }
        [ForeignKey(nameof(Course))]

        public int? Course_ID { get; set; }
        public int Evaluate { get; set; }
    }
}

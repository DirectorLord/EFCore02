using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    internal class Department
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime HiringDate { get; set; }

        [ForeignKey(nameof(Ins_ID))]
        public Instructor? Instructor { get; set; }

        [ForeignKey(nameof(Instructor))]
        public int? Ins_ID { get; set; }
    }
}

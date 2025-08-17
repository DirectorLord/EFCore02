using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    internal class Instructor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Bonus { get; set; }

        public decimal Salary { get; set; }

        public string Address { get; set; }

        public DateTime HourRate { get; set; }
        [ForeignKey(nameof(Dept_ID))]
        public Department? Department { get; set; }
        [ForeignKey(nameof(Department))]
        public int? Dept_ID { get; set; }
    }
}

using System;
using System.Collections.Generic;
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

        public int Dept_ID { get; set; }
    }
}

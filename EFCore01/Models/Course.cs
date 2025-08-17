using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models
{
    internal class Course
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Duration { get; set; }

        [ForeignKey(nameof(Top_ID))]
        public Topic? Topic { get; set; }

        [ForeignKey(nameof(Topic))]
        public int? Top_ID { get; set; }

    }
}

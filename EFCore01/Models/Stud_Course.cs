using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models;
[PrimaryKey(nameof(stud_ID), nameof(Course_ID))]
internal class Stud_Course
{
    public int stud_ID { get; set; }
    public int Course_ID { get; set; }
    public int Grade { get; set; }
}

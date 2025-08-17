using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01.Models;
[PrimaryKey(nameof(stud_ID), nameof(Course_ID))]
internal class Stud_Course
{
    [ForeignKey(nameof(stud_ID))]
    public Student? Student { get; set; }
    [ForeignKey(nameof(Student))]
    public int? stud_ID { get; set; }

    [ForeignKey(nameof(Course_ID))]
    public Course? Course { get; set; }
    [ForeignKey(nameof(Course))]
    public int? Course_ID { get; set; }
    public int Grade { get; set; }
}

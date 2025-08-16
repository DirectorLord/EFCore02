using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore01
{
    internal class ITIMapping
    {
        public class Student
        {
            public int ID { get; set; }
            public string FName { get; set; }
            public string LName { get; set; }
            public string Address { get; set; }
            public int Age { get; set; }
            public int Dep_Id { get; set; }
        }

        public class Course
        {
            public int ID { get; set; }
            public int Duration { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Top_ID { get; set; }
        }

        public class Topic
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }

        public class CourseInst
        {
            public int Inst_ID { get; set; }
            public int Course_ID { get; set; }
            public int Evaluate { get; set; }
        }

        public class StudCourse
        {
            public int Stud_ID { get; set; }
            public int Course_ID { get; set; }
            public int Grade { get; set; }
        }

        public class Department
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Ins_ID { get; set; }
            public DateTime HiringDate { get; set; }
        }

        public class Instructor
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public int Bonus { get; set; }
            public int Salary { get; set; }
            public string Address { get; set; }
            public int HourRate { get; set; }
            public int Dept_ID { get; set; }
        }
    }
}

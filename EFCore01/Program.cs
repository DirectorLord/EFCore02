using EFCore01.Context;
using EFCore01.Models;

namespace EFCore01;
internal class Program
{
    
    public static void Main()
    {
        #region CRUD operations

        using var context = new ITIDBContext();

        #region Create-Insert
        //student
        var student = new Student
        {
            FName = "ali",
            LName = "ahmed",
            Age = 21,
            Address = "cairo"
        };
        //course
        var course = new Course
        {
            Name = "operating system",
            Description = "learn the OS",
        };
        //department
        var department = new Department
        {
            Name = "IT",

        };
        //topic
        var topic = new Topic
        {
            Name = "no name"
        };
        //instructor
        var instructor = new Instructor
        {
            Name = "Mohamed",
            Bonus = 15_55,
            Salary = 1500,
            Address = "cairo",

        };
        //inst course
        var CourseInst = new Course_Inst
        {

        };
        //studCourse
        var StudCourse = new Stud_Course
        {

        };

        context.Students.Add(student);
        context.courses.Add(course);
        context.departments.Add(department);
        context.topics.Add(topic);
        context.instructors.Add(instructor);
        context.course_Insts.Add(CourseInst);
        context.Stud_Courses.Add(StudCourse);

        Console.WriteLine(context.Entry(student).State);
        Console.WriteLine(context.Entry(course).State);
        Console.WriteLine(context.Entry(department).State);
        Console.WriteLine(context.Entry(topic).State);
        Console.WriteLine(context.Entry(instructor).State);
        Console.WriteLine(context.Entry(CourseInst).State);
        Console.WriteLine(context.Entry(StudCourse).State);

        context.SaveChanges();
        #endregion

        #region Retrive-Read

        var RStudent = from Student in context.Students where student.Age >20 select Student;

        foreach (var item in RStudent)
        {
            Console.WriteLine(item);
        }

        #endregion

        #region Update-Delete

        #region Update
        //updating the salary of the instructor
        instructor.Salary = 19_500;
        //updating their bonus
        instructor.Bonus = 5000;
        context.instructors.Update(instructor);

        context.SaveChanges();
        #endregion

        #region Delete
        context.instructors.Remove(instructor);

        context.SaveChanges();
        #endregion
        #endregion

        #endregion
    }
}
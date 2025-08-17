using EFCore01.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore01.Context;

internal class ITIDBContext : DbContext
{
    //Student
    public DbSet<Student> Students { get; set; }

    public DbSet<Instructor> instructors { get; set; }

    public DbSet<Department> departments { get; set; }

    public DbSet<Topic> topics { get; set; }

    public DbSet<Course> courses { get; set; }
    public DbSet<Course_Inst> course_Insts { get; set; }
    public DbSet<Stud_Course> Stud_Courses { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server = .; database = ITI; Trusted_Connection = true; TrustServerCertificate = true");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Student
        modelBuilder.Entity<Student>(builder =>
        {
            //student
            builder.ToTable("Student").HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn(10,10);

            builder.Property(x => x.FName).IsRequired(true).HasMaxLength(20).HasColumnType("VarChar");  

            builder.Property(x => x.LName).IsRequired(true).HasMaxLength(20).HasColumnType("VarChar");

            builder.Property(x => x.Address).IsRequired(true).HasMaxLength(40).HasColumnType("VarChar");

            builder.Property(x => x.Age).IsRequired(true).HasMaxLength(2).HasColumnType("int");
            //builder.ToTable("Course_Inst").HasKey(x => new { x.inst, x.Course_ID });
        });

        //Department
        modelBuilder.Entity<Department>(builder =>
        {
            
            builder.ToTable("Department").HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn(10,10);

            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(20).HasColumnType("VarChar");  

            builder.Property(x => x.HiringDate).IsRequired(true).HasColumnType("DateTime");

            builder.Property(x => x.Ins_ID).IsRequired(true).HasColumnType("int");
            //builder.ToTable("Course_Inst").HasKey(x => new { x.inst, x.Course_ID });
        });

        //Course
        modelBuilder.Entity<Course>(builder =>
        {
            
            builder.ToTable("Course").HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn(10,10);

            builder.Property(x => x.Duration).IsRequired(true).HasColumnType("DateTime");  

            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(20).HasColumnType("VarChar");

            builder.Property(x => x.Description).IsRequired(true).HasMaxLength(40).HasColumnType("VarChar");

            builder.Property(x => x.Top_ID).IsRequired(true).HasColumnType("int");
            //builder.ToTable("Course_Inst").HasKey(x => new { x.inst, x.Course_ID });
        });

        //Topic
        modelBuilder.Entity<Topic>(builder =>
        {
            builder.ToTable("Topic").HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn(10,10);

            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(20).HasColumnType("VarChar");
        });

        //Instructor
        modelBuilder.Entity<Instructor>(builder =>
        {
            builder.ToTable("Instructor").HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn(10,10);

            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(20).HasColumnType("VarChar");  

            builder.Property(x => x.Bonus).IsRequired(true).HasColumnType("decimal(12,2)");

            builder.Property(x => x.Salary).IsRequired(true).HasColumnType("decimal(12,2)");

            builder.Property(x => x.Address).IsRequired(true).HasMaxLength(40).HasColumnType("VarChar");

            builder.Property(x => x.HourRate).IsRequired(true).HasColumnType("DateTime");

        });

        //Course_Inst
        modelBuilder.Entity<Course_Inst>(builder =>
        {
            //student
            builder.ToTable("Instructor").HasKey(x => x.inst_ID);
            builder.ToTable("Course").HasKey(x => x.Course_ID);

            builder.Property(x => x.Evaluate).IsRequired(true).HasMaxLength(40).HasColumnType("VarChar");
        });

        //Stud_Course
        modelBuilder.Entity<Stud_Course>(builder =>
        {
            //student
            builder.ToTable("Student").HasKey(x => x.stud_ID);

            builder.ToTable("Course").HasKey(x => x.Course_ID);

            builder.Property(x => x.Grade).IsRequired(true).HasMaxLength(3).HasColumnType("int");
        });
    }
}

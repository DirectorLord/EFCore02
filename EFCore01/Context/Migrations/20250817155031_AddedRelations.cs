using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore01.Context.Migrations
{
    /// <inheritdoc />
    public partial class AddedRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_topics",
                table: "topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_instructors",
                table: "instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_departments",
                table: "departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_courses",
                table: "courses");

            migrationBuilder.RenameTable(
                name: "topics",
                newName: "Topic");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "instructors",
                newName: "Instructor");

            migrationBuilder.RenameTable(
                name: "departments",
                newName: "Department");

            migrationBuilder.RenameTable(
                name: "courses",
                newName: "Course");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Topic",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Topic",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "Student",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Student",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Dep_Id",
                table: "Student",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Student",
                type: "VarChar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Student",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Instructor",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Instructor",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HourRate",
                table: "Instructor",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Dept_ID",
                table: "Instructor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                table: "Instructor",
                type: "decimal(12,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructor",
                type: "VarChar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Instructor",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Department",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "Department",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Department",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Course",
                type: "VarChar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Duration",
                table: "Course",
                type: "DateTime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Course",
                type: "VarChar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "10, 10")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Evaluate",
                table: "Course",
                type: "VarChar(40)",
                maxLength: 40,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Grade",
                table: "Course",
                type: "int",
                maxLength: 3,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "inst_ID",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "stud_ID",
                table: "Course",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                table: "Topic",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course",
                table: "Course",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Student_Dep_Id",
                table: "Student",
                column: "Dep_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor",
                column: "Dept_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_Ins_ID",
                table: "Department",
                column: "Ins_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_inst_ID",
                table: "Course",
                column: "inst_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_stud_ID",
                table: "Course",
                column: "stud_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Top_ID",
                table: "Course",
                column: "Top_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Instructor_inst_ID",
                table: "Course",
                column: "inst_ID",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Student_stud_ID",
                table: "Course",
                column: "stud_ID",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Topic_Top_ID",
                table: "Course",
                column: "Top_ID",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department",
                column: "Ins_ID",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor",
                column: "Dept_ID",
                principalTable: "Department",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student",
                column: "Dep_Id",
                principalTable: "Department",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Instructor_inst_ID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Student_stud_ID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Topic_Top_ID",
                table: "Course");

            migrationBuilder.DropForeignKey(
                name: "FK_Department_Instructor_Ins_ID",
                table: "Department");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Department_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Department_Dep_Id",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropIndex(
                name: "IX_Student_Dep_Id",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Instructor",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_Dept_ID",
                table: "Instructor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropIndex(
                name: "IX_Department_Ins_ID",
                table: "Department");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_inst_ID",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_stud_ID",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_Top_ID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Evaluate",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Grade",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "inst_ID",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "stud_ID",
                table: "Course");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "topics");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Instructor",
                newName: "instructors");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "departments");

            migrationBuilder.RenameTable(
                name: "Course",
                newName: "courses");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "topics",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "topics",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AlterColumn<string>(
                name: "LName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Dep_Id",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Students",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "instructors",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HourRate",
                table: "instructors",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<int>(
                name: "Dept_ID",
                table: "instructors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Bonus",
                table: "instructors",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "instructors",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "instructors",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "departments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HiringDate",
                table: "departments",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "departments",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Duration",
                table: "courses",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DateTime");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "courses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VarChar(40)",
                oldMaxLength: 40);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "10, 10");

            migrationBuilder.AddPrimaryKey(
                name: "PK_topics",
                table: "topics",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_instructors",
                table: "instructors",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_departments",
                table: "departments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_courses",
                table: "courses",
                column: "Id");
        }
    }
}

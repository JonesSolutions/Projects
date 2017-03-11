using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ContosoUniversity.Migrations
{
    public partial class StudentviewModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_CourseAssignment_Instructor_InstructorId",
            //    table: "CourseAssignment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Department_Instructor_InstructorId",
            //    table: "Department");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Enrollment_Student_StudentId",
            //    table: "Enrollment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_OfficeAssignment_Instructor_InstructorId",
            //    table: "OfficeAssignment");

            //migrationBuilder.DropTable(
            //    name: "Instructor");

            //migrationBuilder.DropTable(
            //    name: "Student");

            //migrationBuilder.CreateTable(
            //    name: "Person",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Discriminator = table.Column<string>(nullable: false),
            //        FirstName = table.Column<string>(maxLength: 50, nullable: false),
            //        LastName = table.Column<string>(maxLength: 50, nullable: false),
            //        HireDate = table.Column<DateTime>(nullable: true),
            //        EnrollmentDate = table.Column<DateTime>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Person", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "StudentViewModel",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        StudentId = table.Column<int>(nullable: true)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_StudentViewModel", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_StudentViewModel_Person_StudentId",
            //            column: x => x.StudentId,
            //            principalTable: "Person",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.AddColumn<int>(
            //    name: "StudentViewModelId",
            //    table: "Enrollment",
            //    nullable: true);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Enrollment_StudentViewModelId",
            //    table: "Enrollment",
            //    column: "StudentViewModelId");

            //migrationBuilder.CreateIndex(
            //    name: "IX_StudentViewModel_StudentId",
            //    table: "StudentViewModel",
            //    column: "StudentId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_CourseAssignment_Person_InstructorId",
            //    table: "CourseAssignment",
            //    column: "InstructorId",
            //    principalTable: "Person",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Department_Person_InstructorId",
            //    table: "Department",
            //    column: "InstructorId",
            //    principalTable: "Person",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Enrollment_Person_StudentId",
            //    table: "Enrollment",
            //    column: "StudentId",
            //    principalTable: "Person",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Enrollment_StudentViewModel_StudentViewModelId",
            //    table: "Enrollment",
            //    column: "StudentViewModelId",
            //    principalTable: "StudentViewModel",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_OfficeAssignment_Person_InstructorId",
            //    table: "OfficeAssignment",
            //    column: "InstructorId",
            //    principalTable: "Person",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_CourseAssignment_Person_InstructorId",
            //    table: "CourseAssignment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Department_Person_InstructorId",
            //    table: "Department");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Enrollment_Person_StudentId",
            //    table: "Enrollment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_Enrollment_StudentViewModel_StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropForeignKey(
            //    name: "FK_OfficeAssignment_Person_InstructorId",
            //    table: "OfficeAssignment");

            //migrationBuilder.DropIndex(
            //    name: "IX_Enrollment_StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropColumn(
            //    name: "StudentViewModelId",
            //    table: "Enrollment");

            //migrationBuilder.DropTable(
            //    name: "StudentViewModel");

            //migrationBuilder.DropTable(
            //    name: "Person");

            //migrationBuilder.CreateTable(
            //    name: "Instructor",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        FirstName = table.Column<string>(maxLength: 50, nullable: false),
            //        HireDate = table.Column<DateTime>(nullable: false),
            //        LastName = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Instructor", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Student",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        EnrollmentDate = table.Column<DateTime>(nullable: false),
            //        FirstName = table.Column<string>(maxLength: 50, nullable: false),
            //        LastName = table.Column<string>(maxLength: 50, nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Student", x => x.Id);
            //    });

            //migrationBuilder.AddForeignKey(
            //    name: "FK_CourseAssignment_Instructor_InstructorId",
            //    table: "CourseAssignment",
            //    column: "InstructorId",
            //    principalTable: "Instructor",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Department_Instructor_InstructorId",
            //    table: "Department",
            //    column: "InstructorId",
            //    principalTable: "Instructor",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Restrict);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Enrollment_Student_StudentId",
            //    table: "Enrollment",
            //    column: "StudentId",
            //    principalTable: "Student",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_OfficeAssignment_Instructor_InstructorId",
            //    table: "OfficeAssignment",
            //    column: "InstructorId",
            //    principalTable: "Instructor",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContosoUniversity.Data;

namespace ContosoUniversity.Models
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any students.
            if (!context.Students.Any())
            {
             var students = new Student[]
                {
                new Student { FirstMidName = "Carson",   LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01") },
                new Student { FirstMidName = "Meredith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Arturo",   LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstMidName = "Gytis",    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Yan",      LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstMidName = "Peggy",    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01") },
                new Student { FirstMidName = "Laura",    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstMidName = "Nino",     LastName = "Olivetto",
                    EnrollmentDate = DateTime.Parse("2005-09-01") }
                };

                foreach (Student s in students)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();
            }
            if (!context.Instructors.Any())
            {
                var instructors = new Instructor[]
                {
                new Instructor { FirstMidName = "Kim",     LastName = "Abercrombie",
                    HireDate = DateTime.Parse("1995-03-11") },
                new Instructor { FirstMidName = "Fadi",    LastName = "Fakhouri",
                    HireDate = DateTime.Parse("2002-07-06") },
                new Instructor { FirstMidName = "Roger",   LastName = "Harui",
                    HireDate = DateTime.Parse("1998-07-01") },
                new Instructor { FirstMidName = "Candace", LastName = "Kapoor",
                    HireDate = DateTime.Parse("2001-01-15") },
                new Instructor { FirstMidName = "Roger",   LastName = "Zheng",
                    HireDate = DateTime.Parse("2004-02-12") }
                };

                foreach (Instructor i in instructors)
                {
                    context.Instructors.Add(i);
                }
                context.SaveChanges();
            }
            if (!context.Departments.Any())
            { 
            var departments = new Department[]
            {
                new Department { Name = "English",     Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Abercrombie").Id },
                new Department { Name = "Mathematics", Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Fakhouri").Id },
                new Department { Name = "Engineering", Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Harui").Id },
                new Department { Name = "Economics",   Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  =context.Instructors.Single( i => i.LastName == "Kapoor").Id }
            };

            foreach (Department d in departments)
            {
                context.Departments.Add(d);
            }
            context.SaveChanges();
            }
            if (!context.Courses.Any())
            {
                var courses = new Course[]
                {
                new Course {CourseId = 1050, Title = "Chemistry",      Credits = 3,
                    DepartmentId = context.Departments.Single( s => s.Name == "Engineering").DepartmentID
                },
                new Course {CourseId = 4022, Title = "Microeconomics", Credits = 3,
                    DepartmentId = context.Departments.Single( s => s.Name == "Economics").DepartmentID
                },
                new Course {CourseId = 4041, Title = "Macroeconomics", Credits = 3,
                    DepartmentId = context.Departments.Single( s => s.Name == "Economics").DepartmentID
                },
                new Course {CourseId = 1045, Title = "Calculus",       Credits = 4,
                    DepartmentId = context.Departments.Single( s => s.Name == "Mathematics").DepartmentID
                },
                new Course {CourseId = 3141, Title = "Trigonometry",   Credits = 4,
                    DepartmentId = context.Departments.Single( s => s.Name == "Mathematics").DepartmentID
                },
                new Course {CourseId = 2021, Title = "Composition",    Credits = 3,
                    DepartmentId = context.Departments.Single( s => s.Name == "English").DepartmentID
                },
                new Course {CourseId = 2042, Title = "Literature",     Credits = 4,
                    DepartmentId = context.Departments.Single( s => s.Name == "English").DepartmentID
                },
            };

                foreach (Course c in courses)
                {
                    context.Courses.Add(c);
                }
                context.SaveChanges();
            }
            if (!context.OfficeAssignments.Any())
            { 
            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {
                    InstructorID = context.Instructors.Single( i => i.LastName == "Fakhouri").Id,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    InstructorID = context.Instructors.Single( i => i.LastName == "Harui").Id,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    InstructorID = context.Instructors.Single( i => i.LastName == "Kapoor").Id,
                    Location = "Thompson 304" },
            };

            foreach (OfficeAssignment o in officeAssignments)
            {
                context.OfficeAssignments.Add(o);
            }
            context.SaveChanges();
            }

            if (!context.CourseAssignments.Any())
            { 
            var courseInstructors = new CourseAssignment[]
            {
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Kapoor").Id
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").Id
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Microeconomics" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").Id
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Macroeconomics" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").Id
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Calculus" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Fakhouri").Id
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Trigonometry" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").Id
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Composition" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").Id
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Literature" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").Id
                    },
            };

            foreach (CourseAssignment ci in courseInstructors)
            {
                context.CourseAssignments.Add(ci);
            }
            context.SaveChanges();
            }

            if (!context.Enrollments.Any())
            { 
            var enrollments = new Enrollment[]
            {
                new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Alexander").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Chemistry" ).CourseId,
                    Grade = Grade.A
                },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Alexander").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Microeconomics" ).CourseId,
                    Grade = Grade.C
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Alexander").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Macroeconomics" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                        StudentId = context.Students.Single(s => s.LastName == "Alonso").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Calculus" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                        StudentId = context.Students.Single(s => s.LastName == "Alonso").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Trigonometry" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Alonso").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Composition" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Anand").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Chemistry" ).CourseId
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Anand").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Microeconomics").CourseId,
                    Grade = Grade.B
                    },
                new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Barzdukas").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Chemistry").CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Li").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Composition").CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Justice").Id,
                    CourseId = context.Courses.Single(c => c.Title == "Literature").CourseId,
                    Grade = Grade.B
                    }
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s =>
                            s.Student.Id == e.StudentId &&
                            s.Course.CourseId == e.CourseId).SingleOrDefault();
                if (enrollmentInDataBase == null)
                {
                    context.Enrollments.Add(e);
                }
            }
            context.SaveChanges();
            }
        }
    }
}
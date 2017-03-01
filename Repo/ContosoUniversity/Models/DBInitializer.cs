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
                new Student { FirstName = "Carson",   LastName = "Alexander",
                    EnrollmentDate = DateTime.Parse("2010-09-01") },
                new Student { FirstName = "Meredith", LastName = "Alonso",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Arturo",   LastName = "Anand",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstName = "Gytis",    LastName = "Barzdukas",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Yan",      LastName = "Li",
                    EnrollmentDate = DateTime.Parse("2012-09-01") },
                new Student { FirstName = "Peggy",    LastName = "Justice",
                    EnrollmentDate = DateTime.Parse("2011-09-01") },
                new Student { FirstName = "Laura",    LastName = "Norman",
                    EnrollmentDate = DateTime.Parse("2013-09-01") },
                new Student { FirstName = "Nino",     LastName = "Olivetto",
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
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Abercrombie").ID },
                new Department { Name = "Mathematics", Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Fakhouri").ID },
                new Department { Name = "Engineering", Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Harui").ID },
                new Department { Name = "Economics",   Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  =context.Instructors.Single( i => i.LastName == "Kapoor").ID }
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
                    InstructorID = context.Instructors.Single( i => i.LastName == "Fakhouri").ID,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    InstructorID = context.Instructors.Single( i => i.LastName == "Harui").ID,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    InstructorID = context.Instructors.Single( i => i.LastName == "Kapoor").ID,
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
                    InstructorID = context.Instructors.Single(i => i.LastName == "Kapoor").ID
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Microeconomics" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").ID
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Macroeconomics" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").ID
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Calculus" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Fakhouri").ID
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Trigonometry" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Composition" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID
                    },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Literature" ).CourseId,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID
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
                    StudentId = context.Students.Single(s => s.LastName == "Alexander").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Chemistry" ).CourseId,
                    Grade = Grade.A
                },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Alexander").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Microeconomics" ).CourseId,
                    Grade = Grade.C
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Alexander").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Macroeconomics" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                        StudentId = context.Students.Single(s => s.LastName == "Alonso").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Calculus" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                        StudentId = context.Students.Single(s => s.LastName == "Alonso").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Trigonometry" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Alonso").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Composition" ).CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Anand").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Chemistry" ).CourseId
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Anand").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Microeconomics").CourseId,
                    Grade = Grade.B
                    },
                new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Barzdukas").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Chemistry").CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Li").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Composition").CourseId,
                    Grade = Grade.B
                    },
                    new Enrollment {
                    StudentId = context.Students.Single(s => s.LastName == "Justice").ID,
                    CourseId = context.Courses.Single(c => c.Title == "Literature").CourseId,
                    Grade = Grade.B
                    }
            };

            foreach (Enrollment e in enrollments)
            {
                var enrollmentInDataBase = context.Enrollments.Where(
                    s =>
                            s.Student.ID == e.StudentId &&
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
using System;
using StudentEF.Models;

namespace StudentEF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                // ensure database is created
                db.Database.Initialize(false);

                // add a student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now
                };

                db.Students.Add(student);
                db.SaveChanges();

                Console.WriteLine("Student added with ID: " + student.StudentId);
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}

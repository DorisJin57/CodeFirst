using System.Data.Entity;

namespace StudentEF.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("StudentDB")
        {
            Database.SetInitializer<StudentContext>(new CreateDatabaseIfNotExists<StudentContext>());
        }

        public DbSet<Student> Students { get; set; }
    }
}

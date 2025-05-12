using System;
using System.ComponentModel.DataAnnotations;

namespace StudentEF.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime EnrollmentDate { get; set; }
    }
}

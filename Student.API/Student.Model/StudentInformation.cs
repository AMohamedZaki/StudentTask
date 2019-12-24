using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student.Model
{
    public class StudentInformation : BaseEntity<int>
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public byte[] Photo { get; set; }

        // Department Forgin Key
        public Department Departments { get; set; }
        public int DepartmentId { get; set; }

        // Grade Forgin Key
        public Grade Grades { get; set; }
        public int GradeId { get; set; }

        public Classes Classes { get; set; }
        public int ClassId { get; set; }
    }
}

using System;

namespace Student.Model
{
    public class StudentObj : BaseEntity<int>
    {
        public int Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public byte[] Photo { get; set; }

        // Department Forgin Key
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }

        // Grade Forgin Key
        public int GradeId { get; set; }
        public Grade Grades { get; set; }


        public int ClassId { get; set; }
        public Classes Classes_ { get; set; }
    }
}

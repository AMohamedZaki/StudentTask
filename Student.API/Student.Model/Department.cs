using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student.Model
{
    public class Department : BaseEntity<int>
    {
        public string Name { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual ICollection<StudentInformation> Students { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student.Model
{
    public class Grade : BaseEntity<int>
    {
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("GradeId")]
        public virtual ICollection<StudentInformation> Students { get; set; }
    }
}

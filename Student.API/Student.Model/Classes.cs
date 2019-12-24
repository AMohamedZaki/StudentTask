using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Student.Model
{
    public class Classes : BaseEntity<int>
    {
        [StringLength(50)]
        public string Name { get; set; }

        [ForeignKey("ClassId")]
        public virtual ICollection<StudentInformation> Students { get; set; }
    }
}


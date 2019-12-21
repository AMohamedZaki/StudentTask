using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Student.Model
{
    public class Classes : BaseEntity<int>
    {
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<StudentObj> Students { get; set; }
    }
}

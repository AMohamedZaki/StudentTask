using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Student.Model
{
    public class Grade : BaseEntity<int>
    {
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<StudentObj> Students { get; set; }
    }
}

using System.Collections.Generic;

namespace Student.Model
{
    public class Department : BaseEntity<int>
    {
        public string Name { get; set; }
        public ICollection<StudentObj> Students { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; }=string.Empty;
        public int SudentClass { get; set; }
        public int RollNo { get; set; }

    }
}

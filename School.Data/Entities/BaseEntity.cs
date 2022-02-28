using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Data.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public Guid UniqueGuid { get; set; }
        public bool? IsActive { get; set; } = true;
        public bool IsDeleted { get; set; } = false;
    }
}

using System;
using System.Collections.Generic;

namespace Warehouse_DB.Models
{
    public partial class Position
    {
        public Position()
        {
            Employee = new HashSet<Employee>();
        }

        public long PositionId { get; set; }
        public long Name { get; set; }
        public long Salary { get; set; }
        public long Duties { get; set; }
        public long Requests { get; set; }

        public virtual ICollection<Employee> Employee { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace Warehouse_DB.Models
{
    public partial class Employee
    {
        public long EmployeeId { get; set; }
        public long FullName { get; set; }
        public long Age { get; set; }
        public long Sex { get; set; }
        public long Address { get; set; }
        public long PhoneNumber { get; set; }
        public long PassportInformation { get; set; }
        public long PositionId { get; set; }

        public virtual Position Position { get; set; }
    }
}

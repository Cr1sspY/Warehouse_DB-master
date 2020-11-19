using System;
using System.Collections.Generic;

namespace Warehouse_DB.Models
{
    public partial class Provider
    {
        public long ProviderId { get; set; }
        public long Name { get; set; }
        public long Address { get; set; }
        public long PhoneNumber { get; set; }
        public long SuppliedProduct1Id { get; set; }
        public long SuppliedProduct2Id { get; set; }
        public long SuppliedProduct3Id { get; set; }

        public virtual Product SuppliedProduct1 { get; set; }
        public virtual Product SuppliedProduct2 { get; set; }
        public virtual Product SuppliedProduct3 { get; set; }
    }
}

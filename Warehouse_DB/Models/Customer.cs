using System;
using System.Collections.Generic;

namespace Warehouse_DB.Models
{
    public partial class Customer
    {
        public long CustomerId { get; set; }
        public long Name { get; set; }
        public long Address { get; set; }
        public long PhoneNumber { get; set; }
        public long ConsumedProduct1Id { get; set; }
        public long ConsumedProduct2Id { get; set; }
        public long ConsumedProduct3Id { get; set; }

        public virtual Product ConsumedProduct1 { get; set; }
        public virtual Product ConsumedProduct2 { get; set; }
        public virtual Product ConsumedProduct3 { get; set; }
    }
}

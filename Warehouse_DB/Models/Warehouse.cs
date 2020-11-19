using System;
using System.Collections.Generic;

namespace Warehouse_DB.Models
{
    public partial class Warehouse
    {
        public long SupplyDate { get; set; }
        public long OrderDate { get; set; }
        public long ShipmentDate { get; set; }
        public long Volume { get; set; }
        public long Price { get; set; }
        public long TypeOfDelivery { get; set; }
        public long CustomerId { get; set; }
        public long ProductId { get; set; }
        public long EmployeeId { get; set; }
        public long ProviderId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Product Product { get; set; }
        public virtual Provider Provider { get; set; }
    }
}

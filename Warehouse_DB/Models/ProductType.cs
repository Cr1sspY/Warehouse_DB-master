using System;
using System.Collections.Generic;

namespace Warehouse_DB.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            Product = new HashSet<Product>();
        }

        public long TypeId { get; set; }
        public long Name { get; set; }
        public long Description { get; set; }
        public long Feature { get; set; }

        public virtual ICollection<Product> Product { get; set; }
    }
}

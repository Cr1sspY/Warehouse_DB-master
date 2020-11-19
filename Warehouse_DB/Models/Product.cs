using System;
using System.Collections.Generic;

namespace Warehouse_DB.Models
{
    public partial class Product
    {
        public Product()
        {
            CustomerConsumedProduct1 = new HashSet<Customer>();
            CustomerConsumedProduct2 = new HashSet<Customer>();
            CustomerConsumedProduct3 = new HashSet<Customer>();
            ProviderSuppliedProduct1 = new HashSet<Provider>();
            ProviderSuppliedProduct2 = new HashSet<Provider>();
            ProviderSuppliedProduct3 = new HashSet<Provider>();
        }

        public long ProductId { get; set; }
        public long Manufacturer { get; set; }
        public long Name { get; set; }
        public long StorageConditions { get; set; }
        public long Package { get; set; }
        public long ShelfLife { get; set; }
        public long TypeId { get; set; }

        public virtual ProductType Type { get; set; }
        public virtual ICollection<Customer> CustomerConsumedProduct1 { get; set; }
        public virtual ICollection<Customer> CustomerConsumedProduct2 { get; set; }
        public virtual ICollection<Customer> CustomerConsumedProduct3 { get; set; }
        public virtual ICollection<Provider> ProviderSuppliedProduct1 { get; set; }
        public virtual ICollection<Provider> ProviderSuppliedProduct2 { get; set; }
        public virtual ICollection<Provider> ProviderSuppliedProduct3 { get; set; }
    }
}

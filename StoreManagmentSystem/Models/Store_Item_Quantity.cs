namespace StoreManagmentSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Store_Item_Quantity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store_Item_Quantity()
        {
            Sales_Invoice = new HashSet<Sales_Invoice>();
            Supply_Invoice = new HashSet<Supply_Invoice>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string Measure_Name { get; set; }

        [StringLength(10)]
        public string Notes { get; set; }

        public int? Quantity { get; set; }

        public bool? Increment_Decrement { get; set; }

        public bool? Is_Transferred { get; set; }

        public int? Store_Item_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sales_Invoice> Sales_Invoice { get; set; }

        public virtual Store_Item Store_Item { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply_Invoice> Supply_Invoice { get; set; }
    }
}

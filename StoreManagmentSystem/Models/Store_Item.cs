namespace StoreManagmentSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Store_Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Store_Item()
        {
            Store_Item_Quantity = new HashSet<Store_Item_Quantity>();
        }

        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Production_Date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Expiring_Date { get; set; }

        public int? Store_ID { get; set; }

        public int? Item_ID { get; set; }

        public virtual Item Item { get; set; }

        public virtual Store Store { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_Item_Quantity> Store_Item_Quantity { get; set; }
    }
}

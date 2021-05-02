namespace StoreManagmentSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Item")]
    public partial class Item
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Item()
        {
            Store_Item = new HashSet<Store_Item>();
        }

        public int ID { get; set; }

        [StringLength(10)]
        public string Code { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public int? Measure_Unit_ID { get; set; }

        public virtual Measure Measure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Store_Item> Store_Item { get; set; }
    }
}

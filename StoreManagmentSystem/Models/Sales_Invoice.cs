namespace StoreManagmentSystem
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sales_Invoice
    {
        public int ID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }

        public int? Invoice_No { get; set; }

        public int? Store_Item_Quantity_ID { get; set; }

        public int? Customer_ID { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Store_Item_Quantity Store_Item_Quantity { get; set; }
    }
}

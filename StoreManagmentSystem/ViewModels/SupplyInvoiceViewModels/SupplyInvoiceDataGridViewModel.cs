using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.ViewModels.SupplyInvoiceViewModels
{
    class SupplyInvoiceDataGridViewModel
    {
        public int InvoiceId { get; set; }
        [DisplayName("Item Name")]
        public string ItemName { get; set; }
        [DisplayName("Store Name")]
        public string StoreName { get; set; }
        [DisplayName("Used Unit")]
        public string UsedUnit { get; set; }
        public int Quantity { get; set; }
        [DisplayName("Production Date")]
        public string ProductionDate { get; set; }
        [DisplayName("Expiting Date")]
        public string ExpiringDate { get; set; }
        public string Note { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.ViewModels
{
    class FullSupplyInvoice
    {
        public DateTime InvoiceDate { get; set; }
        public int InvoiceNo { get; set; }
        public int VendorId { get; set; }

        public List<SupplyInvoiceViewModel> SupplyInvoiceDetails { get; set; }
    }
}

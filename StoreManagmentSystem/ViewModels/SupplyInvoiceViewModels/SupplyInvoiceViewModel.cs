using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.ViewModels
{
    class SupplyInvoiceViewModel
    {
        public int ItemId { get; set; }
        public int StoreId { get; set; }
        public string UsedUnit { get; set; }
        public int Quantity { get; set; }
        public string ProductionDate { get; set; }
        public string ExpiringDate { get; set; }
        public string Note { get; set; }
    }
}

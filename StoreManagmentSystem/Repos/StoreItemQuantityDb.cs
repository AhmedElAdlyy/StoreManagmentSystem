using StoreManagmentSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.Repos
{
    class StoreItemQuantityDb
    {
        StoreManagmentContext db = new StoreManagmentContext();

        public Store_Item_Quantity GetByID(int id)
        {
            return db.Store_Item_Quantity.Find(id);
        }


        public void EditStoreItemQ(List<SupplyInvoiceViewModel> supplyInvoices)
        {
           
        }
    }
}

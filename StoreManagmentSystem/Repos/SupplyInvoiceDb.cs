using StoreManagmentSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManagmentSystem.Repos
{
    class SupplyInvoiceDb
    {
        StoreManagmentContext db = new StoreManagmentContext();

        public List<Supply_Invoice> GetAllSupplyInvoices()
        {
            return db.Supply_Invoice.ToList();
        }

        public void AddSupplyInvoice(FullSupplyInvoice supplyInvoices)
        {
            foreach (var supplyInvoice in supplyInvoices.SupplyInvoiceDetails)
            {
                Store_Item store_Item = new Store_Item
                {
                    Expiring_Date = supplyInvoice.ExpiringDate,
                    Production_Date = supplyInvoice.ProductionDate,
                    Store_ID = supplyInvoice.StoreId,
                    Item_ID = supplyInvoice.ItemId
                };

                db.Store_Item.Add(store_Item);
                db.SaveChanges();

                Store_Item_Quantity store_Item_Quantity = new Store_Item_Quantity
                {
                    Measure_Name = supplyInvoice.UsedUnit,
                    Notes = supplyInvoice.Note,
                    Quantity = supplyInvoice.Quantity,
                    Increment_Decrement = true,
                    Is_Transferred = false,
                    Store_Item_ID = store_Item.ID
                };

                db.Store_Item_Quantity.Add(store_Item_Quantity);
                db.SaveChanges();

                Supply_Invoice supply_Invoice = new Supply_Invoice
                {
                    Date = supplyInvoices.InvoiceDate,
                    Invoice_No= supplyInvoices.InvoiceNo,
                    Vendor_ID = supplyInvoices.VendorId,
                    Store_Item_Quantity_ID = store_Item_Quantity.ID
                };

                db.Supply_Invoice.Add(supply_Invoice);
                db.SaveChanges();

            }
        }

        public List<Supply_Invoice> GetSupplyInvoicesByInvoiceNo(int invoiceNo)
        {
            return db.Supply_Invoice.Where(w => w.Invoice_No == invoiceNo).ToList();
        }
        
        public void EditSupplyInvoice(FullSupplyInvoice fullSupplyInvoice)
        {
            List<SupplyInvoiceViewModel> details = fullSupplyInvoice.SupplyInvoiceDetails;
            List<Supply_Invoice> rows = db.Supply_Invoice.Where(w => w.Invoice_No == fullSupplyInvoice.InvoiceNo).ToList();
            foreach (var row in rows)
            {
                row.Vendor_ID = fullSupplyInvoice.VendorId;
            }

            for (int i = 0; i < fullSupplyInvoice.SupplyInvoiceDetails.Count; i++)
            {
                rows[i].Store_Item_Quantity.Measure_Name = details[i].UsedUnit;
                rows[i].Store_Item_Quantity.Quantity = details[i].Quantity;
                rows[i].Store_Item_Quantity.Notes = details[i].Note;
                rows[i].Store_Item_Quantity.Store_Item.Production_Date = details[i].ProductionDate;
                rows[i].Store_Item_Quantity.Store_Item.Expiring_Date = details[i].ExpiringDate;
                rows[i].Store_Item_Quantity.Store_Item.Store_ID = details[i].StoreId;
                rows[i].Store_Item_Quantity.Store_Item.Item_ID = details[i].ItemId;
            }

            db.SaveChanges();

            

            


            


        }

    }
}

using StoreManagmentSystem.AssisstantClasses;
using StoreManagmentSystem.Repos;
using StoreManagmentSystem.ViewModels;
using StoreManagmentSystem.ViewModels.SupplyInvoiceViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagmentSystem.Sections.Invoices.SupplyInvoices
{
    public partial class EditSupplyInvoice : Form
    {
        SupplyInvoiceDb db = new SupplyInvoiceDb();
        VendorDb venDb = new VendorDb();
        StoreDb storeDb = new StoreDb();
        ItemDb itemDb = new ItemDb();
        StoreItemDb storeItemDb = new StoreItemDb();
        MeasureDb measureDb = new MeasureDb();
        StoreItemQuantityDb storeItemQuantityDb = new StoreItemQuantityDb();

        Assisstant assisstant = new Assisstant();

        FullSupplyInvoice fullSupplyInvoice = new FullSupplyInvoice();
        //List<SupplyInvoiceDataGridViewModel> supplyInvoiceDataGridViewModels = new List<SupplyInvoiceDataGridViewModel>();
        public EditSupplyInvoice()
        {
            InitializeComponent();
            SettingSupplyInvoiceData();
            
        }

        private void SettingSupplyInvoiceData()
        {
            List<Supply_Invoice> allInvoices = db.GetAllSupplyInvoices();
            List<string> invoiceDates = assisstant.SettingCb_DateDisplay(allInvoices.Select(s => s.Date.Value).Distinct().ToList());
            assisstant.FillCb(cb_invoiceDate, null, null, invoiceDates);
        }

        private void cb_invoiceDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Supply_Invoice> allInvoices = db.GetAllSupplyInvoices();

            if (cb_invoiceDate.SelectedIndex != 0)
            {
                allInvoices = allInvoices.Where(w => w.Date.Value.ToString("dd/MM/yyyy") == cb_invoiceDate.SelectedValue.ToString()).ToList();
            }

            assisstant.FillCb(cb_invoiceNo, null, null, allInvoices.Select(s => s.Invoice_No.Value).Distinct().ToList());
            pl_invoiceNo.Visible = true;

        }

        private void cb_invoiceNo_SelectedIndexChanged(object sender, EventArgs e)
        {

            fullSupplyInvoice = new FullSupplyInvoice();
            
            assisstant.FillCB_ViewBy(cb_viewBy);
            cb_viewBy.SelectedIndex = 0;
            fullSupplyInvoice.InvoiceNo = int.Parse(cb_invoiceNo.SelectedValue.ToString());
            FillData();
            pl_vendorData.Visible = true;
            
        }

        private void cb_viewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string filter = cb_viewBy.SelectedValue.ToString();
            if(cb_viewBy.SelectedIndex != 0)
            {
                pl_vendorName.Visible = true;
                assisstant.FillCb<Vendor>(cb_ven, filter, "ID", venDb.GetAllVedors());
                lb_selectVendor.Text = "Vendor " + filter;
                cb_ven.SelectedValue = fullSupplyInvoice.VendorId;
            }
            
        }

        private void FillData()
        {
            List<Supply_Invoice> invoices = db.GetSupplyInvoicesByInvoiceNo(fullSupplyInvoice.InvoiceNo).ToList();
            fullSupplyInvoice.VendorId = invoices[0].Vendor_ID.Value;
            fullSupplyInvoice.InvoiceDate = invoices[0].Date.Value;

            foreach (var invoice in invoices)
            {
                SupplyInvoiceViewModel supplyInvoiceViewModel = new SupplyInvoiceViewModel
                {
                    InvoiceId = invoice.ID,
                    ExpiringDate = invoice.Store_Item_Quantity.Store_Item.Expiring_Date.Value,
                    ProductionDate = invoice.Store_Item_Quantity.Store_Item.Production_Date.Value,
                    ItemId = invoice.Store_Item_Quantity.Store_Item.Item.ID,
                    Note = invoice.Store_Item_Quantity.Notes,
                    Quantity = invoice.Store_Item_Quantity.Quantity.Value,
                    StoreId = invoice.Store_Item_Quantity.Store_Item.Store.ID,
                    UsedUnit = invoice.Store_Item_Quantity.Measure_Name
                };

                fullSupplyInvoice.SupplyInvoiceDetails.Add(supplyInvoiceViewModel);
            }

        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            if(cb_viewBy.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Valid Data");
            }
            else
            {
                gb_invoice.Visible = true;
                btn_editVendor.Visible = false;
                lb_date.Text = fullSupplyInvoice.InvoiceDate.ToString("dd/MM/yyyy");
                lb_invoiceNumber.Text = fullSupplyInvoice.InvoiceNo.ToString();
                lb_vendor.Text = venDb.GetVendorById(int.Parse(cb_ven.SelectedValue.ToString())).Name;
                fullSupplyInvoice.VendorId = int.Parse(cb_ven.SelectedValue.ToString());
                gb_mainInfo.Enabled = false;

                DisplayDataGrid();

            }
        }

        private void btn_editVendor_Click(object sender, EventArgs e)
        {
            btn_editVendor.Visible = false;
            cb_ven.Enabled = true;
        }

        private void DisplayDataGrid()
        {
            dg_invoiceDetails.DataSource = null;

            List<SupplyInvoiceDataGridViewModel> source = new List<SupplyInvoiceDataGridViewModel>();

            foreach (var invoice in fullSupplyInvoice.SupplyInvoiceDetails)
            {
                SupplyInvoiceDataGridViewModel row = new SupplyInvoiceDataGridViewModel
                {
                    ExpiringDate = invoice.ExpiringDate.ToString("dd/MM/yyyy"),
                    InvoiceId = invoice.InvoiceId,
                    ItemName = itemDb.GetItemById(invoice.ItemId).Name,
                    Note = invoice.Note,
                    ProductionDate = invoice.ExpiringDate.ToString("dd/MM/yyyy"),
                    Quantity = invoice.Quantity,
                    StoreName = storeDb.GetStoreById(invoice.StoreId).Name,
                    UsedUnit = invoice.UsedUnit
                };

                source.Add(row);
            }

            dg_invoiceDetails.DataSource = source;
            dg_invoiceDetails.Columns[0].Visible = false;
        }

        private void dg_invoiceDetails_SelectionChanged(object sender, EventArgs e)
        {
            if(dg_invoiceDetails.SelectedRows.Count != 0)
            {
                int invoiceId = int.Parse(dg_invoiceDetails.SelectedRows[0].Cells[0].Value.ToString());

                fillFields(invoiceId);
            }
        }

        private void fillFields(int invoiceId)
        {

            SupplyInvoiceViewModel invoice = fullSupplyInvoice.SupplyInvoiceDetails.FirstOrDefault(f => f.InvoiceId == invoiceId);

            assisstant.FillCb(cb_item, "Name", "ID", itemDb.GetAllItems());
            cb_item.SelectedValue = invoice.ItemId;

            assisstant.FillCb(cb_store, "Name", "ID", storeDb.GetAllStores());
            cb_store.SelectedValue = invoice.StoreId;

            assisstant.FillCb(cb_measures, null, null, measureDb.GetMeasureItem(invoiceId));
            cb_measures.SelectedItem = invoice.UsedUnit;

            nud_quantity.Value = invoice.Quantity;

            dp_productionDate.Value = invoice.ProductionDate;
            dp_ExpiringDate.Value = invoice.ExpiringDate;

            txt_note.Text = invoice.Note;

            gb_itemData.Visible = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SupplyInvoiceViewModel invoice = fullSupplyInvoice.SupplyInvoiceDetails.FirstOrDefault(f => f.InvoiceId == int.Parse(dg_invoiceDetails.SelectedRows[0].Cells[0].Value.ToString()));

            invoice.ExpiringDate = dp_ExpiringDate.Value;
            invoice.ProductionDate = dp_productionDate.Value;
            invoice.ItemId = int.Parse(cb_item.SelectedValue.ToString());
            invoice.Quantity = (int)nud_quantity.Value;
            invoice.StoreId = int.Parse(cb_store.SelectedValue.ToString());
            invoice.Note = txt_note.Text;
            invoice.UsedUnit = cb_measures.SelectedItem.ToString();

            DisplayDataGrid();

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db.EditSupplyInvoice(fullSupplyInvoice);
        }
    }
}

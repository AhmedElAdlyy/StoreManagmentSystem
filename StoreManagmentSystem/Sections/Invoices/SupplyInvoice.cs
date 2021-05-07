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

namespace StoreManagmentSystem.Sections.Invoices
{
    public partial class SupplyInvoice : Form
    {
        SupplyInvoiceDb db = new SupplyInvoiceDb();
        VendorDb venDb = new VendorDb();
        StoreDb storeDb = new StoreDb();
        ItemDb ItemDb = new ItemDb();
        MeasureDb measureDb = new MeasureDb();
        Assisstant assisstant = new Assisstant();

        List<SupplyInvoiceViewModel> supplyInvoices = new List<SupplyInvoiceViewModel>();
        List<SupplyInvoiceDataGridViewModel> dataGridViewModels = new List<SupplyInvoiceDataGridViewModel>();

        public SupplyInvoice()
        {
            InitializeComponent();
            SettingMainInfoSection();
        }

        private void SettingMainInfoSection()
        {
            txt_currentDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            txt_invoiceNo.Text = assisstant.GetCurrnetInvoiceNo<Supply_Invoice>(db.GetAllSupplyInvoices()).ToString();
            assisstant.FillCb<string>(cb_viewBy, null, null, new List<string> { "Name", "Telephone", "Mobile", "Fax", "Email", "Website" });
        }

        private void cb_viewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cb_viewBy.SelectedValue.ToString();
            assisstant.FillCb<Vendor>(cb_ven, filter, "ID", venDb.GetAllVedors());
            pl_vendor.Visible = true;
            lb_selectVendor.Text = "Vendor " + filter;
        }

        private void btn_cont_Click(object sender, EventArgs e)
        {
            lb_invoiceNumber.Text = txt_invoiceNo.Text;
            lb_date.Text = txt_currentDate.Text;
            lb_vendor.Text = venDb.GetVendorById(int.Parse(cb_ven.SelectedValue.ToString())).Name;

            pl_invoiceLabels.Visible = true;
            gb_invoice.Visible = true;
            gb_itemData.Visible = true;

            assisstant.FillCb<Store>(cb_store, "Name", "ID", storeDb.GetAllStores());
            assisstant.FillCb<AllItemsCb>(cb_item, "NameAndCode", "Id", assisstant.SettingDisplayOfCb_AllItems(ItemDb.GetAllItems()));
        }

        private void cb_item_SelectedIndexChanged(object sender, EventArgs e)
        {
            var measure = measureDb.GetMeasureByItem(int.Parse(cb_item.SelectedValue.ToString()));

            assisstant.FillCb(cb_measures, null, null, new List<string> { measure.Main_Measure, measure.Sub_Measure });
            pl_afterStore.Visible = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            SupplyInvoiceViewModel supplyInvoice = new SupplyInvoiceViewModel
            {
                ExpiringDate = dp_ExpiringDate.Text,
                ItemId = int.Parse(cb_item.SelectedValue.ToString()),
                Note = txt_note.Text,
                ProductionDate = dp_ExpiringDate.Text,
                Quantity = (int)nud_quantity.Value,
                StoreId=int.Parse(cb_store.SelectedValue.ToString()),
                UsedUnit = cb_measures.Text
            };

            supplyInvoices.Add(supplyInvoice);

            DisplayDataGridView(supplyInvoice);
        }

        private void DisplayDataGridView(SupplyInvoiceViewModel supplyInvoice)
        {

            if(dg_invoiceDetails.Visible == false)
            {
                dg_invoiceDetails.Visible = true;
            }

            SupplyInvoiceDataGridViewModel supplyInvoiceDataGrid = new SupplyInvoiceDataGridViewModel
            {
                ExpiringDate = supplyInvoice.ExpiringDate,
                ItemName = ItemDb.GetItemById(supplyInvoice.ItemId).Name,
                Note = supplyInvoice.Note,
                ProductionDate = supplyInvoice.ProductionDate,
                Quantity = supplyInvoice.Quantity,
                StoreName = storeDb.GetStoreById(supplyInvoice.StoreId).Name,
                UsedUnit = supplyInvoice.UsedUnit
            };

            dataGridViewModels.Add(supplyInvoiceDataGrid);
            dg_invoiceDetails.DataSource = null;
            dg_invoiceDetails.DataSource = dataGridViewModels;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FullSupplyInvoice fullSupplyInvoice = new FullSupplyInvoice
            {
                InvoiceDate = Convert.ToDateTime(lb_date.Text),
                InvoiceNo = int.Parse(lb_invoiceNumber.Text),
                VendorId = int.Parse(cb_ven.SelectedValue.ToString()),
                SupplyInvoiceDetails = supplyInvoices
            };
            try
            {
                db.AddSupplyInvoice(fullSupplyInvoice);
                MessageBox.Show("Invoice Saved Successfully");
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong");
            }
            
        }
    }
}

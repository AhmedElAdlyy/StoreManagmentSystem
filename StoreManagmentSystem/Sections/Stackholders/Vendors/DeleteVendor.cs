using StoreManagmentSystem.AssisstantClasses;
using StoreManagmentSystem.Repos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagmentSystem.Sections.Stackholders.Vendors
{
    public partial class DeleteVendor : Form
    {

        VendorDb db = new VendorDb();
        Assisstant assisstant = new Assisstant();

        public DeleteVendor()
        {
            InitializeComponent();
            assisstant.SettingCbFromLabelsText(gb_venData, cb_viewBy);
        }

        private void cb_viewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cb_viewBy.SelectedItem.ToString();

            lb_cst.Text = "Vendor " + filter;

            List<Vendor> vendors = db.GetAllVedors();

            assisstant.FillCb<Vendor>(cb_ven, filter, "ID", vendors);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            Vendor vendor = db.GetVendorById(int.Parse(cb_ven.SelectedValue.ToString()));
            gb_venData.Visible = true;

            txt_venEmail.Text = vendor.Email;
            txt_venId_hide.Text = vendor.ID.ToString();
            txt_venName.Text = vendor.Name;
            txt_venMob.Text = vendor.Mobile;
            txt_venTel.Text = vendor.Telephone;
            txt_venFax.Text = vendor.Fax;
            txt_venWebsite.Text = vendor.Website;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Deleting This Vendor ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    db.DeleteVendorById(int.Parse(txt_venId_hide.Text));
                    MessageBox.Show("Customer Deleted Successfully");
                    RefreshCb_AllVendors();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong try again");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                gb_venData.Visible = false;
            }

        }

        private void RefreshCb_AllVendors()
        {
            gb_venData.Visible = false;
            cb_viewBy.Items.Clear();
            cb_ven.DataSource = null;
            assisstant.SettingCbFromLabelsText(gb_venData, cb_viewBy);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cb_ven.DataSource = null;
            assisstant.SettingCbFromLabelsText(gb_venData, cb_viewBy);
        }
    }
}

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
    public partial class EditVendor : Form
    {
        VendorDb db = new VendorDb();
        Assisstant assisstant = new Assisstant();
        public EditVendor()
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!assisstant.CheckIfFormIsEmpty(gb_venData))
            {
                Vendor vendor = new Vendor
                {
                    ID = int.Parse(txt_venId_hide.Text),
                    Name = txt_venName.Text,
                    Email = txt_venEmail.Text,
                    Fax = txt_venFax.Text,
                    Mobile = txt_venMob.Text,
                    Telephone = txt_venTel.Text,
                    Website = txt_venWebsite.Text
                };

                try
                {
                    db.EditVendor(vendor);
                    MessageBox.Show("Vendor updated successfully");
                    RefreshAll();

                }
                catch (Exception)
                {

                    MessageBox.Show("Something Went Wrong");
                }
            }
            else
            {
                MessageBox.Show("All fields are required to update");
            }
        }

        private void RefreshAll()
        {
            gb_venData.Visible = false;
            cb_ven.DataSource = null;
            cb_viewBy.Items.Clear();
            assisstant.SettingCbFromLabelsText(gb_venData, cb_viewBy);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            cb_ven.DataSource = null;
            cb_viewBy.Items.Clear();
            assisstant.SettingCbFromLabelsText(gb_venData, cb_viewBy);
        }
    }
}

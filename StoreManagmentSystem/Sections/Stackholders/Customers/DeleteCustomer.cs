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

namespace StoreManagmentSystem.Sections.Stackholders.Customers
{
    public partial class DeleteCustomer : Form
    {
        CustomerDb db = new CustomerDb();
        Assisstant assisstant = new Assisstant();
        public DeleteCustomer()
        {
            InitializeComponent();
            assisstant.SettingCbFromLabelsText(gb_cstData, cb_viewBy);
        }

        private void cb_viewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cb_viewBy.SelectedItem.ToString();

            lb_cst.Text = "Customer " + filter;

            List<StoreManagmentSystem.Customer> customers = db.GetAllCustomers();

            assisstant.FillCb<StoreManagmentSystem.Customer>(cb_cst, filter, "ID", customers);
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            StoreManagmentSystem.Customer cst = db.GetCustomerById(int.Parse(cb_cst.SelectedValue.ToString()));
            gb_cstData.Visible = true;

            txt_cstId_hide.Text = cst.ID.ToString();
            txt_cstName.Text = cst.Name;
            txt_cstTel.Text = cst.Telephone;
            txt_cstMob.Text = cst.Mobile;
            txt_cstFax.Text = cst.Fax;
            txt_cstWebsite.Text = cst.Website;
            txt_cstEmail.Text = cst.Website;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Deleting This Customer ?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    db.DeleteCustomerById(int.Parse(txt_cstId_hide.Text));
                    MessageBox.Show("Customer Deleted Successfully");
                    RefreshCb_AllCustomers();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong try again");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                gb_cstData.Visible = false;
            }
        }

        private void RefreshCb_AllCustomers()
        {
            gb_cstData.Visible = false;
            cb_viewBy.Items.Clear();
            cb_cst.DataSource = null;
            assisstant.SettingCbFromLabelsText(gb_cstData, cb_viewBy);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshCb_AllCustomers();
        }
    }
}

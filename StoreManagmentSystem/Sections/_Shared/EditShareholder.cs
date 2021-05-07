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
    public partial class EditCustomer : Form
    {

        CustomerDb db = new CustomerDb();
        Assisstant assisstant = new Assisstant();

        public EditCustomer()
        {
            InitializeComponent();
            assisstant.SettingCbFromLabelsText(gb_cstData, cb_viewBy);
        }


        private void cb_viewBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = cb_viewBy.SelectedItem.ToString();

            lb_cst.Text = "Customer " + filter;

            List<StoreManagmentSystem.Customer> customers = db.GetAllCustomers();

            cb_cst.ValueMember = "ID";
            cb_cst.DisplayMember = filter;

            cb_cst.DataSource = customers;
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!assisstant.CheckIfFormIsEmpty(gb_cstData))
            {
                StoreManagmentSystem.Customer cst = new StoreManagmentSystem.Customer
                {
                    ID = int.Parse(txt_cstId_hide.Text),
                    Email = txt_cstEmail.Text,
                    Fax = txt_cstFax.Text,
                    Mobile = txt_cstMob.Text,
                    Name = txt_cstName.Text,
                    Telephone = txt_cstTel.Text,
                    Website = txt_cstWebsite.Text
                };

                try
                {
                    db.EditCustomer(cst);
                    MessageBox.Show("Customer Updated Successfully");
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
            gb_cstData.Visible = false;
            cb_cst.DataSource = null;
            cb_viewBy.Items.Clear();
            assisstant.SettingCbFromLabelsText(gb_cstData, cb_viewBy);
        }
    }
}

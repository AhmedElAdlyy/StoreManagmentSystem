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

namespace StoreManagmentSystem.Stores
{
    public partial class DeleteStore : Form
    {
        StoreDb db = new StoreDb();
        public DeleteStore()
        {
            InitializeComponent();
            SettingCb_allStores();
        }

        private void SettingCb_allStores()
        {
            List<Store> stores = db.GetAllStores();

            cb_allStores.DisplayMember = "Name";
            cb_allStores.ValueMember = "ID";
            cb_allStores.DataSource = stores;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Deleting This Store ?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    db.DeleteStoreById(int.Parse(txt_storeId_hide.Text));
                    MessageBox.Show("Store Deleted Successfully");
                    RefreshCb_AllStores();
                }
                catch (Exception)
                {
                    MessageBox.Show("something went wrong");
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                gb_storeData.Visible = false;
            }

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            gb_storeData.Visible = true;

            int id = int.Parse(cb_allStores.SelectedValue.ToString());
            Store store = db.GetStoreById(id);

            txt_storeId_hide.Text = store.ID.ToString();
            txt_Name.Text = store.Name;
            txt_address.Text = store.Address;
            txt_Employee.Text = store.Responsible_Employee;
        }

        private void RefreshCb_AllStores()
        {
            cb_allStores.DataSource = null;
            SettingCb_allStores();
        }
    }
}

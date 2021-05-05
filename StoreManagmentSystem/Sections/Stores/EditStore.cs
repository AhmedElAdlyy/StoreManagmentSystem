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
    public partial class EditStore : Form
    {

        StoreDb db = new StoreDb();
        public EditStore()
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

        private void btn_edit_Click(object sender, EventArgs e)
        {

            if (!isEmpty())
            {
                Store newStore = new Store
                {
                    ID = int.Parse(txt_storeId_hide.Text),
                    Name = txt_Name.Text,
                    Address = txt_address.Text,
                    Responsible_Employee = txt_Employee.Text
                };

                try
                {
                    db.EditStore(newStore);
                    MessageBox.Show("Store Updated Successfully");
                    RefreshCb_AllStores();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong try again");
                }
            }
            else
            {
                MessageBox.Show("All fields are required to edit");
            }

            
        }

        private void RefreshCb_AllStores()
        {
            gb_storeData.Visible = false;
            cb_allStores.DataSource = null;
            SettingCb_allStores();
        }

        private bool isEmpty()
        {
            bool isEmpty = true;

            if (txt_Name.Text != string.Empty && txt_address.Text != string.Empty && txt_Employee.Text != string.Empty)
            {
                isEmpty = false;
            }

            return isEmpty;

        }
    }
}

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

namespace StoreManagmentSystem.Stores
{
    public partial class EditStore : Form
    {

        StoreDb db = new StoreDb();
        Assisstant assisstant = new Assisstant();
        public EditStore()
        {
            InitializeComponent();
            assisstant.FillCb<Store>(cb_allStores, "Name", "ID", db.GetAllStores());
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

            if (!assisstant.CheckIfFormIsEmpty(gb_storeData)) 
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
            assisstant.FillCb<Store>(cb_allStores, "Name", "ID", db.GetAllStores());
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshCb_AllStores();
        }
    }
}

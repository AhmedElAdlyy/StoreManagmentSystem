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

namespace StoreManagmentSystem
{
    public partial class AddStore : Form
    {

        StoreDb db = new StoreDb();
        Assisstant assisstant = new Assisstant();

        public AddStore()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            if (!assisstant.CheckIfFormIsEmpty(gb_storeData))
            {
                Store store = new Store
                {
                    Name = txt_Name.Text,
                    Address = txt_address.Text,
                    Responsible_Employee = txt_Employee.Text
                };

                try
                {
                    db.AddStore(store);
                    MessageBox.Show("Store Is Added Successfully");
                    assisstant.ClearForm(gb_storeData);
                }
                catch (Exception)
                {
                    MessageBox.Show("Data Is Incorrect");
                }
            }
            else
            {
                MessageBox.Show("Fill All Data!");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            assisstant.ClearForm(gb_storeData);
        }
    }
}

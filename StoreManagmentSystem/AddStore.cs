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

        public AddStore()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var empty = isEmpty();

            if (!empty)
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

        private bool isEmpty()
        {
            bool isEmpty = true;

            if(txt_Name.Text != string.Empty && txt_address.Text != string.Empty && txt_Employee.Text != string.Empty)
            {
                isEmpty = false;
            }

            return isEmpty;

        }
    }
}

using StoreManagmentSystem.AssisstantClasses;
using StoreManagmentSystem.Repos;
using StoreManagmentSystem.Sections.Stackholders.Customer;
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
    public partial class AddVendor : Form
    {
        VendorDb db = new VendorDb();
        Assisstant assisstant = new Assisstant();
        public AddVendor()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!assisstant.CheckIfFormIsEmpty(gb_venData))
            {
                Vendor vendor = new Vendor
                {
                    Email = txt_venEmail.Text,
                    Fax = txt_venFax.Text,
                    Mobile = txt_venMob.Text,
                    Name = txt_venName.Text,
                    Telephone = txt_venTel.Text,
                    Website = txt_venWebsite.Text
                };

                try
                {
                    db.AddVendor(vendor);
                    MessageBox.Show("Vendor Added Successfully");
                    assisstant.ClearForm(gb_venData);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something Went Wrong");
                }

            }
            else
            {
                MessageBox.Show("All fields are requires");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            assisstant.ClearForm(gb_venData);
        }
    }
}

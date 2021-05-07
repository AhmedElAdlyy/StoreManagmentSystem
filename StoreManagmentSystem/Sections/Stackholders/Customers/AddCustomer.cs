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


namespace StoreManagmentSystem.Sections.Stackholders.Customer
{
    public partial class AddCustomer : Form
    {

        CustomerDb db = new CustomerDb();
        Assisstant assisstant = new Assisstant();

        public AddCustomer()
        {
            InitializeComponent();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!assisstant.CheckIfFormIsEmpty(gb_cstData))
            {
                StoreManagmentSystem.Customer cst = new StoreManagmentSystem.Customer
                {
                    Name = txt_cstName.Text,
                    Email = txt_cstEmail.Text,
                    Fax = txt_cstFax.Text,
                    Mobile = txt_cstMob.Text,
                    Telephone = txt_cstTel.Text,
                    Website = txt_cstWebsite.Text
                };

                try
                {
                    db.AddCustomer(cst);
                    MessageBox.Show("Customer Added Successfully");
                    assisstant.ClearForm(gb_cstData);
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
            assisstant.ClearForm(gb_cstData);
        }
    }
}

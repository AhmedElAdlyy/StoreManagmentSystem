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

        public AddCustomer()
        {
            InitializeComponent();
        }


        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
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



        private bool IsEmpty()
        {
            bool isEmpty = true;

            foreach (Control ctrl in this.gb_cstData.Controls)
            {
                if (ctrl is TextBox)
                {
                    if (ctrl.Text != string.Empty)
                    {
                        isEmpty = false;
                    }
                    else
                    {
                        isEmpty = true;
                        return isEmpty;
                    }
                }
            }
            return isEmpty;
        }


    }
}

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

namespace StoreManagmentSystem.Sections.Measures
{
    public partial class AddMeasure : Form
    {
        MeasureDb db = new MeasureDb();
        public AddMeasure()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                Measure measure = new Measure
                {
                    Main_Measure = txt_main.Text,
                    Sub_Measure = txt_sub.Text,
                    Quantity = int.Parse(txt_quantity.Text)
                };
                try
                {
                    db.addMeasure(measure);
                    MessageBox.Show("Measure Added Successfully");
                }
                catch (Exception)
                {

                    MessageBox.Show("Somethig wrong");
                }
                
            }
            else
            {
                MessageBox.Show("Fill All Data!");
            }
        }


        private bool IsEmpty()
        {
            bool isEmpty = true;

            if(txt_main.Text != string.Empty && txt_quantity.Text != string.Empty && txt_sub.Text != string.Empty)
            {
                isEmpty = false;
            }
            return isEmpty;
        }
    }
}

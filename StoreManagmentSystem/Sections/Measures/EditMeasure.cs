using StoreManagmentSystem.Repos;
using StoreManagmentSystem.ViewModels;
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
    public partial class EditMeasure : Form
    {
        MeasureDb db = new MeasureDb();
        public EditMeasure()
        {
            InitializeComponent();
            settingCb_AllMeasures();
        }

        private void settingCb_AllMeasures()
        {
            List<AllMeasuresCb> measuresModifiedFormat = db.settingDisplayOfCb_AllMeasures(db.GetAllMeasures());

            cb_selectMeasure.DisplayMember = "Description";
            cb_selectMeasure.ValueMember = "Id";
            cb_selectMeasure.DataSource = measuresModifiedFormat;

        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            gb_measureDetails.Visible = true;

            Measure measure = db.GetMeasureById(int.Parse(cb_selectMeasure.SelectedValue.ToString()));

            txt_main.Text = measure.Main_Measure;
            txt_measureID_hide.Text = measure.ID.ToString();
            txt_quantity.Text = measure.Quantity.ToString();
            txt_sub.Text = measure.Sub_Measure;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!IsEmpty())
            {
                Measure measure = new Measure
                {
                    ID = int.Parse(txt_measureID_hide.Text),
                    Main_Measure = txt_main.Text,
                    Sub_Measure = txt_sub.Text,
                    Quantity = int.Parse(txt_quantity.Text)
                };

                try
                {
                    db.EditMeasure(measure);
                    MessageBox.Show("Measure Updated Successfully");
                    RefreshCb_AllMeasures();
                }
                catch (Exception)
                {
                    MessageBox.Show("something went wrong");
                }
            }
            else
            {
                MessageBox.Show("All fields are required to edit");
            }
        }

        private bool IsEmpty()
        {
            bool isEmpty = true;

            if (txt_main.Text != string.Empty && txt_quantity.Text != string.Empty && txt_sub.Text != string.Empty)
            {
                isEmpty = false;
            }
            return isEmpty;
        }

        private void RefreshCb_AllMeasures()
        {
            gb_measureDetails.Visible = false;
            cb_selectMeasure.DataSource = null;
            settingCb_AllMeasures();
        }
    }
}

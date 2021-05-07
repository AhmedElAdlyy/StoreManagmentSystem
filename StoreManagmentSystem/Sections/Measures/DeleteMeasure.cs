using StoreManagmentSystem.AssisstantClasses;
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
    public partial class DeleteMeasure : Form
    {
        MeasureDb db = new MeasureDb();
        Assisstant Assisstant = new Assisstant();
        public DeleteMeasure()
        {
            InitializeComponent();
            settingCb_AllMeasures();
        }

        private void settingCb_AllMeasures()
        {
            List<AllMeasuresCb> measuresModifiedFormat = Assisstant.settingDisplayOfCb_AllMeasures(db.GetAllMeasures());
            Assisstant.FillCb<AllMeasuresCb>(cb_selectMeasure, "Description", "Id", measuresModifiedFormat);

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
            DialogResult dialogResult = MessageBox.Show("Are You Sure Deleting This Measure ?", "Delete Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    db.DeleteMeasureById(int.Parse(txt_measureID_hide.Text));
                    MessageBox.Show("Measure Deleted Successfully");
                    RefreshCb_AllMeasures();
                }
                catch (Exception)
                {
                    throw;
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                gb_measureDetails.Visible = false;
            }
        }

        private void RefreshCb_AllMeasures()
        {
            gb_measureDetails.Visible = false;
            cb_selectMeasure.DataSource = null;
            settingCb_AllMeasures();
        }
    }
}

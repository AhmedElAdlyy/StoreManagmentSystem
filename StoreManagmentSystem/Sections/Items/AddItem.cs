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

namespace StoreManagmentSystem.Sections.Items
{
    public partial class AddItem : Form
    {
        ItemDb db = new ItemDb();
        MeasureDb MeasureDb = new MeasureDb();
        Assisstant assisstant = new Assisstant();
        public AddItem()
        {
            InitializeComponent();
            SettingCb_Measures();
        }

        private void SettingCb_Measures()
        {
            assisstant.FillCb<AllMeasuresCb>(cb_unitMeasure, "Description", "Id", assisstant.settingDisplayOfCb_AllMeasures(MeasureDb.GetAllMeasures()));
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            if (!assisstant.CheckIfFormIsEmpty(gb_itemData))
            {
                Item item = new Item
                {
                    Name = txt_name.Text,
                    Code = txt_code.Text,
                    Measure_Unit_ID = int.Parse(cb_unitMeasure.SelectedValue.ToString())
                };

                try
                {
                    db.AddItem(item);
                    MessageBox.Show("Item Added Successfully");
                    RefreshAll();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong try again");
                }

            }
            else
            {
                MessageBox.Show("All fields are required");
            }
        }
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }

        public void RefreshAll()
        {
            assisstant.ClearForm(gb_itemData);
            cb_unitMeasure.DataSource = null;
            SettingCb_Measures();
        }

    }
}

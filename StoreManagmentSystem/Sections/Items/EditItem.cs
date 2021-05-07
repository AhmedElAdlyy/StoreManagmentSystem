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
    public partial class EditItem : Form
    {
        ItemDb db = new ItemDb();
        MeasureDb MeasureDb = new MeasureDb();
        Assisstant assisstant = new Assisstant();

        public EditItem()
        {
            InitializeComponent();
            SettingCb_Measures();
            SettingCb_Items();
        }

        private void SettingCb_Measures()
        {
            assisstant.FillCb<AllMeasuresCb>(cb_measureUnit, "Description", "Id", assisstant.settingDisplayOfCb_AllMeasures(MeasureDb.GetAllMeasures()));
        }

        private void SettingCb_Items()
        {
            assisstant.FillCb<AllItemsCb>(cb_item, "NameAndCode", "Id", assisstant.SettingDisplayOfCb_AllItems(db.GetAllItems()));
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            Item item = db.GetItemById(int.Parse(cb_item.SelectedValue.ToString()));
            gb_itemData.Visible = true;

            txt_ItemId_hide.Text = item.ID.ToString();
            txt_name.Text = item.Name;
            txt_code.Text = item.Code;
            cb_measureUnit.SelectedValue = item.Measure_Unit_ID;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (!assisstant.CheckIfFormIsEmpty(gb_itemData))
            {
                Item item = new Item
                {
                    ID = int.Parse(txt_ItemId_hide.Text.ToString()),
                    Code = txt_code.Text,
                    Name = txt_name.Text,
                    Measure_Unit_ID = int.Parse(cb_measureUnit.SelectedValue.ToString())
                };

                try
                {
                    db.EditItem(item);
                    MessageBox.Show("Item Updated Successfully");
                    RefreshAll();

                }
                catch (Exception)
                {
                    MessageBox.Show("Something Went wrong");
                }
            }
            else
            {
                MessageBox.Show("All fields are required to edit");
            }
        }

        private void RefreshAll()
        {
            gb_itemData.Visible = false;
            cb_item.DataSource = null;
            SettingCb_Items();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshAll();
        }
    }
}

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
    public partial class DeleteItem : Form
    {
        ItemDb db = new ItemDb();
        Assisstant assisstant = new Assisstant();
        public DeleteItem()
        {
            InitializeComponent();
            SettingCb_Items();
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
            txt_measureId.Text = item.Measure_Unit_ID.ToString();
            txt_code.Text = item.Code;
            txt_name.Text = item.Name;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure Deleting This Item ?", "Delete Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    db.DeleteItemById(int.Parse(txt_ItemId_hide.Text));
                    MessageBox.Show("Item Deleted Successfully");
                    RefreshAll();
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                gb_itemData.Visible = false;
            }
        }

        private void RefreshAll()
        {
            cb_item.DataSource = null;
            SettingCb_Items();
            gb_itemData.Visible = false;
        }
    }
}

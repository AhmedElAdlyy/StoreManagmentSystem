using StoreManagmentSystem.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagmentSystem.AssisstantClasses
{
    public class Assisstant
    {
        public void SettingCbFromLabelsText(GroupBox gb, ComboBox cb)
        {

            foreach (Control ctrl in gb.Controls)
            {
                if (ctrl is Label)
                {
                    cb.Items.Add(ctrl.Text);
                }
            }

        }
        public bool CheckIfFormIsEmpty(GroupBox gb)
        {
            bool isEmpty = true;

            foreach (Control ctrl in gb.Controls)
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

        public void ClearForm(GroupBox gb)
        {
            foreach (Control ctrl in gb.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = string.Empty;
                }
            }
        }


        public List<AllMeasuresCb> settingDisplayOfCb_AllMeasures(List<Measure> measures)
        {
            List<AllMeasuresCb> allMeasures = new List<AllMeasuresCb>();

            foreach (var measure in measures)
            {
                AllMeasuresCb m = new AllMeasuresCb
                {
                    Id = measure.ID,
                    Description = measure.Main_Measure + " - " + measure.Sub_Measure + " - " + measure.Quantity
                };

                allMeasures.Add(m);
            }

            return allMeasures;
        }

        public void FillCb<T>(ComboBox cb, string display, string value, List<T> source)
        {
            cb.ValueMember = value;
            cb.DisplayMember = display;
            cb.DataSource = source;
        }

        public List<AllItemsCb> SettingDisplayOfCb_AllItems(List<Item> items)
        {
            List<AllItemsCb> allItems = new List<AllItemsCb>();

            foreach (var item in items)
            {
                AllItemsCb it = new AllItemsCb
                {
                    Id = item.ID,
                    NameAndCode = item.Name + " - " + item.Code,
                };

                allItems.Add(it);
            }

            return allItems;
        }

        public int GetCurrnetInvoiceNo(List<int> invoicesNumbers)
        {
            int current;
            if(invoicesNumbers.Count == 0)
            {
                current = 1;
            }
            else
            {
                current = invoicesNumbers.Max();
                current++;
            }
            return current;
        }

        public List<string> SettingCb_DateDisplay(List<DateTime> dates)
        {
            List<string> outputDates = new List<string>();
            outputDates.Add("---All---");

            foreach (var date in dates)
            {
                outputDates.Add(date.ToString("dd/MM/yyyy"));
            }

            return outputDates;
        }

        public void FillCB_ViewBy(ComboBox cb)
        {
            FillCb<string>(cb, null, null, new List<string> {"---View Vendor By---" , "Name", "Telephone", "Mobile", "Fax", "Email", "Website" });
        }

        

    }
}

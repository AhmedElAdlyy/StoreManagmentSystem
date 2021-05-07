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

        
    }
}

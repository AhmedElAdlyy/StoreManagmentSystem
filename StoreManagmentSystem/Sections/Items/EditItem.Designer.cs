
namespace StoreManagmentSystem.Sections.Items
{
    partial class EditItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_selectItem = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.txt_ItemId_hide = new System.Windows.Forms.TextBox();
            this.gb_itemData = new System.Windows.Forms.GroupBox();
            this.cb_measureUnit = new System.Windows.Forms.ComboBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.gb_selectItem.SuspendLayout();
            this.gb_itemData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_selectItem
            // 
            this.gb_selectItem.Controls.Add(this.btn_select);
            this.gb_selectItem.Controls.Add(this.cb_item);
            this.gb_selectItem.Location = new System.Drawing.Point(105, 23);
            this.gb_selectItem.Name = "gb_selectItem";
            this.gb_selectItem.Size = new System.Drawing.Size(406, 104);
            this.gb_selectItem.TabIndex = 0;
            this.gb_selectItem.TabStop = false;
            this.gb_selectItem.Text = "Select Item";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(325, 33);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 40);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(31, 40);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(278, 28);
            this.cb_item.TabIndex = 1;
            // 
            // txt_ItemId_hide
            // 
            this.txt_ItemId_hide.Location = new System.Drawing.Point(260, 133);
            this.txt_ItemId_hide.Name = "txt_ItemId_hide";
            this.txt_ItemId_hide.Size = new System.Drawing.Size(100, 26);
            this.txt_ItemId_hide.TabIndex = 1;
            this.txt_ItemId_hide.Visible = false;
            // 
            // gb_itemData
            // 
            this.gb_itemData.Controls.Add(this.cb_measureUnit);
            this.gb_itemData.Controls.Add(this.btn_edit);
            this.gb_itemData.Controls.Add(this.txt_code);
            this.gb_itemData.Controls.Add(this.txt_name);
            this.gb_itemData.Controls.Add(this.label3);
            this.gb_itemData.Controls.Add(this.label2);
            this.gb_itemData.Controls.Add(this.label1);
            this.gb_itemData.Location = new System.Drawing.Point(70, 168);
            this.gb_itemData.Name = "gb_itemData";
            this.gb_itemData.Size = new System.Drawing.Size(497, 381);
            this.gb_itemData.TabIndex = 2;
            this.gb_itemData.TabStop = false;
            this.gb_itemData.Text = "Item Data";
            this.gb_itemData.Visible = false;
            // 
            // cb_measureUnit
            // 
            this.cb_measureUnit.FormattingEnabled = true;
            this.cb_measureUnit.Location = new System.Drawing.Point(210, 250);
            this.cb_measureUnit.Name = "cb_measureUnit";
            this.cb_measureUnit.Size = new System.Drawing.Size(265, 28);
            this.cb_measureUnit.TabIndex = 5;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(177, 307);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(113, 53);
            this.btn_edit.TabIndex = 11;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(210, 145);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(265, 26);
            this.txt_code.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(210, 43);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(265, 26);
            this.txt_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Measure Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(555, 550);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 39);
            this.btn_refresh.TabIndex = 12;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gb_itemData);
            this.Controls.Add(this.txt_ItemId_hide);
            this.Controls.Add(this.gb_selectItem);
            this.Name = "EditItem";
            this.Text = "EditItem";
            this.gb_selectItem.ResumeLayout(false);
            this.gb_itemData.ResumeLayout(false);
            this.gb_itemData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_selectItem;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.TextBox txt_ItemId_hide;
        private System.Windows.Forms.GroupBox gb_itemData;
        private System.Windows.Forms.ComboBox cb_measureUnit;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_refresh;
    }
}
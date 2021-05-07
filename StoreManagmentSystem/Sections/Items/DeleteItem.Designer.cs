
namespace StoreManagmentSystem.Sections.Items
{
    partial class DeleteItem
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
            this.gb_itemData = new System.Windows.Forms.GroupBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ItemId_hide = new System.Windows.Forms.TextBox();
            this.gb_selectItem = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_measureId = new System.Windows.Forms.TextBox();
            this.gb_itemData.SuspendLayout();
            this.gb_selectItem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_itemData
            // 
            this.gb_itemData.Controls.Add(this.txt_measureId);
            this.gb_itemData.Controls.Add(this.btn_delete);
            this.gb_itemData.Controls.Add(this.txt_code);
            this.gb_itemData.Controls.Add(this.txt_name);
            this.gb_itemData.Controls.Add(this.label3);
            this.gb_itemData.Controls.Add(this.label2);
            this.gb_itemData.Controls.Add(this.label1);
            this.gb_itemData.Location = new System.Drawing.Point(83, 180);
            this.gb_itemData.Name = "gb_itemData";
            this.gb_itemData.Size = new System.Drawing.Size(497, 381);
            this.gb_itemData.TabIndex = 5;
            this.gb_itemData.TabStop = false;
            this.gb_itemData.Text = "Item Data";
            this.gb_itemData.Visible = false;
            // 
            // txt_code
            // 
            this.txt_code.Enabled = false;
            this.txt_code.Location = new System.Drawing.Point(210, 145);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(265, 26);
            this.txt_code.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Enabled = false;
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
            // txt_ItemId_hide
            // 
            this.txt_ItemId_hide.Location = new System.Drawing.Point(273, 145);
            this.txt_ItemId_hide.Name = "txt_ItemId_hide";
            this.txt_ItemId_hide.Size = new System.Drawing.Size(100, 26);
            this.txt_ItemId_hide.TabIndex = 4;
            this.txt_ItemId_hide.Visible = false;
            // 
            // gb_selectItem
            // 
            this.gb_selectItem.Controls.Add(this.btn_select);
            this.gb_selectItem.Controls.Add(this.cb_item);
            this.gb_selectItem.Location = new System.Drawing.Point(118, 35);
            this.gb_selectItem.Name = "gb_selectItem";
            this.gb_selectItem.Size = new System.Drawing.Size(406, 104);
            this.gb_selectItem.TabIndex = 3;
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
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.DarkRed;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_delete.Location = new System.Drawing.Point(177, 305);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(113, 53);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_measureId
            // 
            this.txt_measureId.Enabled = false;
            this.txt_measureId.Location = new System.Drawing.Point(210, 247);
            this.txt_measureId.Name = "txt_measureId";
            this.txt_measureId.Size = new System.Drawing.Size(265, 26);
            this.txt_measureId.TabIndex = 11;
            // 
            // DeleteItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.gb_itemData);
            this.Controls.Add(this.txt_ItemId_hide);
            this.Controls.Add(this.gb_selectItem);
            this.Name = "DeleteItem";
            this.Text = "DeleteItem";
            this.gb_itemData.ResumeLayout(false);
            this.gb_itemData.PerformLayout();
            this.gb_selectItem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_itemData;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ItemId_hide;
        private System.Windows.Forms.GroupBox gb_selectItem;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.TextBox txt_measureId;
    }
}
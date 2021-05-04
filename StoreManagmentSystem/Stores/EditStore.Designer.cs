
namespace StoreManagmentSystem.Stores
{
    partial class EditStore
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
            this.gb_selectStore = new System.Windows.Forms.GroupBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.cb_allStores = new System.Windows.Forms.ComboBox();
            this.gb_storeData = new System.Windows.Forms.GroupBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_Employee = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_storeId_hide = new System.Windows.Forms.TextBox();
            this.gb_selectStore.SuspendLayout();
            this.gb_storeData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_selectStore
            // 
            this.gb_selectStore.Controls.Add(this.btn_select);
            this.gb_selectStore.Controls.Add(this.cb_allStores);
            this.gb_selectStore.Location = new System.Drawing.Point(125, 23);
            this.gb_selectStore.Name = "gb_selectStore";
            this.gb_selectStore.Size = new System.Drawing.Size(406, 104);
            this.gb_selectStore.TabIndex = 0;
            this.gb_selectStore.TabStop = false;
            this.gb_selectStore.Text = "Select Store";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(325, 33);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 40);
            this.btn_select.TabIndex = 1;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // cb_allStores
            // 
            this.cb_allStores.FormattingEnabled = true;
            this.cb_allStores.Location = new System.Drawing.Point(31, 40);
            this.cb_allStores.Name = "cb_allStores";
            this.cb_allStores.Size = new System.Drawing.Size(278, 28);
            this.cb_allStores.TabIndex = 0;
            // 
            // gb_storeData
            // 
            this.gb_storeData.Controls.Add(this.btn_edit);
            this.gb_storeData.Controls.Add(this.txt_Employee);
            this.gb_storeData.Controls.Add(this.txt_address);
            this.gb_storeData.Controls.Add(this.txt_Name);
            this.gb_storeData.Controls.Add(this.label3);
            this.gb_storeData.Controls.Add(this.label2);
            this.gb_storeData.Controls.Add(this.label1);
            this.gb_storeData.Location = new System.Drawing.Point(93, 183);
            this.gb_storeData.Name = "gb_storeData";
            this.gb_storeData.Size = new System.Drawing.Size(497, 381);
            this.gb_storeData.TabIndex = 1;
            this.gb_storeData.TabStop = false;
            this.gb_storeData.Text = "Store Data";
            this.gb_storeData.Visible = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(165, 306);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(113, 53);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_Employee
            // 
            this.txt_Employee.Location = new System.Drawing.Point(210, 250);
            this.txt_Employee.Name = "txt_Employee";
            this.txt_Employee.Size = new System.Drawing.Size(265, 26);
            this.txt_Employee.TabIndex = 8;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(210, 145);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(265, 26);
            this.txt_address.TabIndex = 7;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(210, 43);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(265, 26);
            this.txt_Name.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Responsible Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Store Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Store Name";
            // 
            // txt_storeId_hide
            // 
            this.txt_storeId_hide.Location = new System.Drawing.Point(258, 151);
            this.txt_storeId_hide.Name = "txt_storeId_hide";
            this.txt_storeId_hide.Size = new System.Drawing.Size(100, 26);
            this.txt_storeId_hide.TabIndex = 2;
            this.txt_storeId_hide.Visible = false;
            // 
            // EditStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.txt_storeId_hide);
            this.Controls.Add(this.gb_storeData);
            this.Controls.Add(this.gb_selectStore);
            this.Name = "EditStore";
            this.Text = "EditStore";
            this.gb_selectStore.ResumeLayout(false);
            this.gb_storeData.ResumeLayout(false);
            this.gb_storeData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_selectStore;
        private System.Windows.Forms.ComboBox cb_allStores;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.GroupBox gb_storeData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_Employee;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_storeId_hide;
    }
}

namespace StoreManagmentSystem.Sections.Invoices
{
    partial class AddSupplyInvoice
    {
        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_SIData = new System.Windows.Forms.GroupBox();
            this.txt_currentDate = new System.Windows.Forms.TextBox();
            this.txt_invoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pl_vendor = new System.Windows.Forms.Panel();
            this.cb_ven = new System.Windows.Forms.ComboBox();
            this.lb_selectVendor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_viewBy = new System.Windows.Forms.ComboBox();
            this.gb_mainInfo = new System.Windows.Forms.GroupBox();
            this.btn_cont = new System.Windows.Forms.Button();
            this.gb_itemData = new System.Windows.Forms.GroupBox();
            this.pl_afterStore = new System.Windows.Forms.Panel();
            this.txt_note = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.nud_quantity = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dp_ExpiringDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_measures = new System.Windows.Forms.ComboBox();
            this.dp_productionDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_store = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_item = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_divider = new System.Windows.Forms.Label();
            this.gb_invoice = new System.Windows.Forms.GroupBox();
            this.pl_invoiceLabels = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_date = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_vendor = new System.Windows.Forms.Label();
            this.lb_invoiceNumber = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.dg_invoiceDetails = new System.Windows.Forms.DataGridView();
            this.gb_SIData.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pl_vendor.SuspendLayout();
            this.gb_mainInfo.SuspendLayout();
            this.gb_itemData.SuspendLayout();
            this.pl_afterStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).BeginInit();
            this.gb_invoice.SuspendLayout();
            this.pl_invoiceLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_invoiceDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_SIData
            // 
            this.gb_SIData.Controls.Add(this.txt_currentDate);
            this.gb_SIData.Controls.Add(this.txt_invoiceNo);
            this.gb_SIData.Controls.Add(this.label2);
            this.gb_SIData.Controls.Add(this.label1);
            this.gb_SIData.Location = new System.Drawing.Point(31, 39);
            this.gb_SIData.Name = "gb_SIData";
            this.gb_SIData.Size = new System.Drawing.Size(349, 121);
            this.gb_SIData.TabIndex = 0;
            this.gb_SIData.TabStop = false;
            this.gb_SIData.Text = "Supply Invoice Data";
            // 
            // txt_currentDate
            // 
            this.txt_currentDate.Enabled = false;
            this.txt_currentDate.Location = new System.Drawing.Point(127, 40);
            this.txt_currentDate.Name = "txt_currentDate";
            this.txt_currentDate.Size = new System.Drawing.Size(200, 26);
            this.txt_currentDate.TabIndex = 4;
            // 
            // txt_invoiceNo
            // 
            this.txt_invoiceNo.Enabled = false;
            this.txt_invoiceNo.Location = new System.Drawing.Point(127, 77);
            this.txt_invoiceNo.Name = "txt_invoiceNo";
            this.txt_invoiceNo.Size = new System.Drawing.Size(200, 26);
            this.txt_invoiceNo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Invoice No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pl_vendor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_viewBy);
            this.groupBox1.Location = new System.Drawing.Point(395, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(404, 120);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendor Data";
            // 
            // pl_vendor
            // 
            this.pl_vendor.Controls.Add(this.cb_ven);
            this.pl_vendor.Controls.Add(this.lb_selectVendor);
            this.pl_vendor.Location = new System.Drawing.Point(6, 71);
            this.pl_vendor.Name = "pl_vendor";
            this.pl_vendor.Size = new System.Drawing.Size(392, 43);
            this.pl_vendor.TabIndex = 6;
            this.pl_vendor.Visible = false;
            // 
            // cb_ven
            // 
            this.cb_ven.FormattingEnabled = true;
            this.cb_ven.Location = new System.Drawing.Point(159, 3);
            this.cb_ven.Name = "cb_ven";
            this.cb_ven.Size = new System.Drawing.Size(218, 28);
            this.cb_ven.TabIndex = 7;
            // 
            // lb_selectVendor
            // 
            this.lb_selectVendor.AutoSize = true;
            this.lb_selectVendor.Location = new System.Drawing.Point(9, 6);
            this.lb_selectVendor.Name = "lb_selectVendor";
            this.lb_selectVendor.Size = new System.Drawing.Size(61, 20);
            this.lb_selectVendor.TabIndex = 6;
            this.lb_selectVendor.Text = "Vendor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "View By";
            // 
            // cb_viewBy
            // 
            this.cb_viewBy.FormattingEnabled = true;
            this.cb_viewBy.Location = new System.Drawing.Point(165, 36);
            this.cb_viewBy.Name = "cb_viewBy";
            this.cb_viewBy.Size = new System.Drawing.Size(218, 28);
            this.cb_viewBy.TabIndex = 5;
            this.cb_viewBy.SelectedIndexChanged += new System.EventHandler(this.cb_viewBy_SelectedIndexChanged);
            // 
            // gb_mainInfo
            // 
            this.gb_mainInfo.Controls.Add(this.btn_cont);
            this.gb_mainInfo.Controls.Add(this.gb_SIData);
            this.gb_mainInfo.Controls.Add(this.groupBox1);
            this.gb_mainInfo.Location = new System.Drawing.Point(12, 105);
            this.gb_mainInfo.Name = "gb_mainInfo";
            this.gb_mainInfo.Size = new System.Drawing.Size(932, 175);
            this.gb_mainInfo.TabIndex = 2;
            this.gb_mainInfo.TabStop = false;
            this.gb_mainInfo.Text = "Main Info";
            // 
            // btn_cont
            // 
            this.btn_cont.Location = new System.Drawing.Point(805, 79);
            this.btn_cont.Name = "btn_cont";
            this.btn_cont.Size = new System.Drawing.Size(114, 50);
            this.btn_cont.TabIndex = 2;
            this.btn_cont.Text = "Continue";
            this.btn_cont.UseVisualStyleBackColor = true;
            this.btn_cont.Click += new System.EventHandler(this.btn_cont_Click);
            // 
            // gb_itemData
            // 
            this.gb_itemData.Controls.Add(this.pl_afterStore);
            this.gb_itemData.Controls.Add(this.cb_store);
            this.gb_itemData.Controls.Add(this.label6);
            this.gb_itemData.Controls.Add(this.cb_item);
            this.gb_itemData.Controls.Add(this.label7);
            this.gb_itemData.Location = new System.Drawing.Point(12, 419);
            this.gb_itemData.Name = "gb_itemData";
            this.gb_itemData.Size = new System.Drawing.Size(932, 490);
            this.gb_itemData.TabIndex = 3;
            this.gb_itemData.TabStop = false;
            this.gb_itemData.Text = "Item Data";
            this.gb_itemData.Visible = false;
            // 
            // pl_afterStore
            // 
            this.pl_afterStore.Controls.Add(this.txt_note);
            this.pl_afterStore.Controls.Add(this.btn_add);
            this.pl_afterStore.Controls.Add(this.nud_quantity);
            this.pl_afterStore.Controls.Add(this.label10);
            this.pl_afterStore.Controls.Add(this.label8);
            this.pl_afterStore.Controls.Add(this.dp_ExpiringDate);
            this.pl_afterStore.Controls.Add(this.label4);
            this.pl_afterStore.Controls.Add(this.cb_measures);
            this.pl_afterStore.Controls.Add(this.dp_productionDate);
            this.pl_afterStore.Controls.Add(this.label9);
            this.pl_afterStore.Controls.Add(this.label5);
            this.pl_afterStore.Location = new System.Drawing.Point(6, 83);
            this.pl_afterStore.Name = "pl_afterStore";
            this.pl_afterStore.Size = new System.Drawing.Size(913, 383);
            this.pl_afterStore.TabIndex = 6;
            this.pl_afterStore.Visible = false;
            // 
            // txt_note
            // 
            this.txt_note.Location = new System.Drawing.Point(152, 160);
            this.txt_note.Multiline = true;
            this.txt_note.Name = "txt_note";
            this.txt_note.Size = new System.Drawing.Size(678, 146);
            this.txt_note.TabIndex = 9;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(395, 317);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(114, 50);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "Add Item";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // nud_quantity
            // 
            this.nud_quantity.Location = new System.Drawing.Point(605, 14);
            this.nud_quantity.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.nud_quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_quantity.Name = "nud_quantity";
            this.nud_quantity.Size = new System.Drawing.Size(225, 26);
            this.nud_quantity.TabIndex = 5;
            this.nud_quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Notes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Quantity";
            // 
            // dp_ExpiringDate
            // 
            this.dp_ExpiringDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_ExpiringDate.Location = new System.Drawing.Point(605, 93);
            this.dp_ExpiringDate.Name = "dp_ExpiringDate";
            this.dp_ExpiringDate.Size = new System.Drawing.Size(225, 26);
            this.dp_ExpiringDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Production Date";
            // 
            // cb_measures
            // 
            this.cb_measures.FormattingEnabled = true;
            this.cb_measures.Location = new System.Drawing.Point(199, 14);
            this.cb_measures.Name = "cb_measures";
            this.cb_measures.Size = new System.Drawing.Size(222, 28);
            this.cb_measures.TabIndex = 7;
            // 
            // dp_productionDate
            // 
            this.dp_productionDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dp_productionDate.Location = new System.Drawing.Point(199, 94);
            this.dp_productionDate.Name = "dp_productionDate";
            this.dp_productionDate.Size = new System.Drawing.Size(223, 26);
            this.dp_productionDate.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Used Unit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(484, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Expiring Date";
            // 
            // cb_store
            // 
            this.cb_store.FormattingEnabled = true;
            this.cb_store.Location = new System.Drawing.Point(613, 39);
            this.cb_store.Name = "cb_store";
            this.cb_store.Size = new System.Drawing.Size(223, 28);
            this.cb_store.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Item";
            // 
            // cb_item
            // 
            this.cb_item.FormattingEnabled = true;
            this.cb_item.Location = new System.Drawing.Point(205, 39);
            this.cb_item.Name = "cb_item";
            this.cb_item.Size = new System.Drawing.Size(223, 28);
            this.cb_item.TabIndex = 1;
            this.cb_item.SelectedIndexChanged += new System.EventHandler(this.cb_item_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(490, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "To Store";
            // 
            // lb_divider
            // 
            this.lb_divider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lb_divider.Location = new System.Drawing.Point(972, 20);
            this.lb_divider.Name = "lb_divider";
            this.lb_divider.Size = new System.Drawing.Size(2, 900);
            this.lb_divider.TabIndex = 4;
            // 
            // gb_invoice
            // 
            this.gb_invoice.Controls.Add(this.pl_invoiceLabels);
            this.gb_invoice.Controls.Add(this.btn_save);
            this.gb_invoice.Controls.Add(this.dg_invoiceDetails);
            this.gb_invoice.Location = new System.Drawing.Point(1003, 31);
            this.gb_invoice.Name = "gb_invoice";
            this.gb_invoice.Size = new System.Drawing.Size(881, 889);
            this.gb_invoice.TabIndex = 5;
            this.gb_invoice.TabStop = false;
            this.gb_invoice.Text = "Invoice";
            this.gb_invoice.Visible = false;
            // 
            // pl_invoiceLabels
            // 
            this.pl_invoiceLabels.Controls.Add(this.label11);
            this.pl_invoiceLabels.Controls.Add(this.lb_date);
            this.pl_invoiceLabels.Controls.Add(this.label12);
            this.pl_invoiceLabels.Controls.Add(this.lb_vendor);
            this.pl_invoiceLabels.Controls.Add(this.lb_invoiceNumber);
            this.pl_invoiceLabels.Controls.Add(this.label13);
            this.pl_invoiceLabels.Location = new System.Drawing.Point(20, 22);
            this.pl_invoiceLabels.Name = "pl_invoiceLabels";
            this.pl_invoiceLabels.Size = new System.Drawing.Size(846, 100);
            this.pl_invoiceLabels.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(65, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Date : ";
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.Location = new System.Drawing.Point(127, 37);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(60, 20);
            this.lb_date.TabIndex = 1;
            this.lb_date.Text = "label12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(308, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Invoice Number : ";
            // 
            // lb_vendor
            // 
            this.lb_vendor.AutoSize = true;
            this.lb_vendor.Location = new System.Drawing.Point(671, 37);
            this.lb_vendor.Name = "lb_vendor";
            this.lb_vendor.Size = new System.Drawing.Size(60, 20);
            this.lb_vendor.TabIndex = 5;
            this.lb_vendor.Text = "label14";
            // 
            // lb_invoiceNumber
            // 
            this.lb_invoiceNumber.AutoSize = true;
            this.lb_invoiceNumber.Location = new System.Drawing.Point(445, 37);
            this.lb_invoiceNumber.Name = "lb_invoiceNumber";
            this.lb_invoiceNumber.Size = new System.Drawing.Size(60, 20);
            this.lb_invoiceNumber.TabIndex = 3;
            this.lb_invoiceNumber.Text = "label13";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(592, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "Vendor : ";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Green;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_save.Location = new System.Drawing.Point(293, 812);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(262, 66);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // dg_invoiceDetails
            // 
            this.dg_invoiceDetails.AllowUserToAddRows = false;
            this.dg_invoiceDetails.AllowUserToDeleteRows = false;
            this.dg_invoiceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_invoiceDetails.Location = new System.Drawing.Point(20, 128);
            this.dg_invoiceDetails.Name = "dg_invoiceDetails";
            this.dg_invoiceDetails.ReadOnly = true;
            this.dg_invoiceDetails.RowHeadersWidth = 62;
            this.dg_invoiceDetails.RowTemplate.Height = 28;
            this.dg_invoiceDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dg_invoiceDetails.Size = new System.Drawing.Size(833, 635);
            this.dg_invoiceDetails.TabIndex = 6;
            this.dg_invoiceDetails.Visible = false;
            // 
            // AddSupplyInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 942);
            this.Controls.Add(this.gb_invoice);
            this.Controls.Add(this.lb_divider);
            this.Controls.Add(this.gb_itemData);
            this.Controls.Add(this.gb_mainInfo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSupplyInvoice";
            this.Text = "Supply Invoice";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gb_SIData.ResumeLayout(false);
            this.gb_SIData.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pl_vendor.ResumeLayout(false);
            this.pl_vendor.PerformLayout();
            this.gb_mainInfo.ResumeLayout(false);
            this.gb_itemData.ResumeLayout(false);
            this.gb_itemData.PerformLayout();
            this.pl_afterStore.ResumeLayout(false);
            this.pl_afterStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_quantity)).EndInit();
            this.gb_invoice.ResumeLayout(false);
            this.pl_invoiceLabels.ResumeLayout(false);
            this.pl_invoiceLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_invoiceDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_SIData;
        private System.Windows.Forms.TextBox txt_invoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_ven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_selectVendor;
        private System.Windows.Forms.ComboBox cb_viewBy;
        private System.Windows.Forms.GroupBox gb_mainInfo;
        private System.Windows.Forms.Button btn_cont;
        private System.Windows.Forms.GroupBox gb_itemData;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_note;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dp_ExpiringDate;
        private System.Windows.Forms.ComboBox cb_measures;
        private System.Windows.Forms.ComboBox cb_store;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cb_item;
        private System.Windows.Forms.DateTimePicker dp_productionDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nud_quantity;
        private System.Windows.Forms.Label lb_divider;
        private System.Windows.Forms.GroupBox gb_invoice;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dg_invoiceDetails;
        private System.Windows.Forms.Label lb_vendor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lb_invoiceNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_currentDate;
        private System.Windows.Forms.Panel pl_vendor;
        private System.Windows.Forms.Panel pl_invoiceLabels;
        private System.Windows.Forms.Panel pl_afterStore;
    }
}
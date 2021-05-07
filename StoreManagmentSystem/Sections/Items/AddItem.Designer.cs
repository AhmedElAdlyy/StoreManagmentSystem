
namespace StoreManagmentSystem.Sections.Items
{
    partial class AddItem
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
            this.cb_unitMeasure = new System.Windows.Forms.ComboBox();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.gb_itemData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_itemData
            // 
            this.gb_itemData.Controls.Add(this.btn_add);
            this.gb_itemData.Controls.Add(this.cb_unitMeasure);
            this.gb_itemData.Controls.Add(this.txt_code);
            this.gb_itemData.Controls.Add(this.txt_name);
            this.gb_itemData.Controls.Add(this.label3);
            this.gb_itemData.Controls.Add(this.label2);
            this.gb_itemData.Controls.Add(this.label1);
            this.gb_itemData.Location = new System.Drawing.Point(83, 51);
            this.gb_itemData.Name = "gb_itemData";
            this.gb_itemData.Size = new System.Drawing.Size(497, 489);
            this.gb_itemData.TabIndex = 0;
            this.gb_itemData.TabStop = false;
            this.gb_itemData.Text = "Item Data";
            // 
            // cb_unitMeasure
            // 
            this.cb_unitMeasure.FormattingEnabled = true;
            this.cb_unitMeasure.Location = new System.Drawing.Point(164, 347);
            this.cb_unitMeasure.Name = "cb_unitMeasure";
            this.cb_unitMeasure.Size = new System.Drawing.Size(312, 28);
            this.cb_unitMeasure.TabIndex = 5;
            // 
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(164, 208);
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(312, 26);
            this.txt_code.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(164, 86);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(312, 26);
            this.txt_name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Measure Unit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(144, 421);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(192, 47);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(536, 551);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(96, 39);
            this.btn_refresh.TabIndex = 1;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.gb_itemData);
            this.Name = "AddItem";
            this.Text = "AddItem";
            this.gb_itemData.ResumeLayout(false);
            this.gb_itemData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_itemData;
        private System.Windows.Forms.ComboBox cb_unitMeasure;
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_refresh;
    }
}
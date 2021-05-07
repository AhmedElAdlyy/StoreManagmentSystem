
namespace StoreManagmentSystem
{
    partial class AddStore
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
            this.gb_storeData = new System.Windows.Forms.GroupBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_Employee = new System.Windows.Forms.TextBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.gb_storeData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_storeData
            // 
            this.gb_storeData.Controls.Add(this.btn_add);
            this.gb_storeData.Controls.Add(this.txt_Employee);
            this.gb_storeData.Controls.Add(this.txt_address);
            this.gb_storeData.Controls.Add(this.txt_Name);
            this.gb_storeData.Controls.Add(this.label3);
            this.gb_storeData.Controls.Add(this.label2);
            this.gb_storeData.Controls.Add(this.label1);
            this.gb_storeData.Location = new System.Drawing.Point(76, 87);
            this.gb_storeData.Name = "gb_storeData";
            this.gb_storeData.Size = new System.Drawing.Size(518, 445);
            this.gb_storeData.TabIndex = 0;
            this.gb_storeData.TabStop = false;
            this.gb_storeData.Text = "Adding Store";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(158, 382);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(176, 48);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_Employee
            // 
            this.txt_Employee.Location = new System.Drawing.Point(226, 311);
            this.txt_Employee.Name = "txt_Employee";
            this.txt_Employee.Size = new System.Drawing.Size(265, 26);
            this.txt_Employee.TabIndex = 5;
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(226, 206);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(265, 26);
            this.txt_address.TabIndex = 4;
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(226, 96);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(265, 26);
            this.txt_Name.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 317);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Responsible Employee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Store Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Store Name";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(578, 558);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(82, 34);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // AddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.gb_storeData);
            this.Name = "AddStore";
            this.Text = "AddStore";
            this.gb_storeData.ResumeLayout(false);
            this.gb_storeData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_storeData;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_Employee;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
    }
}
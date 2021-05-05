
namespace StoreManagmentSystem.Sections.Measures
{
    partial class EditMeasure
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
            this.gb_selectMeasure = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_selectMeasure = new System.Windows.Forms.ComboBox();
            this.gb_measureDetails = new System.Windows.Forms.GroupBox();
            this.txt_measureID_hide = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_main = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_select = new System.Windows.Forms.Button();
            this.gb_selectMeasure.SuspendLayout();
            this.gb_measureDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_selectMeasure
            // 
            this.gb_selectMeasure.Controls.Add(this.btn_select);
            this.gb_selectMeasure.Controls.Add(this.cb_selectMeasure);
            this.gb_selectMeasure.Controls.Add(this.label1);
            this.gb_selectMeasure.Location = new System.Drawing.Point(106, 23);
            this.gb_selectMeasure.Name = "gb_selectMeasure";
            this.gb_selectMeasure.Size = new System.Drawing.Size(475, 104);
            this.gb_selectMeasure.TabIndex = 0;
            this.gb_selectMeasure.TabStop = false;
            this.gb_selectMeasure.Text = "Select Measure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Measure Name";
            // 
            // cb_selectMeasure
            // 
            this.cb_selectMeasure.FormattingEnabled = true;
            this.cb_selectMeasure.Location = new System.Drawing.Point(155, 47);
            this.cb_selectMeasure.Name = "cb_selectMeasure";
            this.cb_selectMeasure.Size = new System.Drawing.Size(233, 28);
            this.cb_selectMeasure.TabIndex = 1;
            // 
            // gb_measureDetails
            // 
            this.gb_measureDetails.Controls.Add(this.btn_edit);
            this.gb_measureDetails.Controls.Add(this.txt_quantity);
            this.gb_measureDetails.Controls.Add(this.txt_sub);
            this.gb_measureDetails.Controls.Add(this.txt_main);
            this.gb_measureDetails.Controls.Add(this.label3);
            this.gb_measureDetails.Controls.Add(this.label2);
            this.gb_measureDetails.Controls.Add(this.label4);
            this.gb_measureDetails.Location = new System.Drawing.Point(93, 183);
            this.gb_measureDetails.Name = "gb_measureDetails";
            this.gb_measureDetails.Size = new System.Drawing.Size(497, 381);
            this.gb_measureDetails.TabIndex = 1;
            this.gb_measureDetails.TabStop = false;
            this.gb_measureDetails.Text = "Measure Details";
            this.gb_measureDetails.Visible = false;
            // 
            // txt_measureID_hide
            // 
            this.txt_measureID_hide.Location = new System.Drawing.Point(280, 151);
            this.txt_measureID_hide.Name = "txt_measureID_hide";
            this.txt_measureID_hide.Size = new System.Drawing.Size(100, 26);
            this.txt_measureID_hide.TabIndex = 2;
            this.txt_measureID_hide.Visible = false;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(175, 320);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(127, 45);
            this.btn_edit.TabIndex = 13;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(248, 256);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(216, 26);
            this.txt_quantity.TabIndex = 12;
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(248, 149);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(216, 26);
            this.txt_sub.TabIndex = 11;
            // 
            // txt_main
            // 
            this.txt_main.Location = new System.Drawing.Point(248, 50);
            this.txt_main.Name = "txt_main";
            this.txt_main.Size = new System.Drawing.Size(216, 26);
            this.txt_main.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantity From Main to Sub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sub Measure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Main Measure";
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(394, 41);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 39);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "Select";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // EditMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.txt_measureID_hide);
            this.Controls.Add(this.gb_measureDetails);
            this.Controls.Add(this.gb_selectMeasure);
            this.Name = "EditMeasure";
            this.Text = "EditMeasure";
            this.gb_selectMeasure.ResumeLayout(false);
            this.gb_selectMeasure.PerformLayout();
            this.gb_measureDetails.ResumeLayout(false);
            this.gb_measureDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_selectMeasure;
        private System.Windows.Forms.ComboBox cb_selectMeasure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_measureDetails;
        private System.Windows.Forms.TextBox txt_measureID_hide;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.TextBox txt_main;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_select;
    }
}
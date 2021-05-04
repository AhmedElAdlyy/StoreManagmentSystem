
namespace StoreManagmentSystem.Sections.Measures
{
    partial class AddMeasure
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
            this.gb_measure = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_main = new System.Windows.Forms.TextBox();
            this.txt_sub = new System.Windows.Forms.TextBox();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.gb_measure.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_measure
            // 
            this.gb_measure.Controls.Add(this.btn_add);
            this.gb_measure.Controls.Add(this.txt_quantity);
            this.gb_measure.Controls.Add(this.txt_sub);
            this.gb_measure.Controls.Add(this.txt_main);
            this.gb_measure.Controls.Add(this.label3);
            this.gb_measure.Controls.Add(this.label2);
            this.gb_measure.Controls.Add(this.label1);
            this.gb_measure.Location = new System.Drawing.Point(105, 60);
            this.gb_measure.Name = "gb_measure";
            this.gb_measure.Size = new System.Drawing.Size(455, 451);
            this.gb_measure.TabIndex = 0;
            this.gb_measure.TabStop = false;
            this.gb_measure.Text = "Measure Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity From Main to Sub";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sub Measure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main Measure";
            // 
            // txt_main
            // 
            this.txt_main.Location = new System.Drawing.Point(225, 98);
            this.txt_main.Name = "txt_main";
            this.txt_main.Size = new System.Drawing.Size(216, 26);
            this.txt_main.TabIndex = 3;
            // 
            // txt_sub
            // 
            this.txt_sub.Location = new System.Drawing.Point(225, 197);
            this.txt_sub.Name = "txt_sub";
            this.txt_sub.Size = new System.Drawing.Size(216, 26);
            this.txt_sub.TabIndex = 4;
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(225, 304);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(216, 26);
            this.txt_quantity.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(152, 389);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(127, 45);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // AddMeasure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 597);
            this.Controls.Add(this.gb_measure);
            this.Name = "AddMeasure";
            this.Text = "Add Measure";
            this.gb_measure.ResumeLayout(false);
            this.gb_measure.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_measure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.TextBox txt_sub;
        private System.Windows.Forms.TextBox txt_main;
    }
}
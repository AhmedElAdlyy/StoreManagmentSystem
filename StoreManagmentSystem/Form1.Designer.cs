
namespace StoreManagmentSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.storesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.measuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMeasureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMeasureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMeasureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stackholdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storesToolStripMenuItem,
            this.itemsToolStripMenuItem,
            this.measuresToolStripMenuItem,
            this.stackholdersToolStripMenuItem,
            this.invoicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // storesToolStripMenuItem
            // 
            this.storesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStoreToolStripMenuItem,
            this.editStoreToolStripMenuItem,
            this.deleteStoreToolStripMenuItem});
            this.storesToolStripMenuItem.Name = "storesToolStripMenuItem";
            this.storesToolStripMenuItem.Size = new System.Drawing.Size(77, 29);
            this.storesToolStripMenuItem.Text = "Stores";
            // 
            // newStoreToolStripMenuItem
            // 
            this.newStoreToolStripMenuItem.Name = "newStoreToolStripMenuItem";
            this.newStoreToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.newStoreToolStripMenuItem.Text = "New Store";
            this.newStoreToolStripMenuItem.Click += new System.EventHandler(this.newStoreToolStripMenuItem_Click);
            // 
            // editStoreToolStripMenuItem
            // 
            this.editStoreToolStripMenuItem.Name = "editStoreToolStripMenuItem";
            this.editStoreToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.editStoreToolStripMenuItem.Text = "Edit Store";
            this.editStoreToolStripMenuItem.Click += new System.EventHandler(this.editStoreToolStripMenuItem_Click);
            // 
            // deleteStoreToolStripMenuItem
            // 
            this.deleteStoreToolStripMenuItem.Name = "deleteStoreToolStripMenuItem";
            this.deleteStoreToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.deleteStoreToolStripMenuItem.Text = "Delete Store";
            this.deleteStoreToolStripMenuItem.Click += new System.EventHandler(this.deleteStoreToolStripMenuItem_Click);
            // 
            // itemsToolStripMenuItem
            // 
            this.itemsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem2,
            this.editToolStripMenuItem2,
            this.deleteToolStripMenuItem2});
            this.itemsToolStripMenuItem.Name = "itemsToolStripMenuItem";
            this.itemsToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.itemsToolStripMenuItem.Text = "Items";
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(205, 34);
            this.newToolStripMenuItem2.Text = "New Item";
            this.newToolStripMenuItem2.Click += new System.EventHandler(this.newToolStripMenuItem2_Click);
            // 
            // editToolStripMenuItem2
            // 
            this.editToolStripMenuItem2.Name = "editToolStripMenuItem2";
            this.editToolStripMenuItem2.Size = new System.Drawing.Size(205, 34);
            this.editToolStripMenuItem2.Text = "Edit Item";
            this.editToolStripMenuItem2.Click += new System.EventHandler(this.editToolStripMenuItem2_Click);
            // 
            // deleteToolStripMenuItem2
            // 
            this.deleteToolStripMenuItem2.Name = "deleteToolStripMenuItem2";
            this.deleteToolStripMenuItem2.Size = new System.Drawing.Size(205, 34);
            this.deleteToolStripMenuItem2.Text = "Delete Item";
            this.deleteToolStripMenuItem2.Click += new System.EventHandler(this.deleteToolStripMenuItem2_Click);
            // 
            // measuresToolStripMenuItem
            // 
            this.measuresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMeasureToolStripMenuItem,
            this.editMeasureToolStripMenuItem,
            this.deleteMeasureToolStripMenuItem});
            this.measuresToolStripMenuItem.Name = "measuresToolStripMenuItem";
            this.measuresToolStripMenuItem.Size = new System.Drawing.Size(103, 29);
            this.measuresToolStripMenuItem.Text = "Measures";
            // 
            // addMeasureToolStripMenuItem
            // 
            this.addMeasureToolStripMenuItem.Name = "addMeasureToolStripMenuItem";
            this.addMeasureToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.addMeasureToolStripMenuItem.Text = "New Measure";
            this.addMeasureToolStripMenuItem.Click += new System.EventHandler(this.addMeasureToolStripMenuItem_Click);
            // 
            // editMeasureToolStripMenuItem
            // 
            this.editMeasureToolStripMenuItem.Name = "editMeasureToolStripMenuItem";
            this.editMeasureToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.editMeasureToolStripMenuItem.Text = "Edit Measure";
            this.editMeasureToolStripMenuItem.Click += new System.EventHandler(this.editMeasureToolStripMenuItem_Click);
            // 
            // deleteMeasureToolStripMenuItem
            // 
            this.deleteMeasureToolStripMenuItem.Name = "deleteMeasureToolStripMenuItem";
            this.deleteMeasureToolStripMenuItem.Size = new System.Drawing.Size(236, 34);
            this.deleteMeasureToolStripMenuItem.Text = "Delete Measure";
            this.deleteMeasureToolStripMenuItem.Click += new System.EventHandler(this.deleteMeasureToolStripMenuItem_Click);
            // 
            // stackholdersToolStripMenuItem
            // 
            this.stackholdersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vendorToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.stackholdersToolStripMenuItem.Name = "stackholdersToolStripMenuItem";
            this.stackholdersToolStripMenuItem.Size = new System.Drawing.Size(128, 29);
            this.stackholdersToolStripMenuItem.Text = "Stackholders";
            // 
            // vendorToolStripMenuItem
            // 
            this.vendorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.vendorToolStripMenuItem.Name = "vendorToolStripMenuItem";
            this.vendorToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.vendorToolStripMenuItem.Text = "Vendor";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(164, 34);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.editToolStripMenuItem1,
            this.deleteToolStripMenuItem1});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(191, 34);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.newToolStripMenuItem1.Text = "New...";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.editToolStripMenuItem1.Text = "Edit...";
            this.editToolStripMenuItem1.Click += new System.EventHandler(this.editToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(164, 34);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplyInvoiceToolStripMenuItem});
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.invoicesToolStripMenuItem.Text = "Invoices";
            // 
            // supplyInvoiceToolStripMenuItem
            // 
            this.supplyInvoiceToolStripMenuItem.Name = "supplyInvoiceToolStripMenuItem";
            this.supplyInvoiceToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.supplyInvoiceToolStripMenuItem.Text = "Supply Invoice";
            this.supplyInvoiceToolStripMenuItem.Click += new System.EventHandler(this.supplyInvoiceToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem storesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem measuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMeasureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMeasureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMeasureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stackholdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyInvoiceToolStripMenuItem;
    }
}


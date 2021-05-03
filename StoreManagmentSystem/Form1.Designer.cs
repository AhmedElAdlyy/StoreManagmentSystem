
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storesToolStripMenuItem});
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
            // 
            // deleteStoreToolStripMenuItem
            // 
            this.deleteStoreToolStripMenuItem.Name = "deleteStoreToolStripMenuItem";
            this.deleteStoreToolStripMenuItem.Size = new System.Drawing.Size(210, 34);
            this.deleteStoreToolStripMenuItem.Text = "Delete Store";
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
    }
}


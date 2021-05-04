using StoreManagmentSystem.Sections.Measures;
using StoreManagmentSystem.Stores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManagmentSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStore addStore = new AddStore();
            addStore.MdiParent = this;
            addStore.Show();
        }

        private void editStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditStore editStore = new EditStore();
            editStore.MdiParent = this;
            editStore.Show();
        }

        private void deleteStoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStore deleteStore = new DeleteStore();
            deleteStore.MdiParent = this;
            deleteStore.Show();
        }

        private void addMeasureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMeasure addMeasure = new AddMeasure();
            addMeasure.MdiParent = this;
            addMeasure.Show();
        }
    }
}

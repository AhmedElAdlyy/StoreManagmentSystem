﻿using StoreManagmentSystem.Sections.Measures;
using StoreManagmentSystem.Sections.Stackholders.Customer;
using StoreManagmentSystem.Sections.Stackholders.Customers;
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

        private void editMeasureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditMeasure editMeasure = new EditMeasure();
            editMeasure.MdiParent = this;
            editMeasure.Show();
        }

        private void deleteMeasureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteMeasure deleteMeasure = new DeleteMeasure();
            deleteMeasure.MdiParent = this;
            deleteMeasure.Show();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.MdiParent = this;
            addCustomer.Show();
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EditCustomer editCustomer = new EditCustomer();
            editCustomer.MdiParent = this;
            editCustomer.Show();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DeleteCustomer deleteCustomer = new DeleteCustomer();
            deleteCustomer.MdiParent = this;
            deleteCustomer.Show();
        }
    }
}

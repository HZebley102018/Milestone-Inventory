using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//To use StreamWriter
using System.IO;
using Milestone_Inventory.BusinessLayer;
using Milestone_Inventory.Models;
/*
 * Harlee Zebley
 * CST-150
 * Milestone Inventory 
 * December 4, 2024
 * Citations
 * This is my own work, aided by the study and use of codes learned in textbook and activities
 * */
namespace Milestone_Inventory
{
    public partial class FrmAddItem : Form
    {
        private Inventory inventory;
        List<InvItem> invItems = new List<InvItem>();
        public FrmAddItem()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Add New Item to inventory from inventory class 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubmitAddItemEventHandler(object sender, EventArgs e)
        {
            //Declare Variables
            string name = txtAddName.Text;
            string description = txtAddDescription.Text;
            string unitSize = txtAddUnitSize.Text;
            string material = txtAddMaterial.Text;
            double cost = 0.0;
            int quantity = 0;
            //Exception checking for textbox entries
            if (txtAddName.Text == null || txtAddDescription.Text == null ||
                txtAddUnitSize.Text == null || txtAddMaterial.Text == null)
            {
                MessageBox.Show("Please fill out all items!");
            }
            else
            {
                name = txtAddName.Text;
                description = txtAddDescription.Text;
                unitSize = txtAddUnitSize.Text;
                material = txtAddMaterial.Text;
            }
            if (double.TryParse(txtAddCost.Text, out double result))
            {
                cost = Convert.ToDouble(txtAddCost.Text);
            }
            else
            {
                MessageBox.Show("Please enter a price in dollars and cents.");
            }
            if (int.TryParse(txtAddQuantity.Text, out int result1))
            {
                quantity = Convert.ToInt32(txtAddQuantity.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid whole number quantity.");
            }
            //Instantiate Inventory Class
            Inventory newItem = new Inventory();
            //Pass parameters to Inventory Class method
            invItems = newItem.AddNewItem(invItems, name, description, unitSize, material, cost, quantity);

            //Clear contents of form
            txtAddName.Text = "";
            txtAddDescription.Text = "";
            txtAddUnitSize.Text = "";
            txtAddMaterial.Text = "";
            txtAddCost.Text = "";
            txtAddQuantity.Text = "";

            //Close Form
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Milestone_Inventory.BusinessLayer;
using Milestone_Inventory.Models;
using Milestone_Inventory.PresentationLayer;

/*
 * Harlee Zebley
 * CST-150
 * Milestone Inventory 
 * December 4, 2024
 * Citations
 * This is my own work, aided by the study and use of codes learned in textbook and activities
 */

namespace Milestone_Inventory.PresentationLayer
{
    public partial class FrmEditItem : Form
    {
        //class level variables
        //holds single item to pass to textboces
        List<InvItem> editInventory = new List<InvItem>();
        //holds full inventory
        List<InvItem> EditInvItems = new List<InvItem>();
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="editItem"></param>
        public FrmEditItem(List<InvItem> editItem, List<InvItem> invItems)
        {
            InitializeComponent();
            this.editInventory = editItem;
            this.EditInvItems = invItems;
        }

        /// <summary>
        /// Fills textboxes with selected index data to edit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoad_EventHandler(object sender, EventArgs e)
        {
            //this list is always a single item 
            foreach (InvItem item in editInventory)
            {
                //fill textboxes with editable data
                txtEditName.Text = item.InventoryName;
                txtEditDescription.Text = item.Description;
                txtEditUnitSize.Text = item.UnitSize;
                txtEditMaterial.Text = item.Material;
                txtEditCost.Text = item.Cost.ToString();
                txtEditQuantity.Text = item.Quantity.ToString();
            }
        }

        /// <summary>
        /// Submits edited item to Inventory class to update master inventory list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmitEdit_ClickEventHandler(object sender, EventArgs e)
        {
            //Declare Variables
            bool allValid = true;
            string name = txtEditName.Text;
            string description = txtEditDescription.Text;
            string unitSize = txtEditUnitSize.Text;
            string material = txtEditMaterial.Text;
            double cost = 0.0;
            int quantity = 0;
            bool isValid = true;

            //Instantiate utility class to check for valid entries
            Utility utility = new Utility();

            //Exception checking for textbox entries using utility class
            if (!utility.NotNull(txtEditName.Text) || !utility.NotNull(txtEditDescription.Text) ||
                !utility.NotNull(txtEditUnitSize.Text) || !utility.NotNull(txtEditMaterial.Text))
            {
                MessageBox.Show("Please fill out all items!");
                //bool to pass to Inventory.AddNewItem()
                allValid = false;

            }
            //if valid, assign text to variables
            else
            {
                name = txtEditName.Text;
                description = txtEditDescription.Text;
                unitSize = txtEditUnitSize.Text;
                material = txtEditMaterial.Text;
            }
            //test cost is valid double using utility class
            (cost, isValid) = utility.ValidDouble(txtEditCost.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter a price in dollars and cents.");
                //bool to pass to Inventory.AddNewItem()
                allValid = false;
            }
            //if valid double, assign to variable
            else
            {
                cost = Convert.ToDouble(txtEditCost.Text);
            }
            //test quantity is valid int
            (quantity, isValid) = utility.ValidInt(txtEditQuantity.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter a valid whole number quantity.");
                //bool to pass to Inventory.AddNewItem()
                allValid = false;
            }
            //if valid, assign to variable
            else
            {
                quantity = Convert.ToInt32(txtEditQuantity.Text);
            }

            //Instantiate Inventory Class
            Inventory addEditedItem = new Inventory();
            //Pass parameters to Inventory Class method in main inventory List 
            EditInvItems = addEditedItem.AddNewItem(EditInvItems, name, description, unitSize, material, cost, quantity, allValid);

            //Clear contents of form
            txtEditName.Text = "";
            txtEditDescription.Text = "";
            txtEditUnitSize.Text = "";
            txtEditMaterial.Text = "";
            txtEditCost.Text = "";
            txtEditQuantity.Text = "";

            //Close Form
            this.Close();
        }
    }
}

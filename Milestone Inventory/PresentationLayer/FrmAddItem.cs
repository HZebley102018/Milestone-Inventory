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
        //class level variables
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
            bool allValid = true;
            string name = txtAddName.Text;
            string description = txtAddDescription.Text;
            string unitSize = txtAddUnitSize.Text;
            string material = txtAddMaterial.Text;
            double cost = 0.0;
            int quantity = 0;
            bool isValid = true;
          
            //Instantiate utility class to check for valid entries
            Utility utility = new Utility();

            //Exception checking for textbox entries using utility class
            if (!utility.NotNull(txtAddName.Text) || !utility.NotNull(txtAddDescription.Text) ||
                !utility.NotNull(txtAddUnitSize.Text) || !utility.NotNull(txtAddMaterial.Text))
            {
                MessageBox.Show("Please fill out all items!");
                //bool to pass to Inventory.AddNewItem()
                allValid = false;

            }
            //if valid, assign text to variables
            else
            {
                name = txtAddName.Text;
                description = txtAddDescription.Text;
                unitSize = txtAddUnitSize.Text;
                material = txtAddMaterial.Text;
            }
            //test cost is valid double using utility class
            (cost, isValid) = utility.ValidDouble(txtAddCost.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter a price in dollars and cents.");
                //bool to pass to Inventory.AddNewItem()
                allValid = false;
            }
            //if valid double, assign to variable
            else
            {
               cost = Convert.ToDouble(txtAddCost.Text); 
            }
            //test quantity is valid int
            (quantity, isValid) = utility.ValidInt(txtAddQuantity.Text);
            if (!isValid)
            {
                MessageBox.Show("Please enter a valid whole number quantity.");
                //bool to pass to Inventory.AddNewItem()
                allValid = false;
            }
            //if valid, assign to variable
            else
            {
               quantity = Convert.ToInt32(txtAddQuantity.Text);  
            }

            //Instantiate Inventory Class
            Inventory newItem = new Inventory();
            //Pass parameters to Inventory Class method
            invItems = newItem.AddNewItem(invItems, name, description, unitSize, material, cost, quantity, allValid);

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

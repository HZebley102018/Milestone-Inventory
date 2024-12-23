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
            Inventory inventoryObject = new Inventory(txtAddName.Text, txtAddDescription.Text,
                txtAddUnitSize.Text, txtAddMaterial.Text, txtAddCost.Text, int.Parse(txtAddQuantity.Text));

            //Append to text file using StreamWriter 
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");

                outputFile.WriteLine(inventoryObject.ToString());

                //Confirm Item added to Inventory
                MessageBox.Show("Item Added");

                //Clear contents of form
                txtAddName.Text = "";
                txtAddDescription.Text = "";
                txtAddUnitSize.Text = "";
                txtAddMaterial.Text = "";
                txtAddCost.Text = "";
                txtAddQuantity.Text = "";

                //Close StreamReader so that functions from FrmInventoryList can read text
                outputFile.Close();

            }
            catch(Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }




        }
    }
}

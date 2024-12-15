using System.Xml.Serialization;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;
using static System.Windows.Forms.LinkLabel;
using System.Net.Quic;
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
    public partial class FrmInventoryList : Form
    {
        //Declare and Initialize class variables
        string[] inventory;
        const int PadSpace = 28;
        int qty = 0;
 
        public FrmInventoryList()
        {
            InitializeComponent();
            cmbDecreaseQty.Visible = false;
            cmbIncreaseQty.Visible = false;
            lblIncreaseQty.Visible = false;
            lblDecreaseQty.Visible = false;
            lblInventoryDisplay.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        /// <summary>
        /// This button will populate the inventory when clicked
        /// If more items are added, clicking this button will reread the text and the additional inventory
        /// When Items are increased or decreased this will refresh the inventory list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshViewClickEventHandler(object sender, EventArgs e)
        {
            ReadText();
        }
        /// <summary>
        /// This method will populate the inventory list label
        /// </summary>
        private void ReadText()
        {
            //Declare and initializevariable for comboBox
            //Must be integer for selection
            int number = 1;
            //populate inventory array with lines from inventory List
            inventory = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            //Make sure the label is cleared
            lblInventoryDisplay.Text = "";
            //Display header from method
            DisplayHeader();
            //Clear comboBoxes 
            cmbIncreaseQty.Items.Clear();
            cmbDecreaseQty.Items.Clear();

            //Split the properties from each line of the inventory list into
            //separate elements and format for display 
            foreach (string item in inventory)
            {
               string[] property = item.Split(", ");
                for (int i = 0; i < property.Length; i++)
                {
                    lblInventoryDisplay.Text += property[i].PadRight(PadSpace);
                }
                //Create a new line for each inventory Item
                lblInventoryDisplay.Text += "\n";
                //Dynamically populate the comboBoxes to select items to increase and decrease
                cmbIncreaseQty.Items.Add(number);
                cmbDecreaseQty.Items.Add(number);

                number++;
            }
            //Make inventory display, and increase and decrease labels and comboBoxes visible
            lblInventoryDisplay.Visible = true;
            lblIncreaseQty.Visible = true;
            lblDecreaseQty.Visible = true;
            cmbIncreaseQty.Visible = true;
            cmbDecreaseQty.Visible = true;
        }
        /// <summary>
        /// Display Header
        /// </summary>
        private void DisplayHeader()
        {
            //Declare and initialize variables
            string header1 = "Name", header2 = "Description", header3 = "Unit Size", header4 = "Material",
                header5 = "Cost", header6 = "Quantity";
            string headerLine1 = " ----", headerLine2 = "-----------", headerLine3 = "---------",
                headerLine4 = "--------", headerLine5 = "----", headerLine6 = "--------";

            //Format header and header lines to display correctly
            lblInventoryDisplay.Text += string.Format("{0}{1}{2}{3}{4}{5}\n", header1.PadRight(PadSpace),
                header2.PadRight(PadSpace), header3.PadRight(PadSpace), header4.PadRight(PadSpace),
                header5.PadRight(PadSpace), header6.PadRight(PadSpace));
            lblInventoryDisplay.Text += string.Format("{0}{1}{2}{3}{4}{5}\n", headerLine1.PadRight(PadSpace),
                headerLine2.PadRight(PadSpace), headerLine3.PadRight(PadSpace), headerLine4.PadRight(PadSpace),
                headerLine5.PadRight(PadSpace), headerLine6.PadRight(PadSpace));
        }
        /// <summary>
        /// Select the item to increase from the comboBox
        /// Get quantity from text from GetQty()
        /// Display new quantity returned from IncDisplayQuantity()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectItemToInc(object sender, EventArgs e)
        {
            //Declare and initialize variables
            int itemRowSelected = -1;
            int qtyValue = -1;
            //Select Row to increase
            itemRowSelected = cmbIncreaseQty.SelectedIndex;
            //must be >= 0 or firt row gets skipped
            if (itemRowSelected >= 0)
            {
                qtyValue = GetQty(inventory, itemRowSelected);
                IncDisplayQty(inventory, itemRowSelected, qtyValue);
            }
        }
        /// <summary>
        /// Get quantity to be used for selectItemToInc() and selectItemToDec()
        /// </summary>
        /// <param name="inventory"></param>
        /// <param name="itemRowSelected"></param>
        /// <returns></returns>
        private int GetQty(string[] inventory, int itemRowSelected)
        {
            //-1 to catch errors
            int qty = -1; 
            //iterate through inventory rows
            for (int i = 0; i < inventory.Length; i++)
            {   
                //when inventory row is the selectted index from comboBox, initiate 
                //incrementation
                if (i == itemRowSelected)
                {
                    //split the inventory row into property elements
                    string[] property = inventory[i].Split(',');
                    try
                    {
                        //get the 6th property (quantity) from the row 
                        qty = int.Parse(property[5].Trim());
                        //return quantity to selectItemToInc() or selectItemToDec()
                        return qty;
                    }
                    catch (FormatException e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            //Return -1 for exceptions
            return qty;
        }
        /// <summary>
        /// Increment the returned qty from GetQty() and write over text file
        /// for ReadText() to refresh the page with the updated qty
        /// </summary>
        /// <param name="property"></param>
        /// <param name="itemRowSelected"></param>
        /// <param name="qty"></param>
        private void IncDisplayQty(string[] property, int itemRowSelected, int qty)
        {
            //Decalre and initialize variables to update the Row
            string updateLine = ""; 

            //increment qty by 1
            qty++;

            //split the row selected into elements to separate properties
            property = inventory[itemRowSelected].Split(", ");
            //update the sixth element (qty) to reflect the incremented qty
            property[5] = qty.ToString();
            //update the row to reflect the incremented qty
            updateLine = property[0].Trim() + ", " + property[1].Trim() + ", " + property[2].Trim() + 
                ", " + property[3].Trim() + ", " + property[4].Trim() + ", " + property[5].Trim();
            //update the inventory array with the new line of text 
            inventory[itemRowSelected] = updateLine;

            //overwrite the text for ReadText() to refresh the page with updated qty
            StreamWriter outputFile;
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < inventory.Length; i++)
            {
                outputFile.WriteLine(inventory[i]);
            }
            outputFile.Close();

        }

        /// <summary>
        /// Decrement the returned qty from GetQty() and write over text file
        /// for ReadText() to refresh the page with the updated qty
        /// </summary>
        /// <param name="property"></param>
        /// <param name="itemRowSelected"></param>
        /// <param name="qty"></param>
        private void DecDisplayQty(string[] property, int itemRowSelected, int qty)
        {
            //Declare and initialize variables 
            string updateLine = "";
            //Only allow decrementation if greater than 0. No negative inventory.
            if (qty > 0)
            {
                try
                {
                    //decrease selected item by 1
                    qty--;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                //Separate inventory item into array with property elements
                property = inventory[itemRowSelected].Split(", ");
                //update the sixth element (qty) with decremented qty
                property[5] = qty.ToString();
                //Update the row text
                updateLine = property[0].Trim() + ", " + property[1].Trim() + ", " + property[2].Trim() +
                    ", " + property[3].Trim() + ", " + property[4].Trim() + ", " + property[5].Trim();
                //update the inventory array with the new row text 
                inventory[itemRowSelected] = updateLine;

                //Overwrite the text file for ReadText() to pull the updated qty on refresh
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < inventory.Length; i++)
                {
                    outputFile.WriteLine(inventory[i]);
                }
                outputFile.Close();
            }
        }
        /// <summary>
        /// Select the item to decrease from the comboBox
        /// Get quantity from text from GetQty()
        /// Display new quantity returned from DecDisplayQuantity()
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectItemToDec(object sender, EventArgs e)
        {
            //Declare and initialize variables
            //Set at -1 to catch errors
            int itemRowSelected = -1;
            int qtyValue = -1;

            //Select row to decrease
            itemRowSelected = cmbDecreaseQty.SelectedIndex;
            //when inventory row is the selectted index from comboBox, initiate 
            //decrementation
            if (itemRowSelected >= 0)
            {
                //Get qty from text from GetQty()
                qtyValue = GetQty(inventory, itemRowSelected);
                //Get and display new qty from DecDisplayQty()
                DecDisplayQty(inventory, itemRowSelected, qtyValue);
            }
        }

       
    }
}

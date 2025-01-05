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
using System.Data;
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
 * 1BestCsharp blog. (2019, August 15). C# - How To Import Text File Data Into Datagridview
 * in C# [With  Source Code]. https://www.youtube.com/watch?v=Vhbv0Zvkpts
 * No Author.(No Date). MessageBoxButtons Enum | Microsoft Docs
 * https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.messageboxbuttons?view=windowsdesktop-9.0
 * */
namespace Milestone_Inventory
{
    public partial class FrmInventoryList : Form
    {
        //Declare and Initialize class variables
        List<InvItem> invItems = new List<InvItem>();
        //list for searched items
        List<InvItem> itemSearch = new List<InvItem>();
        //List for edited items
        List<InvItem> editItem = new List<InvItem>();
        private int SelectedGridIndex { get; set; }

        public FrmInventoryList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads and formatsthe text into the DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Form1_Load(object sender, EventArgs e)
        {
            //Instantiate Inventory Class
            Inventory readInv = new Inventory();
            //Call to Inventory Class to read inventory
            invItems = readInv.ReadInventory(invItems);
            //clear the DataGridView
            gvInventoryList.DataSource = null;
            //Populate the DataGridView
            gvInventoryList.DataSource = invItems;
            //Format the DataGridView
            foreach (DataGridViewColumn column in gvInventoryList.Columns)
            {
                switch (column.Index)
                {
                    case 0:
                        column.HeaderText = "Item Name";
                        break;
                    case 1:
                        column.HeaderText = "Description";
                        break;
                    case 2:
                        column.HeaderText = "Unit Size";
                        break;
                    case 3:
                        column.HeaderText = "Material";
                        break;
                    case 4:
                        column.HeaderText = "Cost";
                        column.DefaultCellStyle.Format = "C2";
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    case 5:
                        column.HeaderText = "Quantity";
                        column.DefaultCellStyle.Format = "N0";
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                        break;
                    default:
                        MessageBox.Show("Invalid column was trying to be accessed.");
                        break;
                }
            }
        }

        /// <summary>
        /// Manage Click Events of DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GridView_ClickEventHandler(object sender, EventArgs e)
        {
            SelectedGridIndex = gvInventoryList.CurrentRow.Index;
        }

        /// <summary>
        /// Opens new window to add new inventory item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddINewItemEventHandler(object sender, EventArgs e)
        {
            FrmAddItem FrmAddItem = new FrmAddItem();
            FrmAddItem.Show();
        }

        /// <summary>
        /// Increase the Qty of the Selected Row from DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnIncQty_ClickEventHandler(object sender, EventArgs e)
        {
            //Instantiate the Inventory Class
            Inventory incQty = new Inventory();
            //Pass parameters Inventory Class method
            invItems = incQty.IncQtyValue(invItems, SelectedGridIndex);
            //Refresh the DataGridView with the returned invItems
            gvInventoryList.Refresh();
        }

        /// <summary>
        /// Decrease the Qty of the Selected Row from DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDecQty_ClickEventHandler(object sender, EventArgs e)
        {
            //Instantiat the Inventory Class
            Inventory decQty = new Inventory();
            //Pass parameters to Inventory Class method
            invItems = decQty.DecQtyValue(invItems, SelectedGridIndex);
            //Refresh the DataGridView with the returned invItems
            gvInventoryList.Refresh();
        }

        /// <summary>
        /// Delete Selected Row from DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnDelete_ClickEventHandler(object sender, EventArgs e)
        {
            //Confirm that user would like to delete item
            DialogResult result = MessageBox.Show("Are you sure you would like to delete this item?",
                "Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //Instantiate the Inventory Class
                Inventory deleteItem = new Inventory();
                //Pass parameters to Inventory Class method
                invItems = deleteItem.DeleteInvItem(invItems, SelectedGridIndex);
                //Clear the DataGridView
                gvInventoryList.DataSource = null;
                //Read the new text into invItems
                gvInventoryList.DataSource = invItems;
                //Refresh the DataGridView
                gvInventoryList.Refresh();
            }
        }

        /// <summary>
        /// Refresh the DataGridView after adding item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnRefresh_ClickEventHandler(object sender, EventArgs e)
        {
            //Instantiate Inventory Class
            Inventory updatedInventory = new Inventory();
            //Pass parameters to Inventory Class method
            invItems = updatedInventory.ReadInventory(invItems);
            //clear the DataGridView
            gvInventoryList.DataSource = null;
            //Get new invItems
            gvInventoryList.DataSource = invItems;
            //Refresh the DataGridView
            gvInventoryList.Refresh();
        }

        /// <summary>
        /// Search for inventory item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSearch_ClickEventHandler(object sender, EventArgs e)
        {
            //declare variable to hold text
            string searchCriteria = txtSearch.Text;
            //instantiate Inventory class
            Inventory searchInventory = new Inventory();
            //pass to inventory class to execute logic
            itemSearch = searchInventory.SearchInventory(invItems, itemSearch, searchCriteria);
            //Send list to SearchResults form
            FrmSearchResults frmSearchResults = new FrmSearchResults(itemSearch);
            //Show second form
            frmSearchResults.ShowDialog();
            //clear the textbox
            txtSearch.Text = "";
        }

        /// <summary>
        /// Sort Items in DataGridView Alphabetically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSort_ClickEventHandler(object sender, EventArgs e)
        {
            //Instantiate Inventory Class
            Inventory sortedInventory = new Inventory();
            //pass parameters to inventory class
            invItems = sortedInventory.SortInventory(invItems);
            //refresh DataGridView
            gvInventoryList.DataSource = null;
            gvInventoryList.DataSource = invItems;
            gvInventoryList.Refresh();
        }

        /// <summary>
        /// Edit Selected Item in DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEdit_ClickEventHandler(object sender, EventArgs e)
        {
            //Instantiate the Inventory Class
            Inventory editInvItem = new Inventory();
            //Pass parameters Inventory Class method
            editItem = editInvItem.EditItem(invItems, editItem, SelectedGridIndex);
            //Open new window to display selected item information to edit
            FrmEditItem frmEditItem = new FrmEditItem(editItem, invItems);
            frmEditItem.ShowDialog();
            //Instantiate Inventory Class
            Inventory updatedInventory = new Inventory();
            //Pass parameters to Inventory Class method
            invItems = updatedInventory.ReadInventory(invItems);
            //clear the DataGridView
            gvInventoryList.DataSource = null;
            //Get new invItems
            gvInventoryList.DataSource = invItems;
            //Refresh the DataGridView
            gvInventoryList.Refresh();
        }
    }
}

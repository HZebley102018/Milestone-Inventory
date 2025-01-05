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

/*Harlee Zebley
* CST-150
 * Milestone Inventory 
 * January 4, 2025
 * Citations
 * This is my own work, aided by the study and use of codes learned in textbook and activities
 */

namespace Milestone_Inventory.PresentationLayer
{
    public partial class FrmSearchResults : Form
    {
        //Class level variables
        List<InvItem> searchResults = new List<InvItem>();

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        public FrmSearchResults(List<InvItem> itemSearch)
        {
            InitializeComponent();
            this.searchResults = itemSearch;
        }

        /// <summary>
        /// Populate DataGridView on Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLoad_EventHandler(object sender, EventArgs e)
        {
            //set DataSource for DataGridView
            gvSearchInventory.DataSource = this.searchResults;
            //Format the DataGridView
            foreach (DataGridViewColumn column in gvSearchInventory.Columns)
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
        /// Close Search Results Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_ClickEventHandler(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

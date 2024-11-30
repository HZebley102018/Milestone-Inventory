using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Harlee Zebley
 * CST-150
 * Milestone 2 Inventory
 * Novemeber 29, 2024
 * This is my own work
 * */

namespace Milestone_Inventory
{
    public partial class FrmWelcome : Form
    {
        public FrmWelcome()
        {
            InitializeComponent();
        }
        /// <summary>
        /// This button should open the Inventory List Window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayInventoryEventHandler(object sender, EventArgs e)
        {
            FrmInventoryList fI= new FrmInventoryList();
            fI.Show();
        }
    }
}

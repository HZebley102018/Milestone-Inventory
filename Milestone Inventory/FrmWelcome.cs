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
 * Milestone Inventory
 * December 4, 2024
 * This is my own work with the aid of the textbook and code from the activities
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
            FrmInventoryList fI = new FrmInventoryList();
            fI.Show();
        }

        private void FrmWelcome_Load(object sender, EventArgs e)
        {

        }

        private void CreateNewInventoryEventHandler(object sender, EventArgs e)
        {
            //Declare and initialize variables
            //cost is a string because we are not doing any mathematical expressions
            string name = "Name";
            string description = "Description";
            string unitSize = "Unit Size";
            string material = "Material";
            string cost = "Cost";
            string quantity = "Quantity";
            //Write variables to text file using StreamWriter 
            try
            {
                StreamWriter outputFile;

                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");

                outputFile.WriteLine(name + ", " + description + ", " + unitSize + ", " +
                material + ", " + cost + ", " + quantity);
                outputFile.Close();
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Inventory Created");
        }
    }
}

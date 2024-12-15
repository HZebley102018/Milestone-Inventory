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

        private void SubmitAddItemEventHandler(object sender, EventArgs e)
        {
            //Declare and initialize variables
            string name;
            string description;
            string unitSize;
            string material;
            string cost;
            string quantity;

            //cost is a string because we are not doing any mathematical expressions
            //Assign values from user input
            name = txtAddName.Text;
            description = txtAddDescription.Text;   
            unitSize = txtAddUnitSize.Text; 
            material = txtAddMaterial.Text;
            cost = txtAddCost.Text;
            quantity = txtAddQuantity.Text;


            //Append variables to text file using StreamWriter 
            try
            {
                StreamWriter outputFile;
                
                outputFile = File.AppendText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                 
                outputFile.WriteLine(name + "," + description + "," + unitSize + ", " + material
                    + ", " + "$" + cost + ", " + quantity);
                outputFile.Close();

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

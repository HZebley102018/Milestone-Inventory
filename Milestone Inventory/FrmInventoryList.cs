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

        public FrmInventoryList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            //Test that array is working properly
            //Read InventoryList.txt that was created in FrmWelcome and appended in FrmAddItem
            //This was tested when append was coded to put all text elements in AddItem in a single line
            //divided by a comma. To put each element into its own label, inventoryList[] was scrapped and each
            //element was appended to the text in a new line. 
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            //Clear contents of label
            lblTest.Text = "";
            //Put each string in the text into an array
            foreach (string line in lines)
            {//Create an array from each line separating elements 
                string[] inventoryList = line.Split(", ");
                //Display each element array formatted into a table
                for (int i = 0; i < inventoryList.Length; i++)
                {
                    lblTest.Text += inventoryList[i].PadRight(PadSpace);
                }
                lblTest.Text += "\n";
            }
            //If populated populated correctly, a formatted label will be visible upon load. 
            lblTest.Visible = true;

            Remove these lines of code. This is for testing during code writing for visual reference
            of array.
            */
        }
        /// <summary>
        /// This button will populate the inventory when clicked
        /// If more items are added, clicking this button will reread the text and the additional inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RefreshViewClickEventHandler(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                //Clear labels
                lblInventoryItemName1.Text = "";
                lblInventoryItemName2.Text = "";
                lblInventoryItemName3.Text = "";
                lblInventoryItemName4.Text = "";
                lblInventoryItemName5.Text = "";
                lblInventoryItemName6.Text = "";
                lblInventoryItemName7.Text = "";
                lblInventoryItemName8.Text = "";
                lblInventoryItemName9.Text = "";
                lblInventoryItemName10.Text = "";
                lblInventoryItemDescription1.Text = "";
                lblInventoryItemDescription2.Text = "";
                lblInventoryItemDescription3.Text = "";
                lblInventoryItemDescription4.Text = "";
                lblInventoryItemDescription5.Text = "";
                lblInventoryItemDescription6.Text = "";
                lblInventoryItemDescription7.Text = "";
                lblInventoryItemDescription8.Text = "";
                lblInventoryItemDescription9.Text = "";
                lblInventoryItemDescription10.Text = "";
                lblUnitSize1.Text = "";
                lblUnitSize2.Text = "";
                lblUnitSize3.Text = "";
                lblUnitSize4.Text = "";
                lblUnitSize5.Text = "";
                lblUnitSize6.Text = "";
                lblUnitSize7.Text = "";
                lblUnitSize8.Text = "";
                lblUnitSize9.Text = "";
                lblUnitSize10.Text = "";
                lblMaterial1.Text = "";
                lblMaterial2.Text = "";
                lblMaterial3.Text = "";
                lblMaterial4.Text = "";
                lblMaterial5.Text = "";
                lblMaterial6.Text = "";
                lblMaterial7.Text = "";
                lblMaterial8.Text = "";
                lblMaterial9.Text = "";
                lblMaterial10.Text = "";
                lblCost1.Text = "";
                lblCost2.Text = "";
                lblCost3.Text = "";
                lblCost4.Text = "";
                lblCost5.Text = "";
                lblCost6.Text = "";
                lblCost7.Text = "";
                lblCost8.Text = "";
                lblCost9.Text = "";
                lblCost10.Text = "";
                lblQuantity1.Text = "";
                lblQuantity2.Text = "";
                lblQuantity3.Text = "";
                lblQuantity4.Text = "";
                lblQuantity5.Text = "";
                lblQuantity6.Text = "";
                lblQuantity7.Text = "";
                lblQuantity8.Text = "";
                lblQuantity9.Text = "";
                lblQuantity10.Text = "";

                //Assign elements from array to text in inventory list
                //Make assigned labels visible
                for (int i = 0; i < lines.Length; i++)
                {
                    //Display first inventory item 
                    if (i == 0)
                    {
                        lblInventoryItemName1.Text += lines[i];
                        lblInventoryItemName1.Visible = true;
                    }
                    if (i == 1)
                    {
                        lblInventoryItemDescription1.Text += lines[i];
                        lblInventoryItemDescription1.Visible = true;
                    }
                    if (i == 2)
                    {
                        lblUnitSize1.Text += lines[i];
                        lblUnitSize1.Visible = true;
                    }
                    if (i == 3)
                    {
                        lblMaterial1.Text += lines[i];
                        lblMaterial1.Visible = true;
                    }
                    if (i == 4)
                    {
                        lblCost1.Text += lines[i];
                        lblCost1.Visible = true;
                    }
                    if (i == 5)
                    {
                        lblQuantity1.Text += lines[i];
                        lblQuantity1.Visible = true;
                        //Make quantity editor buttons visible
                        btnIncrease1.Visible = true;
                        btnDecrease1.Visible = true;
                    }
                    //Display second inventory item
                    if (i == 6)
                    {
                        lblInventoryItemName2.Text += lines[i];
                        lblInventoryItemName2.Visible = true;
                    }
                    if (i == 7)
                    {
                        lblInventoryItemDescription2.Text += lines[i];
                        lblInventoryItemDescription2.Visible = true;
                    }
                    if (i == 8)
                    {
                        lblUnitSize2.Text += lines[i];
                        lblUnitSize2.Visible = true;
                    }
                    if (i == 9)
                    {
                        lblMaterial2.Text += lines[i];
                        lblMaterial2.Visible = true;
                    }
                    if (i == 10)
                    {
                        lblCost2.Text += lines[i];
                        lblCost2.Visible = true;
                    }
                    if (i == 11)
                    {
                        lblQuantity2.Text += lines[i];
                        lblQuantity2.Visible = true;
                        btnIncrease2.Visible = true;
                        btnDecrease2.Visible = true;
                    }
                    //Display third inventory item
                    if (i == 12)
                    {
                        lblInventoryItemName3.Text += lines[i];
                        lblInventoryItemName3.Visible = true;
                    }
                    if (i == 13)
                    {
                        lblInventoryItemDescription3.Text += lines[i];
                        lblInventoryItemDescription3.Visible = true;
                    }
                    if (i == 14)
                    {
                        lblUnitSize3.Text += lines[i];
                        lblUnitSize3.Visible = true;
                    }
                    if (i == 15)
                    {
                        lblMaterial3.Text += lines[i];
                        lblMaterial3.Visible = true;
                    }
                    if (i == 16)
                    {
                        lblCost3.Text += lines[i];
                        lblCost3.Visible = true;
                    }
                    if (i == 17)
                    {
                        lblQuantity3.Text += lines[i];
                        lblQuantity3.Visible = true;
                        btnIncrease3.Visible = true;
                        btnDecrease3.Visible = true;
                    }
                    //Display fourth inventory item
                    if (i == 18)
                    {
                        lblInventoryItemName4.Text += lines[i];
                        lblInventoryItemName4.Visible = true;
                    }
                    if (i == 19)
                    {
                        lblInventoryItemDescription4.Text += lines[i];
                        lblInventoryItemDescription4.Visible = true;
                    }
                    if (i == 20)
                    {
                        lblUnitSize4.Text += lines[i];
                        lblUnitSize4.Visible = true;
                    }
                    if (i == 21)
                    {
                        lblMaterial4.Text += lines[i];
                        lblMaterial4.Visible = true;
                    }
                    if (i == 22)
                    {
                        lblCost4.Text += lines[i];
                        lblCost4.Visible = true;
                    }
                    if (i == 23)
                    {
                        lblQuantity4.Text += lines[i];
                        lblQuantity4.Visible = true;
                        btnIncrease4.Visible = true;
                        btnDecrease4.Visible = true;
                    }
                    //Display fifth inventory item
                    if (i == 24)
                    {
                        lblInventoryItemName5.Text += lines[i];
                        lblInventoryItemName5.Visible = true;
                    }
                    if (i == 25)
                    {
                        lblInventoryItemDescription5.Text += lines[i];
                        lblInventoryItemDescription5.Visible = true;
                    }
                    if (i == 26)
                    {
                        lblUnitSize5.Text += lines[i];
                        lblUnitSize5.Visible = true;
                    }
                    if (i == 27)
                    {
                        lblMaterial5.Text += lines[i];
                        lblMaterial5.Visible = true;
                    }
                    if (i == 28)
                    {
                        lblCost5.Text += lines[i];
                        lblCost5.Visible = true;
                    }
                    if (i == 29)
                    {
                        lblQuantity5.Text += lines[i];
                        lblQuantity5.Visible = true;
                        btnIncrease5.Visible = true;
                        btnDecrease5.Visible = true;
                    }
                    //Display sixth inventory item
                    if (i == 30)
                    {
                        lblInventoryItemName6.Text += lines[i];
                        lblInventoryItemName6.Visible = true;
                    }
                    if (i == 31)
                    {
                        lblInventoryItemDescription6.Text += lines[i];
                        lblInventoryItemDescription6.Visible = true;
                    }
                    if (i == 32)
                    {
                        lblUnitSize6.Text += lines[i];
                        lblUnitSize6.Visible = true;
                    }
                    if (i == 33)
                    {
                        lblMaterial6.Text += lines[i];
                        lblMaterial6.Visible = true;
                    }
                    if (i == 34)
                    {
                        lblCost6.Text += lines[i];
                        lblCost6.Visible = true;
                    }
                    if (i == 35)
                    {
                        lblQuantity6.Text += lines[i];
                        lblQuantity6.Visible = true;
                        btnIncrease6.Visible = true;
                        btnDecrease6.Visible = true;
                    }
                    //Display seventh inventory item
                    if (i == 36)
                    {
                        lblInventoryItemName7.Text += lines[i];
                        lblInventoryItemName7.Visible = true;
                    }
                    if (i == 37)
                    {
                        lblInventoryItemDescription7.Text += lines[i];
                        lblInventoryItemDescription7.Visible = true;
                    }
                    if (i == 38)
                    {
                        lblUnitSize7.Text += lines[i];
                        lblUnitSize7.Visible = true;
                    }
                    if (i == 39)
                    {
                        lblMaterial7.Text += lines[i];
                        lblMaterial7.Visible = true;
                    }
                    if (i == 40)
                    {
                        lblCost7.Text += lines[i];
                        lblCost7.Visible = true;
                    }
                    if (i == 41)
                    {
                        lblQuantity7.Text += lines[i];
                        lblQuantity7.Visible = true;
                        btnIncrease7.Visible = true;
                        btnDecrease7.Visible = true;
                    }
                    //Display eighth inventory item
                    if (i == 42)
                    {
                        lblInventoryItemName8.Text += lines[i];
                        lblInventoryItemName8.Visible = true;
                    }
                    if (i == 43)
                    {
                        lblInventoryItemDescription8.Text += lines[i];
                        lblInventoryItemDescription8.Visible = true;
                    }
                    if (i == 44)
                    {
                        lblUnitSize8.Text += lines[i];
                        lblUnitSize8.Visible = true;
                    }
                    if (i == 45)
                    {
                        lblMaterial8.Text += lines[i];
                        lblMaterial8.Visible = true;
                    }
                    if (i == 46)
                    {
                        lblCost8.Text += lines[i];
                        lblCost8.Visible = true;
                    }
                    if (i == 47)
                    {
                        lblQuantity8.Text += lines[i];
                        lblQuantity8.Visible = true;
                        btnIncrease8.Visible = true;
                        btnDecrease8.Visible = true;
                    }
                    //Display ninth inventory item
                    if (i == 48)
                    {
                        lblInventoryItemName9.Text += lines[i];
                        lblInventoryItemName9.Visible = true;
                    }
                    if (i == 49)
                    {
                        lblInventoryItemDescription9.Text += lines[i];
                        lblInventoryItemDescription9.Visible = true;
                    }
                    if (i == 50)
                    {
                        lblUnitSize9.Text += lines[i];
                        lblUnitSize9.Visible = true;
                    }
                    if (i == 51)
                    {
                        lblMaterial9.Text += lines[i];
                        lblMaterial9.Visible = true;
                    }
                    if (i == 52)
                    {
                        lblCost9.Text += lines[i];
                        lblCost9.Visible = true;
                    }
                    if (i == 53)
                    {
                        lblQuantity9.Text += lines[i];
                        lblQuantity9.Visible = true;
                        btnIncrease9.Visible = true;
                        btnDecrease9.Visible = true;
                    }
                    //Display tenth inventory item
                    if (i == 54)
                    {
                        lblInventoryItemName10.Text += lines[i];
                        lblInventoryItemName10.Visible = true;
                    }
                    if (i == 55)
                    {
                        lblInventoryItemDescription10.Text += lines[i];
                        lblInventoryItemDescription10.Visible = true;
                    }
                    if (i == 56)
                    {
                        lblUnitSize10.Text += lines[i];
                        lblUnitSize10.Visible = true;
                    }
                    if (i == 57)
                    {
                        lblMaterial10.Text += lines[i];
                        lblMaterial10.Visible = true;
                    }
                    if (i == 58)
                    {
                        lblCost10.Text += lines[i];
                        lblCost10.Visible = true;
                    }
                    if (i == 59)
                    {
                        lblQuantity10.Text += lines[i];
                        lblQuantity10.Visible = true;
                        btnIncrease10.Visible = true;
                        btnDecrease10.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                //Display an error message if exception
                MessageBox.Show(ex.Message);
            }
        }

        
        /// <summary>
        /// Create Event Handlers for increase and decrease buttons
        /// Display new variable amounts and overwrite text to save new quantities 
        /// Create catch for negative inventory amounts (error)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quantity1IncreaseEventHandler(object sender, EventArgs e)
        {
            //Read text and assign to array elements
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            // Assign quantity-holding elements to new int
            int quantity = int.Parse(lines[5]);
            //increase by 1 per click
            quantity++;
            //Assign increased quantity to label as text
            lblQuantity1.Text = quantity.ToString();
            //Update the amount in the array 
            lines[5] = quantity.ToString();
            //Write over text to save. Skipping this step will only allow a single increase.
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            //Close Streamwriter to prevent error message when displaying inventory List
            outputFile.Close();
        }

        private void Quantity1DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[5]);
            //Create catch for attempts to make inventory less than 0. 
            if (quantity > 0)
            {
                //Decrease quantity by 1
                quantity--;
                //Assign to label for display 
                lblQuantity1.Text = quantity.ToString();
                //Chane amount in array
                lines[5] = quantity.ToString();
                //Write over text file to save changes with new array assignments
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                //Close StreamWriter to prevent error when displaying Inventory List
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }
        private void Quantity2IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[11]);
            quantity++;
            lblQuantity2.Text = quantity.ToString();
            lines[11] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity2DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[11]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity2.Text = quantity.ToString();

                lines[11] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }

        private void Quantity3IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[17]);
            quantity++;
            lblQuantity3.Text = quantity.ToString();
            lines[17] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity3DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[17]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity3.Text = quantity.ToString();

                lines[17] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }

        private void Quantity4IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[23]);
            quantity++;
            lblQuantity4.Text = quantity.ToString();
            lines[23] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity4DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[23]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity4.Text = quantity.ToString();

                lines[23] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }
        /// <summary>
        /// Event handler to open Add Item Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddItemEventHandler(object sender, EventArgs e)
        {
            FrmAddItem f2 = new FrmAddItem();
            f2.Show();
        }

        private void Quantity5IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[29]);
            quantity++;
            lblQuantity5.Text = quantity.ToString();
            lines[29] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity5DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[29]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity5.Text = quantity.ToString();

                lines[29] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }

        private void Quantity6IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[35]);
            quantity++;
            lblQuantity6.Text = quantity.ToString();
            lines[35] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity6DecreaseEventhandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[35]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity6.Text = quantity.ToString();

                lines[35] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }

        private void Quantity7IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[41]);
            quantity++;
            lblQuantity7.Text = quantity.ToString();
            lines[41] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity7DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[41]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity7.Text = quantity.ToString();

                lines[41] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }

        private void Quantity8IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[47]);
            quantity++;
            lblQuantity8.Text = quantity.ToString();
            lines[47] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity8DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[47]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity8.Text = quantity.ToString();

                lines[47] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }

        private void Quantity9IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[53]);
            quantity++;
            lblQuantity9.Text = quantity.ToString();
            lines[53] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity9DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[53]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity9.Text = quantity.ToString();

                lines[53] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }

        private void Quantity10IncreaseEventHandler(object sender, EventArgs e)
        {

            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[59]);
            quantity++;
            lblQuantity10.Text = quantity.ToString();
            lines[59] = quantity.ToString();
            StreamWriter outputFile;
            //Write to InventoryList.txt copying filepath that was created with btnCreateInventory in FrmWelcome
            outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                outputFile.WriteLine(lines[i]);
            }
            outputFile.Close();
        }

        private void Quantity10DecreaseEventHandler(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
            int quantity = int.Parse(lines[59]);

            if (quantity > 0)
            {
                quantity--;

                lblQuantity10.Text = quantity.ToString();

                lines[59] = quantity.ToString();
                StreamWriter outputFile;
                outputFile = File.CreateText(@"C:\Users\HarleeSchool\source\repos\Milestone Inventory\Milestone Inventory\bin\Debug\net8.0-windows\Data\Inventory List.txt");
                for (int i = 0; i < lines.Length; i++)
                {
                    outputFile.WriteLine(lines[i]);
                }
                outputFile.Close();
            }
            else
            {
                MessageBox.Show("Cannot have inventory less than 0.");
            }
        }

    }
}

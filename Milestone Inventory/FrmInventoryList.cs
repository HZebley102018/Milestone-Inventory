using System.Xml.Serialization;
using System.IO;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Collections.Generic;
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
        //Declare variables that will be used across multiple methods and event handlers
        private int quantity2 = 0;
        private int quantity3 = 0;
        private int quantity4 = 0;
        private int quantity5 = 0;
        private int quantity6 = 0;
        const int PadSpace = 20;
        
       
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

            Remove these lines of code. This is for testing during code writing for visual reference. 
            */
        }
     
        private void RefreshViewClickEventHandler(object sender, EventArgs e)
        {
            //This button will populate the inventory when clicked
            //If more items are added, clicking this button will reread the text and the additional inventory
            //Read the text file InventoryList.txt that was created in FrmWelcome and appended in FrmAddItem
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


            for (int i = 1; i < lines.Length; i++)
                {
                    //Display first inventory item 
                    if (i == 1)
                    {
                    lblInventoryItemName1.Text += lines[i];
                        lblInventoryItemName1.Visible = true;
                    }
                    if (i == 2)
                    {
                        lblInventoryItemDescription1.Text += lines[i];
                        lblInventoryItemDescription1.Visible = true;
                    }
                    if (i == 3)
                    {
                        lblUnitSize1.Text += lines[i];
                        lblUnitSize1.Visible = true;
                    }
                    if (i == 4)
                    {
                        lblMaterial1.Text += lines[i];
                        lblMaterial1.Visible = true;
                    }
                    if (i == 5)
                    {
                        lblCost1.Text += lines[i];
                        lblCost1.Visible = true;
                    }
                    if (i == 6)
                    {
                        lblQuantity1.Text += lines[i];
                        lblQuantity1.Visible = true;
                    }
                    //Display second inventory item
                    if (i == 7)
                    {
                        lblInventoryItemName2.Text += lines[i];
                        lblInventoryItemName2.Visible = true;
                    }
                    if (i == 8)
                    {
                        lblInventoryItemDescription2.Text += lines[i];
                        lblInventoryItemDescription2.Visible = true;
                    }
                    if (i == 9)
                    {
                        lblUnitSize2.Text += lines[i];
                        lblUnitSize2.Visible = true;
                    }
                    if (i == 10)
                    {
                        lblMaterial2.Text += lines[i];
                        lblMaterial2.Visible = true;
                    }
                    if (i == 11)
                    {
                        lblCost2.Text += lines[i];
                        lblCost2.Visible = true;
                    }
                    if (i == 12)
                    {
                        lblQuantity2.Text += lines[i];
                        lblQuantity2.Visible = true;
                    }
                    //Display third inventory item
                    if (i == 13)
                    {
                        lblInventoryItemName3.Text += lines[i];
                        lblInventoryItemName3.Visible = true;
                    }
                    if (i ==14)
                    {
                        lblInventoryItemDescription3.Text += lines[i];
                        lblInventoryItemDescription3.Visible = true;
                    }
                    if (i == 15)
                    {
                        lblUnitSize3.Text += lines[i];
                        lblUnitSize3.Visible = true;
                    }
                    if (i ==16)
                    {
                        lblMaterial3.Text += lines[i];
                        lblMaterial3.Visible = true;
                    }
                    if (i == 17)
                    {
                        lblCost3.Text += lines[i];
                        lblCost3.Visible = true;
                    }
                    if (i == 18)
                    {
                        lblQuantity3.Text += lines[i];
                        lblQuantity3.Visible = true;
                    }
                    //Display fourth inventory item
                    if (i == 19)
                    {
                        lblInventoryItemName4.Text += lines[i];
                        lblInventoryItemName4.Visible = true;
                    }
                    if (i == 20)
                    {
                        lblInventoryItemDescription4.Text += lines[i];
                        lblInventoryItemDescription4.Visible = true;
                    }
                    if (i ==21)
                    {
                        lblUnitSize4.Text += lines[i];
                        lblUnitSize4.Visible = true;
                    }
                    if (i == 22)
                    {
                        lblMaterial4.Text += lines[i];
                        lblMaterial4.Visible = true;
                    }
                    if (i == 23)
                    {
                        lblCost4.Text += lines[i];
                        lblCost4.Visible = true;
                    }
                    if (i == 24)
                    {
                        lblQuantity4.Text += lines[i];
                        lblQuantity4.Visible = true;
                    }
                    //Display fifth inventory item
                    if (i == 25)
                    {
                        lblInventoryItemName5.Text += lines[i];
                        lblInventoryItemName5.Visible = true;
                    }
                    if (i == 26)
                    {
                        lblInventoryItemDescription5.Text += lines[i];
                        lblInventoryItemDescription5.Visible = true;
                    }
                    if (i == 27)
                    {
                        lblUnitSize5.Text += lines[i];
                        lblUnitSize5.Visible = true;
                    }
                    if (i == 28)
                    {
                        lblMaterial5.Text += lines[i];
                        lblMaterial5.Visible = true;
                    }
                    if (i == 29)
                    {
                        lblCost5.Text += lines[i];
                        lblCost5.Visible = true;
                    }
                    if (i == 30)
                    {
                        lblQuantity5.Text += lines[i];
                        lblQuantity5.Visible = true;
                    }
                    //Display sixth inventory item
                    if (i == 31)
                    {
                        lblInventoryItemName6.Text += lines[i];
                        lblInventoryItemName6.Visible = true;
                    }
                    if (i == 32)
                    {
                        lblInventoryItemDescription6.Text += lines[i];
                        lblInventoryItemDescription6.Visible = true;
                    }
                    if (i == 33)
                    {
                        lblUnitSize6.Text += lines[i];
                        lblUnitSize6.Visible = true;
                    }
                    if (i == 34)
                    {  
                        lblMaterial6.Text += lines[i];
                        lblMaterial6.Visible = true;
                    }
                    if (i == 35)
                    {
                        lblCost6.Text += lines[i];
                        lblCost6.Visible = true;
                    }  
                    if (i == 36)
                    {
                        lblQuantity6.Text += lines[i];
                        lblQuantity6.Visible = true;
                    } 
                    //Display seventh inventory item
                    if (i == 37)
                    {
                        lblInventoryItemName7.Text += lines[i];
                        lblInventoryItemName7.Visible = true;
                    }
                    if (i == 38)
                    {
                        lblInventoryItemDescription7.Text += lines[i];
                        lblInventoryItemDescription7.Visible = true;
                    }  
                    if (i == 39)
                    {
                        lblUnitSize7.Text += lines[i];
                        lblUnitSize7.Visible = true;
                    }
                    if (i == 40)
                    {
                        lblMaterial7.Text += lines[i];
                        lblMaterial7.Visible = true;
                    }  
                    if (i == 41)
                    {
                        lblCost7.Text += lines[i];
                        lblCost7.Visible = true;
                    }
                    if (i == 42)
                    {
                        lblQuantity7.Text += lines[i];
                        lblQuantity7.Visible = true;
                    }
                    //Display eighth inventory item
                    if (i == 43)
                    {
                        lblInventoryItemName8.Text += lines[i];
                        lblInventoryItemName8.Visible = true;
                    }
                    if (i == 44)
                    {
                        lblInventoryItemDescription8.Text += lines[i];
                        lblInventoryItemDescription8.Visible = true;
                    }
                    if (i == 45)
                    {
                        lblUnitSize8.Text += lines[i];
                        lblUnitSize8.Visible = true;
                    }  
                    if (i == 46)
                    {
                        lblMaterial8.Text += lines[i];
                        lblMaterial8.Visible = true;
                    }
                    if (i == 47)
                    {
                        lblCost8.Text += lines[i];
                        lblCost8.Visible = true;
                    }   
                    if (i == 48)
                    {
                        lblQuantity8.Text += lines[i];
                        lblQuantity8.Visible = true;
                    }
                    //Display ninth inventory item
                    if (i == 49)
                    {
                        lblInventoryItemName9.Text += lines[i];
                        lblInventoryItemName9.Visible = true;
                    }
                    if (i == 50)
                    {
                        lblInventoryItemDescription9.Text += lines[i];
                        lblInventoryItemDescription9.Visible = true;
                    }   
                    if (i == 51)
                    {
                        lblUnitSize9.Text += lines[i];
                        lblUnitSize9.Visible = true;
                    }  
                    if (i == 52)
                    {
                        lblMaterial9.Text += lines[i];
                        lblMaterial9.Visible = true;
                    }   
                    if (i == 53)
                    {
                        lblCost9.Text += lines[i];
                        lblCost9.Visible = true;
                    }  
                    if (i == 54)
                    {
                        lblQuantity9.Text += lines[i];
                        lblQuantity9.Visible = true;
                    }  
                    //Display tenth inventory item
                    if (i == 55)
                    {
                        lblInventoryItemName10.Text += lines[i];
                        lblInventoryItemName10.Visible = true;
                    }
                    if (i == 56)
                    {
                        lblInventoryItemDescription10.Text += lines[i];
                        lblInventoryItemDescription10.Visible = true;
                    }
                    if (i == 57)
                    {
                        lblUnitSize10.Text += lines[i];
                        lblUnitSize10.Visible = true;
                    }
                    if (i == 58)
                    {
                        lblMaterial10.Text += lines[i];
                        lblMaterial10.Visible = true;
                    }
                    if (i == 59)
                    {
                        lblCost10.Text += lines[i];
                        lblCost10.Visible = true;
                    }
                    if (i == 60)
                    {
                        lblQuantity10.Text += lines[i];
                        lblQuantity10.Visible = true;
                    }   
                }
                
            }
       
        //Create Event Handlers for increase and decrease buttons
        //Display new variable amounts
        //Create catch for negative inventory amounts (error)
        private void Quantity1IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity2++;
            lblQuantity1.Text = quantity2.ToString();
        }

        private void Quantity1DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity2 > 0)
            {
                quantity2--;
                lblQuantity1.Text = quantity2.ToString();
            }
        }

        private void Quantity3IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity3++;
            lblQuantity2.Text = quantity3.ToString();
        }

        private void Quantity3DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity3 > 0)
            {
                quantity3--;
                lblQuantity2.Text = quantity3.ToString();
            }
        }

        private void Quantity4IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity4++;
            lblQuantity3.Text = quantity4.ToString();
        }

        private void Quantity4DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity4 > 0)
            {
                quantity4--;
                lblQuantity3.Text = quantity4.ToString();
            }
        }

        private void Quantity5IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity5++;
            lblQuantity4.Text = quantity5.ToString();
        }

        private void Quantity5DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity5 > 0)
            {
                quantity5--;
                lblQuantity4.Text = quantity5.ToString();
            }
        }

        private void Quantity6IncreaseEventHandler(object sender, EventArgs e)
        {
            quantity6++;
            lblQuantity5.Text = quantity6.ToString();
        }

        private void Quantity6DecreaseEventHandler(object sender, EventArgs e)
        {
            if (quantity6 > 0)
            {
                quantity6--;
                lblQuantity5.Text = quantity6.ToString();
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblInventoryItemDescription6_Click(object sender, EventArgs e)
        {

        }


    }
}

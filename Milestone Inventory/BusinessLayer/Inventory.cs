using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml.Serialization;
using Milestone_Inventory.Models;
using System.Reflection.Metadata.Ecma335;

/*
 * Harlee Zebley
 * CST-150
 * Milestone Inventory 
 * December 4, 2024
 * Citations
 * This is my own work, aided by the study and use of codes learned in textbook and activities
 * */
namespace Milestone_Inventory.BusinessLayer
{
    internal class Inventory
    {
        /// <summary>
        /// Read Inventory into a list
        /// </summary>
        /// <param name="invItems"></param>
        /// <returns></returns>
        public List<InvItem> ReadInventory(List<InvItem> invItems)
        {
            //Clear the list (otherwise everything appends)
            invItems.Clear();
            //set the location of the text file to read from 
            string dirLoc = Application.StartupPath + "Data\\Inventory List.txt";
            //Open file with "using"
            using (var str = File.OpenText(dirLoc))
            {
                //Iterate through the text file 
                foreach (string line in File.ReadLines(dirLoc, Encoding.UTF8))
                {
                    //Iterate through each element of the text row and assign to list
                    string[] rowData = line.Split(",");
                    //Append here to make a continuous list
                    invItems.Add(new InvItem(rowData[0].ToString().Trim(), rowData[1].ToString().Trim(),
                        rowData[2].ToString().Trim(), rowData[3].ToString().Trim(), Convert.ToDouble(rowData[4]),
                        Convert.ToInt32(rowData[5])));
                }
            }
            //return list to Form
            return invItems;
        }

        /// <summary>
        /// Increase the quantity of the selected row 
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="selectedRowIndex"></param>
        /// <returns></returns>
        public List<InvItem> IncQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            //pull the quantity from the selected row and increment by 1
            int updatedQty = ++invItems[selectedRowIndex].Quantity;
            //reassign the quantity from the selected row with the updated quantity
            invItems[selectedRowIndex].Quantity = updatedQty;
            //overwrite the text file using StreamWriter
            using var sw = new StreamWriter("Data\\Inventory List.txt", append: false);
            foreach (var item in invItems)
            {
                sw.WriteLine($"{item.InventoryName}, {item.Description}, {item.UnitSize}," +
                    $"{item.Material}, {item.Cost.ToString()}, {item.Quantity.ToString()}");
            }
            //return list to Form
            return invItems;
        }

        /// <summary>
        /// Decrease the quantity from the selected row by 1
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="selectedRowIndex"></param>
        /// <returns></returns>
        public List<InvItem> DecQtyValue(List<InvItem> invItems, int selectedRowIndex)
        {
            //Catch for negative inventory
            if (invItems[selectedRowIndex].Quantity > 0)
            {
                //Decrease the selected row quantity by 1
                int updatedQty = --invItems[selectedRowIndex].Quantity;
                //Update the list with the updated quantity
                invItems[selectedRowIndex].Quantity = updatedQty;
                //overwrite the text file using StremaWriter
                using var sw = new StreamWriter("Data\\Inventory List.txt");
                foreach (var item in invItems)
                {
                    sw.WriteLine($"{item.InventoryName}, {item.Description}, {item.UnitSize}," +
                        $"{item.Material}, {item.Cost.ToString()}, {item.Quantity.ToString()}");
                }
            }
            //Show error for inventory attempt less than 0
            else
            {
                MessageBox.Show("Inventory cannot be less than 0");
            }
            //Return list to Form
            return invItems;
        }

        /// <summary>
        /// Add new item to Inventory List
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="unitSize"></param>
        /// <param name="material"></param>
        /// <param name="cost"></param>
        /// <param name="quantity"></param>
        /// <returns></returns>
        public List<InvItem> AddNewItem(List<InvItem> invItems, string name, string description, string unitSize, string material, double cost, 
            int quantity)
        {
            //Instantiate and pass parameters to InvItem Class
            InvItem newItem = new InvItem(name, description, unitSize, material, cost, quantity);
            //Appemf to text file using StreamWriter
            using var sw = new StreamWriter("Data\\Inventory List.txt", append: true);
            sw.WriteLine($"{newItem.InventoryName}, {newItem.Description}, {newItem.UnitSize}," +
                    $"{newItem.Material}, {newItem.Cost.ToString()}, {newItem.Quantity.ToString()}");
            //Let user know item has been added
            MessageBox.Show("Item added!");
            //Return list to Forms
            return invItems;
        }

        /// <summary>
        /// Delete Selected Row From List
        /// </summary>
        /// <param name="invItems"></param>
        /// <param name="SelectedRowIndex"></param>
        /// <returns></returns>
        public List<InvItem> DeleteInvItem(List<InvItem> invItems, int SelectedRowIndex)
        {
            //Remove list item at selected index
            invItems.RemoveAt(SelectedRowIndex);
            //Overwrite text file using StreamWriter
            using var sw = new StreamWriter("Data\\Inventory List.txt");
            foreach (var item in invItems)
            {
                sw.WriteLine($"{item.InventoryName}, {item.Description}, {item.UnitSize}," +
                    $"{item.Material}, {item.Cost.ToString()}, {item.Quantity.ToString()}");
            }
            //Reurn List to Form 
            return invItems;
        }



    }
}

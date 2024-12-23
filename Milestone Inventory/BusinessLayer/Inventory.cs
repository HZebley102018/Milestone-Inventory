using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Xml.Serialization;

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
        //Define properties
        public string InventoryName { get; set; }
        public string Description { get; set; }
        public string UnitSize { get; set; }
        public string Material { get; set; }
        public string Cost { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// Default Constructor
        /// </summary>
        public Inventory()
        {
            //Initialize properties
            InventoryName = "";
            Description = "";
            UnitSize = "";
            Material = "";
            Cost = "";
            Quantity = 0;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="inventoryName"></param>
        /// <param name="description"></param>
        /// <param name="unitSize"></param>
        /// <param name="material"></param>
        /// <param name="cost"></param>
        /// <param name="quantity"></param>
        public Inventory(string inventoryName, string description, string unitSize, string material, string cost, int quantity)
        {
            InventoryName = inventoryName;
            Description = description;
            UnitSize = unitSize;
            Material = material;
            Cost = cost;
            Quantity = quantity;
        }
        /// <summary>
        /// Return Format to Call inventoryObject to Write to fIle from FrmAddItem
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{InventoryName}, {Description}, {UnitSize}, {Material}, {Cost}, {Quantity}";
        }


    }


}

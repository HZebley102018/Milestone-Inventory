using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Milestone_Inventory.Models
{
    /// <summary>
    /// Create internal class
    /// </summary>
    internal class InvItem
    {
        //Define properties
        public string InventoryName { get; set; }
        public string Description { get; set; }
        public string UnitSize { get; set; }
        public string Material { get; set; }
        public double Cost { get; set; }
        public int Quantity { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public InvItem()
        {
            //Initialize properties
            InventoryName = "";
            Description = "";
            UnitSize = "";
            Material = "";
            Cost = 0.0D;
            Quantity = 0;
        }

        /// <summary>
        /// Parameterized Constructor for Inventory Item
        /// </summary>
        /// <param name="inventoryName"></param>
        /// <param name="description"></param>
        /// <param name="unitSize"></param>
        /// <param name="material"></param>
        /// <param name="cost"></param>
        /// <param name="quantity"></param>
        public InvItem(string inventoryName, string description, string unitSize, string material, double cost, int quantity)
        {
            InventoryName = inventoryName;
            Description = description;
            UnitSize = unitSize;
            Material = material;
            Cost = cost;
            Quantity = quantity;
        }
    }
}

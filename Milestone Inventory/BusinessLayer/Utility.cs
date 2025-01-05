using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Harlee Zebley
* CST-150
 * Milestone Inventory 
 * January 4, 2024
 * Citations
 * This is my own work, aided by the Activity guides and textbook.
 */
namespace Milestone_Inventory.BusinessLayer
{
    internal class Utility
    {
        /// <summary>
        /// Test string inputs for validity
        /// </summary>
        /// <param name="textInput"></param>
        /// <returns></returns>
        public bool NotNull(string textInput)
        {
            //if null or white space, return false 
            if(String.IsNullOrWhiteSpace(textInput))
            { 
                return false;
            }
            return true;
        }
        /// <summary>
        /// Test if cost input is valid double
        /// </summary>
        /// <param name="textInput"></param>
        /// <returns></returns>
        public (double costValue, bool isConverted) ValidDouble(string textInput)
        {
            double convertValue = 0.00D;
            //if valid double, return true and converted double
            if (Double.TryParse(textInput, out convertValue))
            {
                return (convertValue, true);
            }
            return (-1D, false);
        }
        /// <summary>
        /// Test quantity value is valid integer
        /// </summary>
        /// <param name="textInput"></param>
        /// <returns></returns>
        public (int qtyValue, bool isConverted) ValidInt(string textInput)
        {
            int convertValue = 0;
            //if valid int, return true and converted integer
            if(int.TryParse(textInput, out convertValue))
            {
                return (convertValue, true);
            }
            return (-1, false);
        }
    }
}

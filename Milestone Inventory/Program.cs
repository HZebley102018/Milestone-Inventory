/*
 * Harlee Zebley
 * CST-150
 * Milestone 2
 * November 29, 2024
 * Citations:
 * SLaks. (2012, November 25). How to set which of the forms appear first. Stack Overflow.
 * https://stackoverflow.com/questions/13553088/how-to-set-which-of-the-forms-appear-first?newreg=d0702471697e4ba68d2fda13cef466db
 * */

namespace Milestone_Inventory
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Application.Run(new FrmInventoryList());
            
        }
    }
}
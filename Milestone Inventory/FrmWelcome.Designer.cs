/*
 * Harlee Zebley
 * CST-150
 * Milestone 2
 * November 29, 2024
 * Citations:
 * DevelopersMagic. 2023, July 8). How to open another form in c# | Windows forms [Video]. Youtube.
 * https://www.youtube.com/watch?v=tmJZhDZnR4Y
 * */
namespace Milestone_Inventory
{
    partial class FrmWelcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDisplayInventory = new Button();
            SuspendLayout();
            // 
            // btnDisplayInventory
            // 
            btnDisplayInventory.BackColor = Color.WhiteSmoke;
            btnDisplayInventory.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisplayInventory.Location = new Point(303, 114);
            btnDisplayInventory.Name = "btnDisplayInventory";
            btnDisplayInventory.Size = new Size(177, 41);
            btnDisplayInventory.TabIndex = 0;
            btnDisplayInventory.Text = "Display Inventory";
            btnDisplayInventory.UseVisualStyleBackColor = false;
            btnDisplayInventory.Click += DisplayInventoryEventHandler;
            // 
            // FrmWelcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDisplayInventory);
            Name = "FrmWelcome";
            Text = "Welcome";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDisplayInventory;
    }
}
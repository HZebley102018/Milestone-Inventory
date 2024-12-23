/*
 * Harlee Zebley
 * CST-150
 * Milestone Inventory 
 * Citations
 * This is my own work, aided by the study and use of codes learned in textbook and activities
 * */
namespace Milestone_Inventory
{
    partial class FrmAddItem
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
            lblAddItemTitle = new Label();
            lblAddName = new Label();
            txtAddName = new TextBox();
            txtAddDescription = new TextBox();
            lblAddDescription = new Label();
            txtAddUnitSize = new TextBox();
            lblAddUnitSize = new Label();
            txtAddMaterial = new TextBox();
            lblAddMaterial = new Label();
            txtAddCost = new TextBox();
            lblAddCost = new Label();
            btnSubmitAddItem = new Button();
            txtAddQuantity = new TextBox();
            lbladdQuantity = new Label();
            grbAtrributes = new GroupBox();
            grbAtrributes.SuspendLayout();
            SuspendLayout();
            // 
            // lblAddItemTitle
            // 
            lblAddItemTitle.AutoSize = true;
            lblAddItemTitle.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddItemTitle.Location = new Point(343, 24);
            lblAddItemTitle.Name = "lblAddItemTitle";
            lblAddItemTitle.Size = new Size(92, 24);
            lblAddItemTitle.TabIndex = 0;
            lblAddItemTitle.Text = "Add Item";
            // 
            // lblAddName
            // 
            lblAddName.AutoSize = true;
            lblAddName.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddName.ImageAlign = ContentAlignment.MiddleRight;
            lblAddName.Location = new Point(75, 35);
            lblAddName.Name = "lblAddName";
            lblAddName.Size = new Size(55, 21);
            lblAddName.TabIndex = 1;
            lblAddName.Text = "Name";
            // 
            // txtAddName
            // 
            txtAddName.BackColor = Color.WhiteSmoke;
            txtAddName.Location = new Point(147, 30);
            txtAddName.MaxLength = 20;
            txtAddName.Name = "txtAddName";
            txtAddName.Size = new Size(198, 26);
            txtAddName.TabIndex = 2;
            // 
            // txtAddDescription
            // 
            txtAddDescription.BackColor = Color.WhiteSmoke;
            txtAddDescription.Location = new Point(147, 82);
            txtAddDescription.MaxLength = 20;
            txtAddDescription.Name = "txtAddDescription";
            txtAddDescription.Size = new Size(198, 26);
            txtAddDescription.TabIndex = 4;
            // 
            // lblAddDescription
            // 
            lblAddDescription.AutoSize = true;
            lblAddDescription.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddDescription.ImageAlign = ContentAlignment.MiddleRight;
            lblAddDescription.Location = new Point(33, 85);
            lblAddDescription.Name = "lblAddDescription";
            lblAddDescription.Size = new Size(97, 21);
            lblAddDescription.TabIndex = 3;
            lblAddDescription.Text = "Description";
            // 
            // txtAddUnitSize
            // 
            txtAddUnitSize.BackColor = Color.WhiteSmoke;
            txtAddUnitSize.Location = new Point(147, 137);
            txtAddUnitSize.MaxLength = 20;
            txtAddUnitSize.Name = "txtAddUnitSize";
            txtAddUnitSize.Size = new Size(198, 26);
            txtAddUnitSize.TabIndex = 6;
            // 
            // lblAddUnitSize
            // 
            lblAddUnitSize.AutoSize = true;
            lblAddUnitSize.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddUnitSize.ImageAlign = ContentAlignment.MiddleRight;
            lblAddUnitSize.Location = new Point(51, 140);
            lblAddUnitSize.Name = "lblAddUnitSize";
            lblAddUnitSize.Size = new Size(79, 21);
            lblAddUnitSize.TabIndex = 5;
            lblAddUnitSize.Text = "Unit Size";
            // 
            // txtAddMaterial
            // 
            txtAddMaterial.BackColor = Color.WhiteSmoke;
            txtAddMaterial.Location = new Point(147, 189);
            txtAddMaterial.MaxLength = 20;
            txtAddMaterial.Name = "txtAddMaterial";
            txtAddMaterial.Size = new Size(198, 26);
            txtAddMaterial.TabIndex = 8;
            // 
            // lblAddMaterial
            // 
            lblAddMaterial.AutoSize = true;
            lblAddMaterial.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddMaterial.ImageAlign = ContentAlignment.MiddleRight;
            lblAddMaterial.Location = new Point(55, 192);
            lblAddMaterial.Name = "lblAddMaterial";
            lblAddMaterial.Size = new Size(75, 21);
            lblAddMaterial.TabIndex = 7;
            lblAddMaterial.Text = "Material";
            // 
            // txtAddCost
            // 
            txtAddCost.BackColor = Color.WhiteSmoke;
            txtAddCost.Location = new Point(147, 240);
            txtAddCost.MaxLength = 20;
            txtAddCost.Name = "txtAddCost";
            txtAddCost.Size = new Size(198, 26);
            txtAddCost.TabIndex = 10;
            // 
            // lblAddCost
            // 
            lblAddCost.AutoSize = true;
            lblAddCost.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddCost.ImageAlign = ContentAlignment.MiddleRight;
            lblAddCost.Location = new Point(87, 243);
            lblAddCost.Name = "lblAddCost";
            lblAddCost.Size = new Size(43, 21);
            lblAddCost.TabIndex = 9;
            lblAddCost.Text = "Cost";
            // 
            // btnSubmitAddItem
            // 
            btnSubmitAddItem.BackColor = Color.WhiteSmoke;
            btnSubmitAddItem.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmitAddItem.Location = new Point(347, 390);
            btnSubmitAddItem.Name = "btnSubmitAddItem";
            btnSubmitAddItem.Size = new Size(88, 37);
            btnSubmitAddItem.TabIndex = 11;
            btnSubmitAddItem.Text = "Submit";
            btnSubmitAddItem.UseVisualStyleBackColor = false;
            btnSubmitAddItem.Click += SubmitAddItemEventHandler;
            // 
            // txtAddQuantity
            // 
            txtAddQuantity.BackColor = Color.WhiteSmoke;
            txtAddQuantity.Location = new Point(147, 288);
            txtAddQuantity.MaxLength = 20;
            txtAddQuantity.Name = "txtAddQuantity";
            txtAddQuantity.Size = new Size(198, 26);
            txtAddQuantity.TabIndex = 13;
            // 
            // lbladdQuantity
            // 
            lbladdQuantity.AutoSize = true;
            lbladdQuantity.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbladdQuantity.ImageAlign = ContentAlignment.MiddleRight;
            lbladdQuantity.Location = new Point(54, 288);
            lbladdQuantity.Name = "lbladdQuantity";
            lbladdQuantity.Size = new Size(76, 21);
            lbladdQuantity.TabIndex = 12;
            lbladdQuantity.Text = "Quantity";
            // 
            // grbAtrributes
            // 
            grbAtrributes.Controls.Add(txtAddUnitSize);
            grbAtrributes.Controls.Add(txtAddQuantity);
            grbAtrributes.Controls.Add(lblAddName);
            grbAtrributes.Controls.Add(lbladdQuantity);
            grbAtrributes.Controls.Add(txtAddName);
            grbAtrributes.Controls.Add(lblAddDescription);
            grbAtrributes.Controls.Add(txtAddCost);
            grbAtrributes.Controls.Add(txtAddDescription);
            grbAtrributes.Controls.Add(lblAddCost);
            grbAtrributes.Controls.Add(lblAddUnitSize);
            grbAtrributes.Controls.Add(txtAddMaterial);
            grbAtrributes.Controls.Add(lblAddMaterial);
            grbAtrributes.Location = new Point(210, 51);
            grbAtrributes.Name = "grbAtrributes";
            grbAtrributes.Size = new Size(374, 322);
            grbAtrributes.TabIndex = 14;
            grbAtrributes.TabStop = false;
            grbAtrributes.Text = "Inventory Atrributes";
            // 
            // FrmAddItem
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1029, 630);
            Controls.Add(grbAtrributes);
            Controls.Add(btnSubmitAddItem);
            Controls.Add(lblAddItemTitle);
            Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "FrmAddItem";
            Text = "FrmAddItem";
            grbAtrributes.ResumeLayout(false);
            grbAtrributes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        //Put these in the order of tab for input 
        private Label lblAddItemTitle;
        private Label lblAddName;
        private TextBox txtAddName;
        private TextBox txtAddDescription;
        private Label lblAddDescription;
        private TextBox txtAddUnitSize;
        private Label lblAddUnitSize;
        private TextBox txtAddMaterial;
        private Label lblAddMaterial;
        private TextBox txtAddCost;
        private Label lblAddCost;
        private TextBox txtAddQuantity;
        private Label lbladdQuantity; 
        private Button btnSubmitAddItem;
        private GroupBox grbAtrributes;
    }
}
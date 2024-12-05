/*
 * Harlee Zebley
 * CST-150
 * Milestone Inventory 
 * Citations
 * This is my own work, aided by the study and use of codes learned in textbook and activities
 * */
namespace Milestone_Inventory
{
    partial class FrmInventoryList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSort = new Button();
            btnSearch = new Button();
            fileSystemWatcher1 = new FileSystemWatcher();
            lblListHeader = new Label();
            textBox1 = new TextBox();
            lblInventoryItemName = new Label();
            lblInventoryItemDescription = new Label();
            lblUnitSize = new Label();
            lblMaterial = new Label();
            lblCost = new Label();
            lblQuantity = new Label();
            lblQuantity1 = new Label();
            lblCost1 = new Label();
            lblMaterial1 = new Label();
            lblUnitSize1 = new Label();
            lblInventoryItemDescription1 = new Label();
            lblInventoryItemName1 = new Label();
            btnDecrease1 = new Button();
            btnIncrease1 = new Button();
            btnEditInventory1 = new Button();
            btnEditInventory2 = new Button();
            btnIncrease2 = new Button();
            btnDecrease2 = new Button();
            lblQuantity2 = new Label();
            lblCost2 = new Label();
            lblMaterial2 = new Label();
            lblUnitSize2 = new Label();
            lblInventoryItemDescription2 = new Label();
            lblInventoryItemName2 = new Label();
            btnEditInventory3 = new Button();
            btnIncrease3 = new Button();
            btnDecrease3 = new Button();
            lblQuantity3 = new Label();
            lblCost3 = new Label();
            lblMaterial3 = new Label();
            lblUnitSize3 = new Label();
            lblInventoryItemDescription3 = new Label();
            lblInventoryItemName3 = new Label();
            btnEditInventory4 = new Button();
            btnIncrease4 = new Button();
            btnDecrease4 = new Button();
            lblQuantity4 = new Label();
            lblCost4 = new Label();
            lblMaterial4 = new Label();
            lblUnitSize4 = new Label();
            lblInventoryItemDescription4 = new Label();
            lblInventoryItemName4 = new Label();
            btnEditInventory5 = new Button();
            btnIncrease5 = new Button();
            btnDecrease5 = new Button();
            lblQuantity5 = new Label();
            lblCost5 = new Label();
            lblMaterial5 = new Label();
            lblUnitSize5 = new Label();
            lblInventoryItemDescription5 = new Label();
            lblInventoryItemName5 = new Label();
            btnAddItem = new Button();
            btnEditInventory10 = new Button();
            btnIncrease10 = new Button();
            btnDecrease10 = new Button();
            lblQuantity10 = new Label();
            lblCost10 = new Label();
            lblMaterial10 = new Label();
            lblUnitSize10 = new Label();
            lblInventoryItemDescription10 = new Label();
            lblInventoryItemName10 = new Label();
            btnEditInventory9 = new Button();
            btnIncrease9 = new Button();
            btnDecrease9 = new Button();
            lblQuantity9 = new Label();
            lblCost9 = new Label();
            lblMaterial9 = new Label();
            lblUnitSize9 = new Label();
            lblInventoryItemDescription9 = new Label();
            lblInventoryItemName9 = new Label();
            btnEditInventory8 = new Button();
            btnIncrease8 = new Button();
            btnDecrease8 = new Button();
            lblQuantity8 = new Label();
            lblCost8 = new Label();
            lblMaterial8 = new Label();
            lblUnitSize8 = new Label();
            lblInventoryItemDescription8 = new Label();
            lblInventoryItemName8 = new Label();
            btnEditInventory7 = new Button();
            btnIncrease7 = new Button();
            btnDecrease7 = new Button();
            lblQuantity7 = new Label();
            lblCost7 = new Label();
            lblMaterial7 = new Label();
            lblUnitSize7 = new Label();
            lblInventoryItemDescription7 = new Label();
            lblInventoryItemName7 = new Label();
            btnEditInventory6 = new Button();
            btnIncrease6 = new Button();
            btnDecrease6 = new Button();
            lblQuantity6 = new Label();
            lblCost6 = new Label();
            lblMaterial6 = new Label();
            lblUnitSize6 = new Label();
            lblInventoryItemDescription6 = new Label();
            lblInventoryItemName6 = new Label();
            btnRefresh = new Button();
            lbl1 = new Label();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.DodgerBlue;
            btnSort.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(21, 44);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(81, 24);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(825, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 24);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // lblListHeader
            // 
            lblListHeader.AutoSize = true;
            lblListHeader.BackColor = Color.Transparent;
            lblListHeader.BorderStyle = BorderStyle.FixedSingle;
            lblListHeader.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListHeader.Location = new Point(403, 9);
            lblListHeader.Name = "lblListHeader";
            lblListHeader.Size = new Size(133, 26);
            lblListHeader.TabIndex = 2;
            lblListHeader.Text = "Inventory List";
            lblListHeader.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(642, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 23);
            textBox1.TabIndex = 3;
            // 
            // lblInventoryItemName
            // 
            lblInventoryItemName.AutoSize = true;
            lblInventoryItemName.BackColor = Color.WhiteSmoke;
            lblInventoryItemName.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName.Location = new Point(21, 98);
            lblInventoryItemName.Name = "lblInventoryItemName";
            lblInventoryItemName.Size = new Size(131, 21);
            lblInventoryItemName.TabIndex = 4;
            lblInventoryItemName.Text = "Inventory Name";
            // 
            // lblInventoryItemDescription
            // 
            lblInventoryItemDescription.AutoSize = true;
            lblInventoryItemDescription.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemDescription.Location = new Point(197, 98);
            lblInventoryItemDescription.Name = "lblInventoryItemDescription";
            lblInventoryItemDescription.Size = new Size(173, 21);
            lblInventoryItemDescription.TabIndex = 5;
            lblInventoryItemDescription.Text = "Inventory Description";
            // 
            // lblUnitSize
            // 
            lblUnitSize.AutoSize = true;
            lblUnitSize.BackColor = Color.WhiteSmoke;
            lblUnitSize.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitSize.Location = new Point(423, 98);
            lblUnitSize.Name = "lblUnitSize";
            lblUnitSize.Size = new Size(79, 21);
            lblUnitSize.TabIndex = 6;
            lblUnitSize.Text = "Unit Size";
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.BackColor = Color.WhiteSmoke;
            lblMaterial.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaterial.Location = new Point(540, 98);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(75, 21);
            lblMaterial.TabIndex = 7;
            lblMaterial.Text = "Material";
            // 
            // lblCost
            // 
            lblCost.AutoSize = true;
            lblCost.BackColor = Color.WhiteSmoke;
            lblCost.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCost.Location = new Point(699, 98);
            lblCost.Name = "lblCost";
            lblCost.Size = new Size(43, 21);
            lblCost.TabIndex = 8;
            lblCost.Text = "Cost";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.WhiteSmoke;
            lblQuantity.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(799, 96);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(35, 21);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Qty";
            // 
            // lblQuantity1
            // 
            lblQuantity1.AutoSize = true;
            lblQuantity1.BackColor = Color.WhiteSmoke;
            lblQuantity1.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity1.Location = new Point(802, 129);
            lblQuantity1.Name = "lblQuantity1";
            lblQuantity1.Size = new Size(32, 21);
            lblQuantity1.TabIndex = 15;
            lblQuantity1.Text = "Qty";
            lblQuantity1.Visible = false;
            // 
            // lblCost1
            // 
            lblCost1.AutoSize = true;
            lblCost1.BackColor = Color.WhiteSmoke;
            lblCost1.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost1.Location = new Point(699, 129);
            lblCost1.Name = "lblCost1";
            lblCost1.Size = new Size(39, 21);
            lblCost1.TabIndex = 14;
            lblCost1.Text = "Cost";
            lblCost1.Visible = false;
            // 
            // lblMaterial1
            // 
            lblMaterial1.AutoSize = true;
            lblMaterial1.BackColor = Color.WhiteSmoke;
            lblMaterial1.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial1.Location = new Point(540, 129);
            lblMaterial1.Name = "lblMaterial1";
            lblMaterial1.Size = new Size(67, 21);
            lblMaterial1.TabIndex = 13;
            lblMaterial1.Text = "Material";
            lblMaterial1.Visible = false;
            // 
            // lblUnitSize1
            // 
            lblUnitSize1.AutoSize = true;
            lblUnitSize1.BackColor = Color.WhiteSmoke;
            lblUnitSize1.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize1.Location = new Point(423, 129);
            lblUnitSize1.Name = "lblUnitSize1";
            lblUnitSize1.Size = new Size(70, 21);
            lblUnitSize1.TabIndex = 12;
            lblUnitSize1.Text = "Unit Size";
            lblUnitSize1.Visible = false;
            // 
            // lblInventoryItemDescription1
            // 
            lblInventoryItemDescription1.AutoSize = true;
            lblInventoryItemDescription1.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription1.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription1.Location = new Point(197, 129);
            lblInventoryItemDescription1.Name = "lblInventoryItemDescription1";
            lblInventoryItemDescription1.Size = new Size(152, 21);
            lblInventoryItemDescription1.TabIndex = 11;
            lblInventoryItemDescription1.Text = "Inventory Description";
            lblInventoryItemDescription1.Visible = false;
            // 
            // lblInventoryItemName1
            // 
            lblInventoryItemName1.AutoSize = true;
            lblInventoryItemName1.BackColor = Color.WhiteSmoke;
            lblInventoryItemName1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName1.Location = new Point(21, 129);
            lblInventoryItemName1.Name = "lblInventoryItemName1";
            lblInventoryItemName1.Size = new Size(131, 21);
            lblInventoryItemName1.TabIndex = 10;
            lblInventoryItemName1.Text = "Inventory Name";
            lblInventoryItemName1.Visible = false;
            // 
            // btnDecrease1
            // 
            btnDecrease1.Location = new Point(765, 129);
            btnDecrease1.Name = "btnDecrease1";
            btnDecrease1.Size = new Size(31, 21);
            btnDecrease1.TabIndex = 16;
            btnDecrease1.Text = "<";
            btnDecrease1.UseVisualStyleBackColor = true;
            btnDecrease1.Visible = false;
            btnDecrease1.Click += Quantity1DecreaseEventHandler;
            // 
            // btnIncrease1
            // 
            btnIncrease1.Location = new Point(840, 130);
            btnIncrease1.Name = "btnIncrease1";
            btnIncrease1.Size = new Size(31, 21);
            btnIncrease1.TabIndex = 17;
            btnIncrease1.Text = ">";
            btnIncrease1.UseVisualStyleBackColor = true;
            btnIncrease1.Visible = false;
            btnIncrease1.Click += Quantity1IncreaseEventHandler;
            // 
            // btnEditInventory1
            // 
            btnEditInventory1.AutoSize = true;
            btnEditInventory1.Location = new Point(882, 129);
            btnEditInventory1.Name = "btnEditInventory1";
            btnEditInventory1.Size = new Size(75, 25);
            btnEditInventory1.TabIndex = 18;
            btnEditInventory1.Text = "Edit";
            btnEditInventory1.UseVisualStyleBackColor = true;
            btnEditInventory1.Visible = false;
            // 
            // btnEditInventory2
            // 
            btnEditInventory2.AutoSize = true;
            btnEditInventory2.Location = new Point(882, 160);
            btnEditInventory2.Name = "btnEditInventory2";
            btnEditInventory2.Size = new Size(75, 25);
            btnEditInventory2.TabIndex = 27;
            btnEditInventory2.Text = "Edit";
            btnEditInventory2.UseVisualStyleBackColor = true;
            btnEditInventory2.Visible = false;
            // 
            // btnIncrease2
            // 
            btnIncrease2.Location = new Point(840, 161);
            btnIncrease2.Name = "btnIncrease2";
            btnIncrease2.Size = new Size(31, 21);
            btnIncrease2.TabIndex = 26;
            btnIncrease2.Text = ">";
            btnIncrease2.UseVisualStyleBackColor = true;
            btnIncrease2.Visible = false;
            btnIncrease2.Click += Quantity3IncreaseEventHandler;
            // 
            // btnDecrease2
            // 
            btnDecrease2.Location = new Point(765, 160);
            btnDecrease2.Name = "btnDecrease2";
            btnDecrease2.Size = new Size(31, 21);
            btnDecrease2.TabIndex = 25;
            btnDecrease2.Text = "<";
            btnDecrease2.UseVisualStyleBackColor = true;
            btnDecrease2.Visible = false;
            btnDecrease2.Click += Quantity3DecreaseEventHandler;
            // 
            // lblQuantity2
            // 
            lblQuantity2.AutoSize = true;
            lblQuantity2.BackColor = Color.WhiteSmoke;
            lblQuantity2.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity2.Location = new Point(802, 160);
            lblQuantity2.Name = "lblQuantity2";
            lblQuantity2.Size = new Size(32, 21);
            lblQuantity2.TabIndex = 24;
            lblQuantity2.Text = "Qty";
            lblQuantity2.Visible = false;
            // 
            // lblCost2
            // 
            lblCost2.AutoSize = true;
            lblCost2.BackColor = Color.WhiteSmoke;
            lblCost2.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost2.Location = new Point(699, 160);
            lblCost2.Name = "lblCost2";
            lblCost2.Size = new Size(39, 21);
            lblCost2.TabIndex = 23;
            lblCost2.Text = "Cost";
            lblCost2.Visible = false;
            // 
            // lblMaterial2
            // 
            lblMaterial2.AutoSize = true;
            lblMaterial2.BackColor = Color.WhiteSmoke;
            lblMaterial2.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial2.Location = new Point(540, 160);
            lblMaterial2.Name = "lblMaterial2";
            lblMaterial2.Size = new Size(67, 21);
            lblMaterial2.TabIndex = 22;
            lblMaterial2.Text = "Material";
            lblMaterial2.Visible = false;
            // 
            // lblUnitSize2
            // 
            lblUnitSize2.AutoSize = true;
            lblUnitSize2.BackColor = Color.WhiteSmoke;
            lblUnitSize2.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize2.Location = new Point(423, 160);
            lblUnitSize2.Name = "lblUnitSize2";
            lblUnitSize2.Size = new Size(70, 21);
            lblUnitSize2.TabIndex = 21;
            lblUnitSize2.Text = "Unit Size";
            lblUnitSize2.Visible = false;
            // 
            // lblInventoryItemDescription2
            // 
            lblInventoryItemDescription2.AutoSize = true;
            lblInventoryItemDescription2.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription2.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription2.Location = new Point(197, 160);
            lblInventoryItemDescription2.Name = "lblInventoryItemDescription2";
            lblInventoryItemDescription2.Size = new Size(152, 21);
            lblInventoryItemDescription2.TabIndex = 20;
            lblInventoryItemDescription2.Text = "Inventory Description";
            lblInventoryItemDescription2.Visible = false;
            // 
            // lblInventoryItemName2
            // 
            lblInventoryItemName2.AutoSize = true;
            lblInventoryItemName2.BackColor = Color.WhiteSmoke;
            lblInventoryItemName2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName2.Location = new Point(21, 160);
            lblInventoryItemName2.Name = "lblInventoryItemName2";
            lblInventoryItemName2.Size = new Size(131, 21);
            lblInventoryItemName2.TabIndex = 19;
            lblInventoryItemName2.Text = "Inventory Name";
            lblInventoryItemName2.Visible = false;
            // 
            // btnEditInventory3
            // 
            btnEditInventory3.AutoSize = true;
            btnEditInventory3.Location = new Point(882, 191);
            btnEditInventory3.Name = "btnEditInventory3";
            btnEditInventory3.Size = new Size(75, 25);
            btnEditInventory3.TabIndex = 36;
            btnEditInventory3.Text = "Edit";
            btnEditInventory3.UseVisualStyleBackColor = true;
            btnEditInventory3.Visible = false;
            // 
            // btnIncrease3
            // 
            btnIncrease3.Location = new Point(840, 192);
            btnIncrease3.Name = "btnIncrease3";
            btnIncrease3.Size = new Size(31, 21);
            btnIncrease3.TabIndex = 35;
            btnIncrease3.Text = ">";
            btnIncrease3.UseVisualStyleBackColor = true;
            btnIncrease3.Visible = false;
            btnIncrease3.Click += Quantity4IncreaseEventHandler;
            // 
            // btnDecrease3
            // 
            btnDecrease3.Location = new Point(765, 191);
            btnDecrease3.Name = "btnDecrease3";
            btnDecrease3.Size = new Size(31, 21);
            btnDecrease3.TabIndex = 34;
            btnDecrease3.Text = "<";
            btnDecrease3.UseVisualStyleBackColor = true;
            btnDecrease3.Visible = false;
            btnDecrease3.Click += Quantity4DecreaseEventHandler;
            // 
            // lblQuantity3
            // 
            lblQuantity3.AutoSize = true;
            lblQuantity3.BackColor = Color.WhiteSmoke;
            lblQuantity3.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity3.Location = new Point(802, 191);
            lblQuantity3.Name = "lblQuantity3";
            lblQuantity3.Size = new Size(32, 21);
            lblQuantity3.TabIndex = 33;
            lblQuantity3.Text = "Qty";
            lblQuantity3.Visible = false;
            // 
            // lblCost3
            // 
            lblCost3.AutoSize = true;
            lblCost3.BackColor = Color.WhiteSmoke;
            lblCost3.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost3.Location = new Point(699, 191);
            lblCost3.Name = "lblCost3";
            lblCost3.Size = new Size(39, 21);
            lblCost3.TabIndex = 32;
            lblCost3.Text = "Cost";
            lblCost3.Visible = false;
            // 
            // lblMaterial3
            // 
            lblMaterial3.AutoSize = true;
            lblMaterial3.BackColor = Color.WhiteSmoke;
            lblMaterial3.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial3.Location = new Point(540, 191);
            lblMaterial3.Name = "lblMaterial3";
            lblMaterial3.Size = new Size(67, 21);
            lblMaterial3.TabIndex = 31;
            lblMaterial3.Text = "Material";
            lblMaterial3.Visible = false;
            // 
            // lblUnitSize3
            // 
            lblUnitSize3.AutoSize = true;
            lblUnitSize3.BackColor = Color.WhiteSmoke;
            lblUnitSize3.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize3.Location = new Point(423, 191);
            lblUnitSize3.Name = "lblUnitSize3";
            lblUnitSize3.Size = new Size(70, 21);
            lblUnitSize3.TabIndex = 30;
            lblUnitSize3.Text = "Unit Size";
            lblUnitSize3.Visible = false;
            // 
            // lblInventoryItemDescription3
            // 
            lblInventoryItemDescription3.AutoSize = true;
            lblInventoryItemDescription3.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription3.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription3.Location = new Point(197, 191);
            lblInventoryItemDescription3.Name = "lblInventoryItemDescription3";
            lblInventoryItemDescription3.Size = new Size(152, 21);
            lblInventoryItemDescription3.TabIndex = 29;
            lblInventoryItemDescription3.Text = "Inventory Description";
            lblInventoryItemDescription3.Visible = false;
            // 
            // lblInventoryItemName3
            // 
            lblInventoryItemName3.AutoSize = true;
            lblInventoryItemName3.BackColor = Color.WhiteSmoke;
            lblInventoryItemName3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName3.Location = new Point(21, 191);
            lblInventoryItemName3.Name = "lblInventoryItemName3";
            lblInventoryItemName3.Size = new Size(131, 21);
            lblInventoryItemName3.TabIndex = 28;
            lblInventoryItemName3.Text = "Inventory Name";
            lblInventoryItemName3.Visible = false;
            // 
            // btnEditInventory4
            // 
            btnEditInventory4.AutoSize = true;
            btnEditInventory4.Location = new Point(882, 221);
            btnEditInventory4.Name = "btnEditInventory4";
            btnEditInventory4.Size = new Size(75, 25);
            btnEditInventory4.TabIndex = 45;
            btnEditInventory4.Text = "Edit";
            btnEditInventory4.UseVisualStyleBackColor = true;
            btnEditInventory4.Visible = false;
            // 
            // btnIncrease4
            // 
            btnIncrease4.Location = new Point(840, 222);
            btnIncrease4.Name = "btnIncrease4";
            btnIncrease4.Size = new Size(31, 21);
            btnIncrease4.TabIndex = 44;
            btnIncrease4.Text = ">";
            btnIncrease4.UseVisualStyleBackColor = true;
            btnIncrease4.Visible = false;
            btnIncrease4.Click += Quantity5IncreaseEventHandler;
            // 
            // btnDecrease4
            // 
            btnDecrease4.Location = new Point(765, 221);
            btnDecrease4.Name = "btnDecrease4";
            btnDecrease4.Size = new Size(31, 21);
            btnDecrease4.TabIndex = 43;
            btnDecrease4.Text = "<";
            btnDecrease4.UseVisualStyleBackColor = true;
            btnDecrease4.Visible = false;
            btnDecrease4.Click += Quantity5DecreaseEventHandler;
            // 
            // lblQuantity4
            // 
            lblQuantity4.AutoSize = true;
            lblQuantity4.BackColor = Color.WhiteSmoke;
            lblQuantity4.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity4.Location = new Point(802, 221);
            lblQuantity4.Name = "lblQuantity4";
            lblQuantity4.Size = new Size(32, 21);
            lblQuantity4.TabIndex = 42;
            lblQuantity4.Text = "Qty";
            lblQuantity4.Visible = false;
            // 
            // lblCost4
            // 
            lblCost4.AutoSize = true;
            lblCost4.BackColor = Color.WhiteSmoke;
            lblCost4.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost4.Location = new Point(699, 221);
            lblCost4.Name = "lblCost4";
            lblCost4.Size = new Size(39, 21);
            lblCost4.TabIndex = 41;
            lblCost4.Text = "Cost";
            lblCost4.Visible = false;
            // 
            // lblMaterial4
            // 
            lblMaterial4.AutoSize = true;
            lblMaterial4.BackColor = Color.WhiteSmoke;
            lblMaterial4.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial4.Location = new Point(540, 221);
            lblMaterial4.Name = "lblMaterial4";
            lblMaterial4.Size = new Size(67, 21);
            lblMaterial4.TabIndex = 40;
            lblMaterial4.Text = "Material";
            lblMaterial4.Visible = false;
            // 
            // lblUnitSize4
            // 
            lblUnitSize4.AutoSize = true;
            lblUnitSize4.BackColor = Color.WhiteSmoke;
            lblUnitSize4.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize4.Location = new Point(423, 221);
            lblUnitSize4.Name = "lblUnitSize4";
            lblUnitSize4.Size = new Size(70, 21);
            lblUnitSize4.TabIndex = 39;
            lblUnitSize4.Text = "Unit Size";
            lblUnitSize4.Visible = false;
            // 
            // lblInventoryItemDescription4
            // 
            lblInventoryItemDescription4.AutoSize = true;
            lblInventoryItemDescription4.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription4.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription4.Location = new Point(197, 221);
            lblInventoryItemDescription4.Name = "lblInventoryItemDescription4";
            lblInventoryItemDescription4.Size = new Size(152, 21);
            lblInventoryItemDescription4.TabIndex = 38;
            lblInventoryItemDescription4.Text = "Inventory Description";
            lblInventoryItemDescription4.Visible = false;
            // 
            // lblInventoryItemName4
            // 
            lblInventoryItemName4.AutoSize = true;
            lblInventoryItemName4.BackColor = Color.WhiteSmoke;
            lblInventoryItemName4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName4.Location = new Point(21, 221);
            lblInventoryItemName4.Name = "lblInventoryItemName4";
            lblInventoryItemName4.Size = new Size(131, 21);
            lblInventoryItemName4.TabIndex = 37;
            lblInventoryItemName4.Text = "Inventory Name";
            lblInventoryItemName4.Visible = false;
            // 
            // btnEditInventory5
            // 
            btnEditInventory5.AutoSize = true;
            btnEditInventory5.Location = new Point(882, 252);
            btnEditInventory5.Name = "btnEditInventory5";
            btnEditInventory5.Size = new Size(75, 25);
            btnEditInventory5.TabIndex = 54;
            btnEditInventory5.Text = "Edit";
            btnEditInventory5.UseVisualStyleBackColor = true;
            btnEditInventory5.Visible = false;
            // 
            // btnIncrease5
            // 
            btnIncrease5.Location = new Point(840, 253);
            btnIncrease5.Name = "btnIncrease5";
            btnIncrease5.Size = new Size(31, 21);
            btnIncrease5.TabIndex = 53;
            btnIncrease5.Text = ">";
            btnIncrease5.UseVisualStyleBackColor = true;
            btnIncrease5.Visible = false;
            btnIncrease5.Click += Quantity6IncreaseEventHandler;
            // 
            // btnDecrease5
            // 
            btnDecrease5.Location = new Point(765, 252);
            btnDecrease5.Name = "btnDecrease5";
            btnDecrease5.Size = new Size(31, 21);
            btnDecrease5.TabIndex = 52;
            btnDecrease5.Text = "<";
            btnDecrease5.UseVisualStyleBackColor = true;
            btnDecrease5.Visible = false;
            btnDecrease5.Click += Quantity6DecreaseEventHandler;
            // 
            // lblQuantity5
            // 
            lblQuantity5.AutoSize = true;
            lblQuantity5.BackColor = Color.WhiteSmoke;
            lblQuantity5.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity5.Location = new Point(802, 252);
            lblQuantity5.Name = "lblQuantity5";
            lblQuantity5.Size = new Size(32, 21);
            lblQuantity5.TabIndex = 51;
            lblQuantity5.Text = "Qty";
            lblQuantity5.Visible = false;
            // 
            // lblCost5
            // 
            lblCost5.AutoSize = true;
            lblCost5.BackColor = Color.WhiteSmoke;
            lblCost5.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost5.Location = new Point(699, 252);
            lblCost5.Name = "lblCost5";
            lblCost5.Size = new Size(39, 21);
            lblCost5.TabIndex = 50;
            lblCost5.Text = "Cost";
            lblCost5.Visible = false;
            // 
            // lblMaterial5
            // 
            lblMaterial5.AutoSize = true;
            lblMaterial5.BackColor = Color.WhiteSmoke;
            lblMaterial5.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial5.Location = new Point(540, 252);
            lblMaterial5.Name = "lblMaterial5";
            lblMaterial5.Size = new Size(67, 21);
            lblMaterial5.TabIndex = 49;
            lblMaterial5.Text = "Material";
            lblMaterial5.Visible = false;
            // 
            // lblUnitSize5
            // 
            lblUnitSize5.AutoSize = true;
            lblUnitSize5.BackColor = Color.WhiteSmoke;
            lblUnitSize5.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize5.Location = new Point(423, 252);
            lblUnitSize5.Name = "lblUnitSize5";
            lblUnitSize5.Size = new Size(70, 21);
            lblUnitSize5.TabIndex = 48;
            lblUnitSize5.Text = "Unit Size";
            lblUnitSize5.Visible = false;
            // 
            // lblInventoryItemDescription5
            // 
            lblInventoryItemDescription5.AutoSize = true;
            lblInventoryItemDescription5.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription5.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription5.Location = new Point(197, 252);
            lblInventoryItemDescription5.Name = "lblInventoryItemDescription5";
            lblInventoryItemDescription5.Size = new Size(152, 21);
            lblInventoryItemDescription5.TabIndex = 47;
            lblInventoryItemDescription5.Text = "Inventory Description";
            lblInventoryItemDescription5.Visible = false;
            lblInventoryItemDescription5.Click += lblInventoryItemDescription6_Click;
            // 
            // lblInventoryItemName5
            // 
            lblInventoryItemName5.AutoSize = true;
            lblInventoryItemName5.BackColor = Color.WhiteSmoke;
            lblInventoryItemName5.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName5.Location = new Point(21, 252);
            lblInventoryItemName5.Name = "lblInventoryItemName5";
            lblInventoryItemName5.Size = new Size(131, 21);
            lblInventoryItemName5.TabIndex = 46;
            lblInventoryItemName5.Text = "Inventory Name";
            lblInventoryItemName5.Visible = false;
            // 
            // btnAddItem
            // 
            btnAddItem.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddItem.Location = new Point(414, 470);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(97, 34);
            btnAddItem.TabIndex = 55;
            btnAddItem.Text = "Add Item";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += AddItemEventHandler;
            // 
            // btnEditInventory10
            // 
            btnEditInventory10.AutoSize = true;
            btnEditInventory10.Location = new Point(882, 407);
            btnEditInventory10.Name = "btnEditInventory10";
            btnEditInventory10.Size = new Size(75, 25);
            btnEditInventory10.TabIndex = 101;
            btnEditInventory10.Text = "Edit";
            btnEditInventory10.UseVisualStyleBackColor = true;
            btnEditInventory10.Visible = false;
            // 
            // btnIncrease10
            // 
            btnIncrease10.Location = new Point(840, 408);
            btnIncrease10.Name = "btnIncrease10";
            btnIncrease10.Size = new Size(31, 21);
            btnIncrease10.TabIndex = 100;
            btnIncrease10.Text = ">";
            btnIncrease10.UseVisualStyleBackColor = true;
            btnIncrease10.Visible = false;
            // 
            // btnDecrease10
            // 
            btnDecrease10.Location = new Point(765, 407);
            btnDecrease10.Name = "btnDecrease10";
            btnDecrease10.Size = new Size(31, 21);
            btnDecrease10.TabIndex = 99;
            btnDecrease10.Text = "<";
            btnDecrease10.UseVisualStyleBackColor = true;
            btnDecrease10.Visible = false;
            // 
            // lblQuantity10
            // 
            lblQuantity10.AutoSize = true;
            lblQuantity10.BackColor = Color.WhiteSmoke;
            lblQuantity10.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity10.Location = new Point(802, 407);
            lblQuantity10.Name = "lblQuantity10";
            lblQuantity10.Size = new Size(32, 21);
            lblQuantity10.TabIndex = 98;
            lblQuantity10.Text = "Qty";
            lblQuantity10.Visible = false;
            // 
            // lblCost10
            // 
            lblCost10.AutoSize = true;
            lblCost10.BackColor = Color.WhiteSmoke;
            lblCost10.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost10.Location = new Point(699, 407);
            lblCost10.Name = "lblCost10";
            lblCost10.Size = new Size(39, 21);
            lblCost10.TabIndex = 97;
            lblCost10.Text = "Cost";
            lblCost10.Visible = false;
            // 
            // lblMaterial10
            // 
            lblMaterial10.AutoSize = true;
            lblMaterial10.BackColor = Color.WhiteSmoke;
            lblMaterial10.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial10.Location = new Point(540, 407);
            lblMaterial10.Name = "lblMaterial10";
            lblMaterial10.Size = new Size(67, 21);
            lblMaterial10.TabIndex = 96;
            lblMaterial10.Text = "Material";
            lblMaterial10.Visible = false;
            // 
            // lblUnitSize10
            // 
            lblUnitSize10.AutoSize = true;
            lblUnitSize10.BackColor = Color.WhiteSmoke;
            lblUnitSize10.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize10.Location = new Point(423, 407);
            lblUnitSize10.Name = "lblUnitSize10";
            lblUnitSize10.Size = new Size(70, 21);
            lblUnitSize10.TabIndex = 95;
            lblUnitSize10.Text = "Unit Size";
            lblUnitSize10.Visible = false;
            // 
            // lblInventoryItemDescription10
            // 
            lblInventoryItemDescription10.AutoSize = true;
            lblInventoryItemDescription10.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription10.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription10.Location = new Point(197, 407);
            lblInventoryItemDescription10.Name = "lblInventoryItemDescription10";
            lblInventoryItemDescription10.Size = new Size(152, 21);
            lblInventoryItemDescription10.TabIndex = 94;
            lblInventoryItemDescription10.Text = "Inventory Description";
            lblInventoryItemDescription10.Visible = false;
            // 
            // lblInventoryItemName10
            // 
            lblInventoryItemName10.AutoSize = true;
            lblInventoryItemName10.BackColor = Color.WhiteSmoke;
            lblInventoryItemName10.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName10.Location = new Point(21, 407);
            lblInventoryItemName10.Name = "lblInventoryItemName10";
            lblInventoryItemName10.Size = new Size(131, 21);
            lblInventoryItemName10.TabIndex = 93;
            lblInventoryItemName10.Text = "Inventory Name";
            lblInventoryItemName10.Visible = false;
            // 
            // btnEditInventory9
            // 
            btnEditInventory9.AutoSize = true;
            btnEditInventory9.Location = new Point(882, 376);
            btnEditInventory9.Name = "btnEditInventory9";
            btnEditInventory9.Size = new Size(75, 25);
            btnEditInventory9.TabIndex = 92;
            btnEditInventory9.Text = "Edit";
            btnEditInventory9.UseVisualStyleBackColor = true;
            btnEditInventory9.Visible = false;
            // 
            // btnIncrease9
            // 
            btnIncrease9.Location = new Point(840, 377);
            btnIncrease9.Name = "btnIncrease9";
            btnIncrease9.Size = new Size(31, 21);
            btnIncrease9.TabIndex = 91;
            btnIncrease9.Text = ">";
            btnIncrease9.UseVisualStyleBackColor = true;
            btnIncrease9.Visible = false;
            // 
            // btnDecrease9
            // 
            btnDecrease9.Location = new Point(765, 376);
            btnDecrease9.Name = "btnDecrease9";
            btnDecrease9.Size = new Size(31, 21);
            btnDecrease9.TabIndex = 90;
            btnDecrease9.Text = "<";
            btnDecrease9.UseVisualStyleBackColor = true;
            btnDecrease9.Visible = false;
            // 
            // lblQuantity9
            // 
            lblQuantity9.AutoSize = true;
            lblQuantity9.BackColor = Color.WhiteSmoke;
            lblQuantity9.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity9.Location = new Point(802, 376);
            lblQuantity9.Name = "lblQuantity9";
            lblQuantity9.Size = new Size(32, 21);
            lblQuantity9.TabIndex = 89;
            lblQuantity9.Text = "Qty";
            lblQuantity9.Visible = false;
            // 
            // lblCost9
            // 
            lblCost9.AutoSize = true;
            lblCost9.BackColor = Color.WhiteSmoke;
            lblCost9.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost9.Location = new Point(699, 376);
            lblCost9.Name = "lblCost9";
            lblCost9.Size = new Size(39, 21);
            lblCost9.TabIndex = 88;
            lblCost9.Text = "Cost";
            lblCost9.Visible = false;
            // 
            // lblMaterial9
            // 
            lblMaterial9.AutoSize = true;
            lblMaterial9.BackColor = Color.WhiteSmoke;
            lblMaterial9.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial9.Location = new Point(540, 376);
            lblMaterial9.Name = "lblMaterial9";
            lblMaterial9.Size = new Size(67, 21);
            lblMaterial9.TabIndex = 87;
            lblMaterial9.Text = "Material";
            lblMaterial9.Visible = false;
            // 
            // lblUnitSize9
            // 
            lblUnitSize9.AutoSize = true;
            lblUnitSize9.BackColor = Color.WhiteSmoke;
            lblUnitSize9.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize9.Location = new Point(423, 376);
            lblUnitSize9.Name = "lblUnitSize9";
            lblUnitSize9.Size = new Size(70, 21);
            lblUnitSize9.TabIndex = 86;
            lblUnitSize9.Text = "Unit Size";
            lblUnitSize9.Visible = false;
            // 
            // lblInventoryItemDescription9
            // 
            lblInventoryItemDescription9.AutoSize = true;
            lblInventoryItemDescription9.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription9.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription9.Location = new Point(197, 376);
            lblInventoryItemDescription9.Name = "lblInventoryItemDescription9";
            lblInventoryItemDescription9.Size = new Size(152, 21);
            lblInventoryItemDescription9.TabIndex = 85;
            lblInventoryItemDescription9.Text = "Inventory Description";
            lblInventoryItemDescription9.Visible = false;
            // 
            // lblInventoryItemName9
            // 
            lblInventoryItemName9.AutoSize = true;
            lblInventoryItemName9.BackColor = Color.WhiteSmoke;
            lblInventoryItemName9.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName9.Location = new Point(21, 376);
            lblInventoryItemName9.Name = "lblInventoryItemName9";
            lblInventoryItemName9.Size = new Size(131, 21);
            lblInventoryItemName9.TabIndex = 84;
            lblInventoryItemName9.Text = "Inventory Name";
            lblInventoryItemName9.Visible = false;
            // 
            // btnEditInventory8
            // 
            btnEditInventory8.AutoSize = true;
            btnEditInventory8.Location = new Point(882, 346);
            btnEditInventory8.Name = "btnEditInventory8";
            btnEditInventory8.Size = new Size(75, 25);
            btnEditInventory8.TabIndex = 83;
            btnEditInventory8.Text = "Edit";
            btnEditInventory8.UseVisualStyleBackColor = true;
            btnEditInventory8.Visible = false;
            // 
            // btnIncrease8
            // 
            btnIncrease8.Location = new Point(840, 347);
            btnIncrease8.Name = "btnIncrease8";
            btnIncrease8.Size = new Size(31, 21);
            btnIncrease8.TabIndex = 82;
            btnIncrease8.Text = ">";
            btnIncrease8.UseVisualStyleBackColor = true;
            btnIncrease8.Visible = false;
            // 
            // btnDecrease8
            // 
            btnDecrease8.Location = new Point(765, 346);
            btnDecrease8.Name = "btnDecrease8";
            btnDecrease8.Size = new Size(31, 21);
            btnDecrease8.TabIndex = 81;
            btnDecrease8.Text = "<";
            btnDecrease8.UseVisualStyleBackColor = true;
            btnDecrease8.Visible = false;
            // 
            // lblQuantity8
            // 
            lblQuantity8.AutoSize = true;
            lblQuantity8.BackColor = Color.WhiteSmoke;
            lblQuantity8.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity8.Location = new Point(802, 346);
            lblQuantity8.Name = "lblQuantity8";
            lblQuantity8.Size = new Size(32, 21);
            lblQuantity8.TabIndex = 80;
            lblQuantity8.Text = "Qty";
            lblQuantity8.Visible = false;
            // 
            // lblCost8
            // 
            lblCost8.AutoSize = true;
            lblCost8.BackColor = Color.WhiteSmoke;
            lblCost8.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost8.Location = new Point(699, 346);
            lblCost8.Name = "lblCost8";
            lblCost8.Size = new Size(39, 21);
            lblCost8.TabIndex = 79;
            lblCost8.Text = "Cost";
            lblCost8.Visible = false;
            // 
            // lblMaterial8
            // 
            lblMaterial8.AutoSize = true;
            lblMaterial8.BackColor = Color.WhiteSmoke;
            lblMaterial8.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial8.Location = new Point(540, 346);
            lblMaterial8.Name = "lblMaterial8";
            lblMaterial8.Size = new Size(67, 21);
            lblMaterial8.TabIndex = 78;
            lblMaterial8.Text = "Material";
            lblMaterial8.Visible = false;
            // 
            // lblUnitSize8
            // 
            lblUnitSize8.AutoSize = true;
            lblUnitSize8.BackColor = Color.WhiteSmoke;
            lblUnitSize8.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize8.Location = new Point(423, 346);
            lblUnitSize8.Name = "lblUnitSize8";
            lblUnitSize8.Size = new Size(70, 21);
            lblUnitSize8.TabIndex = 77;
            lblUnitSize8.Text = "Unit Size";
            lblUnitSize8.Visible = false;
            // 
            // lblInventoryItemDescription8
            // 
            lblInventoryItemDescription8.AutoSize = true;
            lblInventoryItemDescription8.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription8.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription8.Location = new Point(197, 346);
            lblInventoryItemDescription8.Name = "lblInventoryItemDescription8";
            lblInventoryItemDescription8.Size = new Size(152, 21);
            lblInventoryItemDescription8.TabIndex = 76;
            lblInventoryItemDescription8.Text = "Inventory Description";
            lblInventoryItemDescription8.Visible = false;
            // 
            // lblInventoryItemName8
            // 
            lblInventoryItemName8.AutoSize = true;
            lblInventoryItemName8.BackColor = Color.WhiteSmoke;
            lblInventoryItemName8.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName8.Location = new Point(21, 346);
            lblInventoryItemName8.Name = "lblInventoryItemName8";
            lblInventoryItemName8.Size = new Size(131, 21);
            lblInventoryItemName8.TabIndex = 75;
            lblInventoryItemName8.Text = "Inventory Name";
            lblInventoryItemName8.Visible = false;
            // 
            // btnEditInventory7
            // 
            btnEditInventory7.AutoSize = true;
            btnEditInventory7.Location = new Point(882, 315);
            btnEditInventory7.Name = "btnEditInventory7";
            btnEditInventory7.Size = new Size(75, 25);
            btnEditInventory7.TabIndex = 74;
            btnEditInventory7.Text = "Edit";
            btnEditInventory7.UseVisualStyleBackColor = true;
            btnEditInventory7.Visible = false;
            // 
            // btnIncrease7
            // 
            btnIncrease7.Location = new Point(840, 316);
            btnIncrease7.Name = "btnIncrease7";
            btnIncrease7.Size = new Size(31, 21);
            btnIncrease7.TabIndex = 73;
            btnIncrease7.Text = ">";
            btnIncrease7.UseVisualStyleBackColor = true;
            btnIncrease7.Visible = false;
            // 
            // btnDecrease7
            // 
            btnDecrease7.Location = new Point(765, 315);
            btnDecrease7.Name = "btnDecrease7";
            btnDecrease7.Size = new Size(31, 21);
            btnDecrease7.TabIndex = 72;
            btnDecrease7.Text = "<";
            btnDecrease7.UseVisualStyleBackColor = true;
            btnDecrease7.Visible = false;
            // 
            // lblQuantity7
            // 
            lblQuantity7.AutoSize = true;
            lblQuantity7.BackColor = Color.WhiteSmoke;
            lblQuantity7.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity7.Location = new Point(802, 315);
            lblQuantity7.Name = "lblQuantity7";
            lblQuantity7.Size = new Size(32, 21);
            lblQuantity7.TabIndex = 71;
            lblQuantity7.Text = "Qty";
            lblQuantity7.Visible = false;
            // 
            // lblCost7
            // 
            lblCost7.AutoSize = true;
            lblCost7.BackColor = Color.WhiteSmoke;
            lblCost7.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost7.Location = new Point(699, 315);
            lblCost7.Name = "lblCost7";
            lblCost7.Size = new Size(39, 21);
            lblCost7.TabIndex = 70;
            lblCost7.Text = "Cost";
            lblCost7.Visible = false;
            // 
            // lblMaterial7
            // 
            lblMaterial7.AutoSize = true;
            lblMaterial7.BackColor = Color.WhiteSmoke;
            lblMaterial7.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial7.Location = new Point(540, 315);
            lblMaterial7.Name = "lblMaterial7";
            lblMaterial7.Size = new Size(67, 21);
            lblMaterial7.TabIndex = 69;
            lblMaterial7.Text = "Material";
            lblMaterial7.Visible = false;
            // 
            // lblUnitSize7
            // 
            lblUnitSize7.AutoSize = true;
            lblUnitSize7.BackColor = Color.WhiteSmoke;
            lblUnitSize7.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize7.Location = new Point(423, 315);
            lblUnitSize7.Name = "lblUnitSize7";
            lblUnitSize7.Size = new Size(70, 21);
            lblUnitSize7.TabIndex = 68;
            lblUnitSize7.Text = "Unit Size";
            lblUnitSize7.Visible = false;
            // 
            // lblInventoryItemDescription7
            // 
            lblInventoryItemDescription7.AutoSize = true;
            lblInventoryItemDescription7.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription7.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription7.Location = new Point(197, 315);
            lblInventoryItemDescription7.Name = "lblInventoryItemDescription7";
            lblInventoryItemDescription7.Size = new Size(152, 21);
            lblInventoryItemDescription7.TabIndex = 67;
            lblInventoryItemDescription7.Text = "Inventory Description";
            lblInventoryItemDescription7.Visible = false;
            // 
            // lblInventoryItemName7
            // 
            lblInventoryItemName7.AutoSize = true;
            lblInventoryItemName7.BackColor = Color.WhiteSmoke;
            lblInventoryItemName7.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName7.Location = new Point(21, 315);
            lblInventoryItemName7.Name = "lblInventoryItemName7";
            lblInventoryItemName7.Size = new Size(131, 21);
            lblInventoryItemName7.TabIndex = 66;
            lblInventoryItemName7.Text = "Inventory Name";
            lblInventoryItemName7.Visible = false;
            // 
            // btnEditInventory6
            // 
            btnEditInventory6.AutoSize = true;
            btnEditInventory6.Location = new Point(882, 284);
            btnEditInventory6.Name = "btnEditInventory6";
            btnEditInventory6.Size = new Size(75, 25);
            btnEditInventory6.TabIndex = 65;
            btnEditInventory6.Text = "Edit";
            btnEditInventory6.UseVisualStyleBackColor = true;
            btnEditInventory6.Visible = false;
            // 
            // btnIncrease6
            // 
            btnIncrease6.Location = new Point(840, 285);
            btnIncrease6.Name = "btnIncrease6";
            btnIncrease6.Size = new Size(31, 21);
            btnIncrease6.TabIndex = 64;
            btnIncrease6.Text = ">";
            btnIncrease6.UseVisualStyleBackColor = true;
            btnIncrease6.Visible = false;
            // 
            // btnDecrease6
            // 
            btnDecrease6.Location = new Point(765, 284);
            btnDecrease6.Name = "btnDecrease6";
            btnDecrease6.Size = new Size(31, 21);
            btnDecrease6.TabIndex = 63;
            btnDecrease6.Text = "<";
            btnDecrease6.UseVisualStyleBackColor = true;
            btnDecrease6.Visible = false;
            // 
            // lblQuantity6
            // 
            lblQuantity6.AutoSize = true;
            lblQuantity6.BackColor = Color.WhiteSmoke;
            lblQuantity6.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity6.Location = new Point(802, 284);
            lblQuantity6.Name = "lblQuantity6";
            lblQuantity6.Size = new Size(32, 21);
            lblQuantity6.TabIndex = 62;
            lblQuantity6.Text = "Qty";
            lblQuantity6.Visible = false;
            // 
            // lblCost6
            // 
            lblCost6.AutoSize = true;
            lblCost6.BackColor = Color.WhiteSmoke;
            lblCost6.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost6.Location = new Point(699, 284);
            lblCost6.Name = "lblCost6";
            lblCost6.Size = new Size(39, 21);
            lblCost6.TabIndex = 61;
            lblCost6.Text = "Cost";
            lblCost6.Visible = false;
            // 
            // lblMaterial6
            // 
            lblMaterial6.AutoSize = true;
            lblMaterial6.BackColor = Color.WhiteSmoke;
            lblMaterial6.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial6.Location = new Point(540, 284);
            lblMaterial6.Name = "lblMaterial6";
            lblMaterial6.Size = new Size(67, 21);
            lblMaterial6.TabIndex = 60;
            lblMaterial6.Text = "Material";
            lblMaterial6.Visible = false;
            // 
            // lblUnitSize6
            // 
            lblUnitSize6.AutoSize = true;
            lblUnitSize6.BackColor = Color.WhiteSmoke;
            lblUnitSize6.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize6.Location = new Point(423, 284);
            lblUnitSize6.Name = "lblUnitSize6";
            lblUnitSize6.Size = new Size(70, 21);
            lblUnitSize6.TabIndex = 59;
            lblUnitSize6.Text = "Unit Size";
            lblUnitSize6.Visible = false;
            // 
            // lblInventoryItemDescription6
            // 
            lblInventoryItemDescription6.AutoSize = true;
            lblInventoryItemDescription6.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription6.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription6.Location = new Point(197, 284);
            lblInventoryItemDescription6.Name = "lblInventoryItemDescription6";
            lblInventoryItemDescription6.Size = new Size(152, 21);
            lblInventoryItemDescription6.TabIndex = 58;
            lblInventoryItemDescription6.Text = "Inventory Description";
            lblInventoryItemDescription6.Visible = false;
            // 
            // lblInventoryItemName6
            // 
            lblInventoryItemName6.AutoSize = true;
            lblInventoryItemName6.BackColor = Color.WhiteSmoke;
            lblInventoryItemName6.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName6.Location = new Point(21, 284);
            lblInventoryItemName6.Name = "lblInventoryItemName6";
            lblInventoryItemName6.Size = new Size(131, 21);
            lblInventoryItemName6.TabIndex = 57;
            lblInventoryItemName6.Text = "Inventory Name";
            lblInventoryItemName6.Visible = false;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(108, 44);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(112, 24);
            btnRefresh.TabIndex = 102;
            btnRefresh.Text = "View / Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += RefreshViewClickEventHandler;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(577, 470);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(38, 15);
            lbl1.TabIndex = 103;
            lbl1.Text = "label1";
            lbl1.Visible = false;
            // 
            // FrmInventoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(977, 516);
            Controls.Add(lbl1);
            Controls.Add(btnRefresh);
            Controls.Add(btnEditInventory10);
            Controls.Add(btnIncrease10);
            Controls.Add(btnDecrease10);
            Controls.Add(lblQuantity10);
            Controls.Add(lblCost10);
            Controls.Add(lblMaterial10);
            Controls.Add(lblUnitSize10);
            Controls.Add(lblInventoryItemDescription10);
            Controls.Add(lblInventoryItemName10);
            Controls.Add(btnEditInventory9);
            Controls.Add(btnIncrease9);
            Controls.Add(btnDecrease9);
            Controls.Add(lblQuantity9);
            Controls.Add(lblCost9);
            Controls.Add(lblMaterial9);
            Controls.Add(lblUnitSize9);
            Controls.Add(lblInventoryItemDescription9);
            Controls.Add(lblInventoryItemName9);
            Controls.Add(btnEditInventory8);
            Controls.Add(btnIncrease8);
            Controls.Add(btnDecrease8);
            Controls.Add(lblQuantity8);
            Controls.Add(lblCost8);
            Controls.Add(lblMaterial8);
            Controls.Add(lblUnitSize8);
            Controls.Add(lblInventoryItemDescription8);
            Controls.Add(lblInventoryItemName8);
            Controls.Add(btnEditInventory7);
            Controls.Add(btnIncrease7);
            Controls.Add(btnDecrease7);
            Controls.Add(lblQuantity7);
            Controls.Add(lblCost7);
            Controls.Add(lblMaterial7);
            Controls.Add(lblUnitSize7);
            Controls.Add(lblInventoryItemDescription7);
            Controls.Add(lblInventoryItemName7);
            Controls.Add(btnEditInventory6);
            Controls.Add(btnIncrease6);
            Controls.Add(btnDecrease6);
            Controls.Add(lblQuantity6);
            Controls.Add(lblCost6);
            Controls.Add(lblMaterial6);
            Controls.Add(lblUnitSize6);
            Controls.Add(lblInventoryItemDescription6);
            Controls.Add(lblInventoryItemName6);
            Controls.Add(btnAddItem);
            Controls.Add(btnEditInventory5);
            Controls.Add(btnIncrease5);
            Controls.Add(btnDecrease5);
            Controls.Add(lblQuantity5);
            Controls.Add(lblCost5);
            Controls.Add(lblMaterial5);
            Controls.Add(lblUnitSize5);
            Controls.Add(lblInventoryItemDescription5);
            Controls.Add(lblInventoryItemName5);
            Controls.Add(btnEditInventory4);
            Controls.Add(btnIncrease4);
            Controls.Add(btnDecrease4);
            Controls.Add(lblQuantity4);
            Controls.Add(lblCost4);
            Controls.Add(lblMaterial4);
            Controls.Add(lblUnitSize4);
            Controls.Add(lblInventoryItemDescription4);
            Controls.Add(lblInventoryItemName4);
            Controls.Add(btnEditInventory3);
            Controls.Add(btnIncrease3);
            Controls.Add(btnDecrease3);
            Controls.Add(lblQuantity3);
            Controls.Add(lblCost3);
            Controls.Add(lblMaterial3);
            Controls.Add(lblUnitSize3);
            Controls.Add(lblInventoryItemDescription3);
            Controls.Add(lblInventoryItemName3);
            Controls.Add(btnEditInventory2);
            Controls.Add(btnIncrease2);
            Controls.Add(btnDecrease2);
            Controls.Add(lblQuantity2);
            Controls.Add(lblCost2);
            Controls.Add(lblMaterial2);
            Controls.Add(lblUnitSize2);
            Controls.Add(lblInventoryItemDescription2);
            Controls.Add(lblInventoryItemName2);
            Controls.Add(btnEditInventory1);
            Controls.Add(btnIncrease1);
            Controls.Add(btnDecrease1);
            Controls.Add(lblQuantity1);
            Controls.Add(lblCost1);
            Controls.Add(lblMaterial1);
            Controls.Add(lblUnitSize1);
            Controls.Add(lblInventoryItemDescription1);
            Controls.Add(lblInventoryItemName1);
            Controls.Add(lblQuantity);
            Controls.Add(lblCost);
            Controls.Add(lblMaterial);
            Controls.Add(lblUnitSize);
            Controls.Add(lblInventoryItemDescription);
            Controls.Add(lblInventoryItemName);
            Controls.Add(textBox1);
            Controls.Add(lblListHeader);
            Controls.Add(btnSearch);
            Controls.Add(btnSort);
            Name = "FrmInventoryList";
            Text = "Inventory List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private Button btnSearch;
        private FileSystemWatcher fileSystemWatcher1;
        private Label lblListHeader;
        private Label lblInventoryItemName;
        private TextBox textBox1;
        private Label lblInventoryItemDescription;
        private Label lblUnitSize;
        private Button btnDecrease1;
        private Label lblQuantity1;
        private Label lblCost1;
        private Label lblMaterial1;
        private Label lblUnitSize1;
        private Label lblInventoryItemDescription1;
        private Label lblInventoryItemName1;
        private Label lblQuantity;
        private Label lblCost;
        private Label lblMaterial;
        private Button btnIncrease1;
        private Button btnEditInventory1;
        private Button btnEditInventory2;
        private Button btnIncrease2;
        private Button btnDecrease2;
        private Label lblQuantity2;
        private Label lblCost2;
        private Label lblMaterial2;
        private Label lblUnitSize2;
        private Label lblInventoryItemDescription2;
        private Label lblInventoryItemName2;
        private Button btnEditInventory5;
        private Button btnIncrease5;
        private Button btnDecrease5;
        private Label lblQuantity5;
        private Label lblCost5;
        private Label lblMaterial5;
        private Label lblUnitSize5;
        private Label lblInventoryItemDescription5;
        private Label lblInventoryItemName5;
        private Button btnEditInventory4;
        private Button btnIncrease4;
        private Button btnDecrease4;
        private Label lblQuantity4;
        private Label lblCost4;
        private Label lblMaterial4;
        private Label lblUnitSize4;
        private Label lblInventoryItemDescription4;
        private Label lblInventoryItemName4;
        private Button btnEditInventory3;
        private Button btnIncrease3;
        private Button btnDecrease3;
        private Label lblQuantity3;
        private Label lblCost3;
        private Label lblMaterial3;
        private Label lblUnitSize3;
        private Label lblInventoryItemDescription3;
        private Label lblInventoryItemName3;
        private Button btnAddItem;
        private Button btnEditInventory10;
        private Button btnIncrease10;
        private Button btnDecrease10;
        private Label lblQuantity10;
        private Label lblCost10;
        private Label lblMaterial10;
        private Label lblUnitSize10;
        private Label lblInventoryItemDescription10;
        private Label lblInventoryItemName10;
        private Button btnEditInventory9;
        private Button btnIncrease9;
        private Button btnDecrease9;
        private Label lblQuantity9;
        private Label lblCost9;
        private Label lblMaterial9;
        private Label lblUnitSize9;
        private Label lblInventoryItemDescription9;
        private Label lblInventoryItemName9;
        private Button btnEditInventory8;
        private Button btnIncrease8;
        private Button btnDecrease8;
        private Label lblQuantity8;
        private Label lblCost8;
        private Label lblMaterial8;
        private Label lblUnitSize8;
        private Label lblInventoryItemDescription8;
        private Label lblInventoryItemName8;
        private Button btnEditInventory7;
        private Button btnIncrease7;
        private Button btnDecrease7;
        private Label lblQuantity7;
        private Label lblCost7;
        private Label lblMaterial7;
        private Label lblUnitSize7;
        private Label lblInventoryItemDescription7;
        private Label lblInventoryItemName7;
        private Button btnEditInventory6;
        private Button btnIncrease6;
        private Button btnDecrease6;
        private Label lblQuantity6;
        private Label lblCost6;
        private Label lblMaterial6;
        private Label lblUnitSize6;
        private Label lblInventoryItemDescription6;
        private Label lblInventoryItemName6;
        private Button btnRefresh;
        private Label lbl1;
    }
}

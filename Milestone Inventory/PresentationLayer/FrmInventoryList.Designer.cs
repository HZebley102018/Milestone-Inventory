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
            txtSearch = new TextBox();
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
            btnAddNewItem = new Button();
            gvInventoryList = new DataGridView();
            btnIncQty = new Button();
            btnDecQty = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gvInventoryList).BeginInit();
            SuspendLayout();
            // 
            // btnSort
            // 
            btnSort.BackColor = Color.DodgerBlue;
            btnSort.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSort.Location = new Point(79, 44);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(81, 24);
            btnSort.TabIndex = 0;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = false;
            btnSort.Click += BtnSort_ClickEventHandler;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(765, 44);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 24);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += BtnSearch_ClickEventHandler;
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
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(589, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(177, 22);
            txtSearch.TabIndex = 3;
            // 
            // lblQuantity1
            // 
            lblQuantity1.Location = new Point(0, 0);
            lblQuantity1.Name = "lblQuantity1";
            lblQuantity1.Size = new Size(100, 23);
            lblQuantity1.TabIndex = 194;
            // 
            // lblCost1
            // 
            lblCost1.Location = new Point(0, 0);
            lblCost1.Name = "lblCost1";
            lblCost1.Size = new Size(100, 23);
            lblCost1.TabIndex = 195;
            // 
            // lblMaterial1
            // 
            lblMaterial1.Location = new Point(0, 0);
            lblMaterial1.Name = "lblMaterial1";
            lblMaterial1.Size = new Size(100, 23);
            lblMaterial1.TabIndex = 196;
            // 
            // lblUnitSize1
            // 
            lblUnitSize1.Location = new Point(0, 0);
            lblUnitSize1.Name = "lblUnitSize1";
            lblUnitSize1.Size = new Size(100, 23);
            lblUnitSize1.TabIndex = 197;
            // 
            // lblInventoryItemDescription1
            // 
            lblInventoryItemDescription1.Location = new Point(0, 0);
            lblInventoryItemDescription1.Name = "lblInventoryItemDescription1";
            lblInventoryItemDescription1.Size = new Size(100, 23);
            lblInventoryItemDescription1.TabIndex = 198;
            // 
            // lblInventoryItemName1
            // 
            lblInventoryItemName1.Location = new Point(0, 0);
            lblInventoryItemName1.Name = "lblInventoryItemName1";
            lblInventoryItemName1.Size = new Size(100, 23);
            lblInventoryItemName1.TabIndex = 199;
            // 
            // btnDecrease1
            // 
            btnDecrease1.Location = new Point(0, 0);
            btnDecrease1.Name = "btnDecrease1";
            btnDecrease1.Size = new Size(75, 23);
            btnDecrease1.TabIndex = 193;
            // 
            // btnIncrease1
            // 
            btnIncrease1.Location = new Point(0, 0);
            btnIncrease1.Name = "btnIncrease1";
            btnIncrease1.Size = new Size(75, 23);
            btnIncrease1.TabIndex = 192;
            // 
            // btnEditInventory1
            // 
            btnEditInventory1.Location = new Point(0, 0);
            btnEditInventory1.Name = "btnEditInventory1";
            btnEditInventory1.Size = new Size(75, 23);
            btnEditInventory1.TabIndex = 191;
            // 
            // btnEditInventory2
            // 
            btnEditInventory2.Location = new Point(0, 0);
            btnEditInventory2.Name = "btnEditInventory2";
            btnEditInventory2.Size = new Size(75, 23);
            btnEditInventory2.TabIndex = 182;
            // 
            // btnIncrease2
            // 
            btnIncrease2.Location = new Point(0, 0);
            btnIncrease2.Name = "btnIncrease2";
            btnIncrease2.Size = new Size(75, 23);
            btnIncrease2.TabIndex = 183;
            // 
            // btnDecrease2
            // 
            btnDecrease2.Location = new Point(0, 0);
            btnDecrease2.Name = "btnDecrease2";
            btnDecrease2.Size = new Size(75, 23);
            btnDecrease2.TabIndex = 184;
            // 
            // lblQuantity2
            // 
            lblQuantity2.Location = new Point(0, 0);
            lblQuantity2.Name = "lblQuantity2";
            lblQuantity2.Size = new Size(100, 23);
            lblQuantity2.TabIndex = 185;
            // 
            // lblCost2
            // 
            lblCost2.Location = new Point(0, 0);
            lblCost2.Name = "lblCost2";
            lblCost2.Size = new Size(100, 23);
            lblCost2.TabIndex = 186;
            // 
            // lblMaterial2
            // 
            lblMaterial2.Location = new Point(0, 0);
            lblMaterial2.Name = "lblMaterial2";
            lblMaterial2.Size = new Size(100, 23);
            lblMaterial2.TabIndex = 187;
            // 
            // lblUnitSize2
            // 
            lblUnitSize2.Location = new Point(0, 0);
            lblUnitSize2.Name = "lblUnitSize2";
            lblUnitSize2.Size = new Size(100, 23);
            lblUnitSize2.TabIndex = 188;
            // 
            // lblInventoryItemDescription2
            // 
            lblInventoryItemDescription2.Location = new Point(0, 0);
            lblInventoryItemDescription2.Name = "lblInventoryItemDescription2";
            lblInventoryItemDescription2.Size = new Size(100, 23);
            lblInventoryItemDescription2.TabIndex = 189;
            // 
            // lblInventoryItemName2
            // 
            lblInventoryItemName2.Location = new Point(0, 0);
            lblInventoryItemName2.Name = "lblInventoryItemName2";
            lblInventoryItemName2.Size = new Size(100, 23);
            lblInventoryItemName2.TabIndex = 190;
            // 
            // btnEditInventory3
            // 
            btnEditInventory3.Location = new Point(0, 0);
            btnEditInventory3.Name = "btnEditInventory3";
            btnEditInventory3.Size = new Size(75, 23);
            btnEditInventory3.TabIndex = 173;
            // 
            // btnIncrease3
            // 
            btnIncrease3.Location = new Point(0, 0);
            btnIncrease3.Name = "btnIncrease3";
            btnIncrease3.Size = new Size(75, 23);
            btnIncrease3.TabIndex = 174;
            // 
            // btnDecrease3
            // 
            btnDecrease3.Location = new Point(0, 0);
            btnDecrease3.Name = "btnDecrease3";
            btnDecrease3.Size = new Size(75, 23);
            btnDecrease3.TabIndex = 175;
            // 
            // lblQuantity3
            // 
            lblQuantity3.Location = new Point(0, 0);
            lblQuantity3.Name = "lblQuantity3";
            lblQuantity3.Size = new Size(100, 23);
            lblQuantity3.TabIndex = 176;
            // 
            // lblCost3
            // 
            lblCost3.Location = new Point(0, 0);
            lblCost3.Name = "lblCost3";
            lblCost3.Size = new Size(100, 23);
            lblCost3.TabIndex = 177;
            // 
            // lblMaterial3
            // 
            lblMaterial3.Location = new Point(0, 0);
            lblMaterial3.Name = "lblMaterial3";
            lblMaterial3.Size = new Size(100, 23);
            lblMaterial3.TabIndex = 178;
            // 
            // lblUnitSize3
            // 
            lblUnitSize3.Location = new Point(0, 0);
            lblUnitSize3.Name = "lblUnitSize3";
            lblUnitSize3.Size = new Size(100, 23);
            lblUnitSize3.TabIndex = 179;
            // 
            // lblInventoryItemDescription3
            // 
            lblInventoryItemDescription3.Location = new Point(0, 0);
            lblInventoryItemDescription3.Name = "lblInventoryItemDescription3";
            lblInventoryItemDescription3.Size = new Size(100, 23);
            lblInventoryItemDescription3.TabIndex = 180;
            // 
            // lblInventoryItemName3
            // 
            lblInventoryItemName3.Location = new Point(0, 0);
            lblInventoryItemName3.Name = "lblInventoryItemName3";
            lblInventoryItemName3.Size = new Size(100, 23);
            lblInventoryItemName3.TabIndex = 181;
            // 
            // btnEditInventory4
            // 
            btnEditInventory4.Location = new Point(0, 0);
            btnEditInventory4.Name = "btnEditInventory4";
            btnEditInventory4.Size = new Size(75, 23);
            btnEditInventory4.TabIndex = 164;
            // 
            // btnIncrease4
            // 
            btnIncrease4.Location = new Point(0, 0);
            btnIncrease4.Name = "btnIncrease4";
            btnIncrease4.Size = new Size(75, 23);
            btnIncrease4.TabIndex = 165;
            // 
            // btnDecrease4
            // 
            btnDecrease4.Location = new Point(0, 0);
            btnDecrease4.Name = "btnDecrease4";
            btnDecrease4.Size = new Size(75, 23);
            btnDecrease4.TabIndex = 166;
            // 
            // lblQuantity4
            // 
            lblQuantity4.Location = new Point(0, 0);
            lblQuantity4.Name = "lblQuantity4";
            lblQuantity4.Size = new Size(100, 23);
            lblQuantity4.TabIndex = 167;
            // 
            // lblCost4
            // 
            lblCost4.Location = new Point(0, 0);
            lblCost4.Name = "lblCost4";
            lblCost4.Size = new Size(100, 23);
            lblCost4.TabIndex = 168;
            // 
            // lblMaterial4
            // 
            lblMaterial4.Location = new Point(0, 0);
            lblMaterial4.Name = "lblMaterial4";
            lblMaterial4.Size = new Size(100, 23);
            lblMaterial4.TabIndex = 169;
            // 
            // lblUnitSize4
            // 
            lblUnitSize4.Location = new Point(0, 0);
            lblUnitSize4.Name = "lblUnitSize4";
            lblUnitSize4.Size = new Size(100, 23);
            lblUnitSize4.TabIndex = 170;
            // 
            // lblInventoryItemDescription4
            // 
            lblInventoryItemDescription4.Location = new Point(0, 0);
            lblInventoryItemDescription4.Name = "lblInventoryItemDescription4";
            lblInventoryItemDescription4.Size = new Size(100, 23);
            lblInventoryItemDescription4.TabIndex = 171;
            // 
            // lblInventoryItemName4
            // 
            lblInventoryItemName4.Location = new Point(0, 0);
            lblInventoryItemName4.Name = "lblInventoryItemName4";
            lblInventoryItemName4.Size = new Size(100, 23);
            lblInventoryItemName4.TabIndex = 172;
            // 
            // btnEditInventory5
            // 
            btnEditInventory5.Location = new Point(0, 0);
            btnEditInventory5.Name = "btnEditInventory5";
            btnEditInventory5.Size = new Size(75, 23);
            btnEditInventory5.TabIndex = 155;
            // 
            // btnIncrease5
            // 
            btnIncrease5.Location = new Point(0, 0);
            btnIncrease5.Name = "btnIncrease5";
            btnIncrease5.Size = new Size(75, 23);
            btnIncrease5.TabIndex = 156;
            // 
            // btnDecrease5
            // 
            btnDecrease5.Location = new Point(0, 0);
            btnDecrease5.Name = "btnDecrease5";
            btnDecrease5.Size = new Size(75, 23);
            btnDecrease5.TabIndex = 157;
            // 
            // lblQuantity5
            // 
            lblQuantity5.Location = new Point(0, 0);
            lblQuantity5.Name = "lblQuantity5";
            lblQuantity5.Size = new Size(100, 23);
            lblQuantity5.TabIndex = 158;
            // 
            // lblCost5
            // 
            lblCost5.Location = new Point(0, 0);
            lblCost5.Name = "lblCost5";
            lblCost5.Size = new Size(100, 23);
            lblCost5.TabIndex = 159;
            // 
            // lblMaterial5
            // 
            lblMaterial5.Location = new Point(0, 0);
            lblMaterial5.Name = "lblMaterial5";
            lblMaterial5.Size = new Size(100, 23);
            lblMaterial5.TabIndex = 160;
            // 
            // lblUnitSize5
            // 
            lblUnitSize5.Location = new Point(0, 0);
            lblUnitSize5.Name = "lblUnitSize5";
            lblUnitSize5.Size = new Size(100, 23);
            lblUnitSize5.TabIndex = 161;
            // 
            // lblInventoryItemDescription5
            // 
            lblInventoryItemDescription5.Location = new Point(0, 0);
            lblInventoryItemDescription5.Name = "lblInventoryItemDescription5";
            lblInventoryItemDescription5.Size = new Size(100, 23);
            lblInventoryItemDescription5.TabIndex = 162;
            // 
            // lblInventoryItemName5
            // 
            lblInventoryItemName5.Location = new Point(0, 0);
            lblInventoryItemName5.Name = "lblInventoryItemName5";
            lblInventoryItemName5.Size = new Size(100, 23);
            lblInventoryItemName5.TabIndex = 163;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(0, 0);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(75, 23);
            btnAddItem.TabIndex = 154;
            // 
            // lblQuantity10
            // 
            lblQuantity10.Location = new Point(0, 0);
            lblQuantity10.Name = "lblQuantity10";
            lblQuantity10.Size = new Size(100, 23);
            lblQuantity10.TabIndex = 112;
            // 
            // lblCost10
            // 
            lblCost10.Location = new Point(0, 0);
            lblCost10.Name = "lblCost10";
            lblCost10.Size = new Size(100, 23);
            lblCost10.TabIndex = 113;
            // 
            // lblMaterial10
            // 
            lblMaterial10.Location = new Point(0, 0);
            lblMaterial10.Name = "lblMaterial10";
            lblMaterial10.Size = new Size(100, 23);
            lblMaterial10.TabIndex = 114;
            // 
            // lblUnitSize10
            // 
            lblUnitSize10.Location = new Point(0, 0);
            lblUnitSize10.Name = "lblUnitSize10";
            lblUnitSize10.Size = new Size(100, 23);
            lblUnitSize10.TabIndex = 115;
            // 
            // lblInventoryItemDescription10
            // 
            lblInventoryItemDescription10.Location = new Point(0, 0);
            lblInventoryItemDescription10.Name = "lblInventoryItemDescription10";
            lblInventoryItemDescription10.Size = new Size(100, 23);
            lblInventoryItemDescription10.TabIndex = 116;
            // 
            // lblInventoryItemName10
            // 
            lblInventoryItemName10.Location = new Point(0, 0);
            lblInventoryItemName10.Name = "lblInventoryItemName10";
            lblInventoryItemName10.Size = new Size(100, 23);
            lblInventoryItemName10.TabIndex = 117;
            // 
            // btnEditInventory9
            // 
            btnEditInventory9.Location = new Point(0, 0);
            btnEditInventory9.Name = "btnEditInventory9";
            btnEditInventory9.Size = new Size(75, 23);
            btnEditInventory9.TabIndex = 118;
            // 
            // btnIncrease9
            // 
            btnIncrease9.Location = new Point(0, 0);
            btnIncrease9.Name = "btnIncrease9";
            btnIncrease9.Size = new Size(75, 23);
            btnIncrease9.TabIndex = 119;
            // 
            // btnDecrease9
            // 
            btnDecrease9.Location = new Point(0, 0);
            btnDecrease9.Name = "btnDecrease9";
            btnDecrease9.Size = new Size(75, 23);
            btnDecrease9.TabIndex = 120;
            // 
            // lblQuantity9
            // 
            lblQuantity9.Location = new Point(0, 0);
            lblQuantity9.Name = "lblQuantity9";
            lblQuantity9.Size = new Size(100, 23);
            lblQuantity9.TabIndex = 121;
            // 
            // lblCost9
            // 
            lblCost9.Location = new Point(0, 0);
            lblCost9.Name = "lblCost9";
            lblCost9.Size = new Size(100, 23);
            lblCost9.TabIndex = 122;
            // 
            // lblMaterial9
            // 
            lblMaterial9.Location = new Point(0, 0);
            lblMaterial9.Name = "lblMaterial9";
            lblMaterial9.Size = new Size(100, 23);
            lblMaterial9.TabIndex = 123;
            // 
            // lblUnitSize9
            // 
            lblUnitSize9.Location = new Point(0, 0);
            lblUnitSize9.Name = "lblUnitSize9";
            lblUnitSize9.Size = new Size(100, 23);
            lblUnitSize9.TabIndex = 124;
            // 
            // lblInventoryItemDescription9
            // 
            lblInventoryItemDescription9.Location = new Point(0, 0);
            lblInventoryItemDescription9.Name = "lblInventoryItemDescription9";
            lblInventoryItemDescription9.Size = new Size(100, 23);
            lblInventoryItemDescription9.TabIndex = 125;
            // 
            // lblInventoryItemName9
            // 
            lblInventoryItemName9.Location = new Point(0, 0);
            lblInventoryItemName9.Name = "lblInventoryItemName9";
            lblInventoryItemName9.Size = new Size(100, 23);
            lblInventoryItemName9.TabIndex = 126;
            // 
            // btnEditInventory8
            // 
            btnEditInventory8.Location = new Point(0, 0);
            btnEditInventory8.Name = "btnEditInventory8";
            btnEditInventory8.Size = new Size(75, 23);
            btnEditInventory8.TabIndex = 127;
            // 
            // btnIncrease8
            // 
            btnIncrease8.Location = new Point(0, 0);
            btnIncrease8.Name = "btnIncrease8";
            btnIncrease8.Size = new Size(75, 23);
            btnIncrease8.TabIndex = 128;
            // 
            // btnDecrease8
            // 
            btnDecrease8.Location = new Point(0, 0);
            btnDecrease8.Name = "btnDecrease8";
            btnDecrease8.Size = new Size(75, 23);
            btnDecrease8.TabIndex = 129;
            // 
            // lblQuantity8
            // 
            lblQuantity8.Location = new Point(0, 0);
            lblQuantity8.Name = "lblQuantity8";
            lblQuantity8.Size = new Size(100, 23);
            lblQuantity8.TabIndex = 130;
            // 
            // lblCost8
            // 
            lblCost8.Location = new Point(0, 0);
            lblCost8.Name = "lblCost8";
            lblCost8.Size = new Size(100, 23);
            lblCost8.TabIndex = 131;
            // 
            // lblMaterial8
            // 
            lblMaterial8.Location = new Point(0, 0);
            lblMaterial8.Name = "lblMaterial8";
            lblMaterial8.Size = new Size(100, 23);
            lblMaterial8.TabIndex = 132;
            // 
            // lblUnitSize8
            // 
            lblUnitSize8.Location = new Point(0, 0);
            lblUnitSize8.Name = "lblUnitSize8";
            lblUnitSize8.Size = new Size(100, 23);
            lblUnitSize8.TabIndex = 133;
            // 
            // lblInventoryItemDescription8
            // 
            lblInventoryItemDescription8.Location = new Point(0, 0);
            lblInventoryItemDescription8.Name = "lblInventoryItemDescription8";
            lblInventoryItemDescription8.Size = new Size(100, 23);
            lblInventoryItemDescription8.TabIndex = 134;
            // 
            // lblInventoryItemName8
            // 
            lblInventoryItemName8.Location = new Point(0, 0);
            lblInventoryItemName8.Name = "lblInventoryItemName8";
            lblInventoryItemName8.Size = new Size(100, 23);
            lblInventoryItemName8.TabIndex = 135;
            // 
            // btnEditInventory7
            // 
            btnEditInventory7.Location = new Point(0, 0);
            btnEditInventory7.Name = "btnEditInventory7";
            btnEditInventory7.Size = new Size(75, 23);
            btnEditInventory7.TabIndex = 136;
            // 
            // btnIncrease7
            // 
            btnIncrease7.Location = new Point(0, 0);
            btnIncrease7.Name = "btnIncrease7";
            btnIncrease7.Size = new Size(75, 23);
            btnIncrease7.TabIndex = 137;
            // 
            // btnDecrease7
            // 
            btnDecrease7.Location = new Point(0, 0);
            btnDecrease7.Name = "btnDecrease7";
            btnDecrease7.Size = new Size(75, 23);
            btnDecrease7.TabIndex = 138;
            // 
            // lblQuantity7
            // 
            lblQuantity7.Location = new Point(0, 0);
            lblQuantity7.Name = "lblQuantity7";
            lblQuantity7.Size = new Size(100, 23);
            lblQuantity7.TabIndex = 139;
            // 
            // lblCost7
            // 
            lblCost7.Location = new Point(0, 0);
            lblCost7.Name = "lblCost7";
            lblCost7.Size = new Size(100, 23);
            lblCost7.TabIndex = 140;
            // 
            // lblMaterial7
            // 
            lblMaterial7.Location = new Point(0, 0);
            lblMaterial7.Name = "lblMaterial7";
            lblMaterial7.Size = new Size(100, 23);
            lblMaterial7.TabIndex = 141;
            // 
            // lblUnitSize7
            // 
            lblUnitSize7.Location = new Point(0, 0);
            lblUnitSize7.Name = "lblUnitSize7";
            lblUnitSize7.Size = new Size(100, 23);
            lblUnitSize7.TabIndex = 142;
            // 
            // lblInventoryItemDescription7
            // 
            lblInventoryItemDescription7.Location = new Point(0, 0);
            lblInventoryItemDescription7.Name = "lblInventoryItemDescription7";
            lblInventoryItemDescription7.Size = new Size(100, 23);
            lblInventoryItemDescription7.TabIndex = 143;
            // 
            // lblInventoryItemName7
            // 
            lblInventoryItemName7.Location = new Point(0, 0);
            lblInventoryItemName7.Name = "lblInventoryItemName7";
            lblInventoryItemName7.Size = new Size(100, 23);
            lblInventoryItemName7.TabIndex = 144;
            // 
            // btnEditInventory6
            // 
            btnEditInventory6.Location = new Point(0, 0);
            btnEditInventory6.Name = "btnEditInventory6";
            btnEditInventory6.Size = new Size(75, 23);
            btnEditInventory6.TabIndex = 145;
            // 
            // btnIncrease6
            // 
            btnIncrease6.Location = new Point(0, 0);
            btnIncrease6.Name = "btnIncrease6";
            btnIncrease6.Size = new Size(75, 23);
            btnIncrease6.TabIndex = 146;
            // 
            // btnDecrease6
            // 
            btnDecrease6.Location = new Point(0, 0);
            btnDecrease6.Name = "btnDecrease6";
            btnDecrease6.Size = new Size(75, 23);
            btnDecrease6.TabIndex = 147;
            // 
            // lblQuantity6
            // 
            lblQuantity6.Location = new Point(0, 0);
            lblQuantity6.Name = "lblQuantity6";
            lblQuantity6.Size = new Size(100, 23);
            lblQuantity6.TabIndex = 148;
            // 
            // lblCost6
            // 
            lblCost6.Location = new Point(0, 0);
            lblCost6.Name = "lblCost6";
            lblCost6.Size = new Size(100, 23);
            lblCost6.TabIndex = 149;
            // 
            // lblMaterial6
            // 
            lblMaterial6.Location = new Point(0, 0);
            lblMaterial6.Name = "lblMaterial6";
            lblMaterial6.Size = new Size(100, 23);
            lblMaterial6.TabIndex = 150;
            // 
            // lblUnitSize6
            // 
            lblUnitSize6.Location = new Point(0, 0);
            lblUnitSize6.Name = "lblUnitSize6";
            lblUnitSize6.Size = new Size(100, 23);
            lblUnitSize6.TabIndex = 151;
            // 
            // lblInventoryItemDescription6
            // 
            lblInventoryItemDescription6.Location = new Point(0, 0);
            lblInventoryItemDescription6.Name = "lblInventoryItemDescription6";
            lblInventoryItemDescription6.Size = new Size(100, 23);
            lblInventoryItemDescription6.TabIndex = 152;
            // 
            // lblInventoryItemName6
            // 
            lblInventoryItemName6.Location = new Point(0, 0);
            lblInventoryItemName6.Name = "lblInventoryItemName6";
            lblInventoryItemName6.Size = new Size(100, 23);
            lblInventoryItemName6.TabIndex = 153;
            // 
            // btnAddNewItem
            // 
            btnAddNewItem.AutoSize = true;
            btnAddNewItem.BackColor = Color.DodgerBlue;
            btnAddNewItem.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNewItem.Location = new Point(429, 477);
            btnAddNewItem.Name = "btnAddNewItem";
            btnAddNewItem.Size = new Size(107, 27);
            btnAddNewItem.TabIndex = 200;
            btnAddNewItem.Text = "Add New Item";
            btnAddNewItem.UseVisualStyleBackColor = false;
            btnAddNewItem.Click += AddINewItemEventHandler;
            // 
            // gvInventoryList
            // 
            gvInventoryList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvInventoryList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gvInventoryList.BackgroundColor = Color.PowderBlue;
            gvInventoryList.BorderStyle = BorderStyle.None;
            gvInventoryList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvInventoryList.Location = new Point(79, 138);
            gvInventoryList.Name = "gvInventoryList";
            gvInventoryList.Size = new Size(772, 279);
            gvInventoryList.TabIndex = 201;
            gvInventoryList.Click += GridView_ClickEventHandler;
            // 
            // btnIncQty
            // 
            btnIncQty.BackColor = Color.DodgerBlue;
            btnIncQty.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIncQty.Location = new Point(599, 107);
            btnIncQty.Name = "btnIncQty";
            btnIncQty.Size = new Size(106, 25);
            btnIncQty.TabIndex = 202;
            btnIncQty.Text = "Increase Qty";
            btnIncQty.UseVisualStyleBackColor = false;
            btnIncQty.Click += BtnIncQty_ClickEventHandler;
            // 
            // btnDecQty
            // 
            btnDecQty.BackColor = Color.DodgerBlue;
            btnDecQty.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDecQty.Location = new Point(745, 107);
            btnDecQty.Name = "btnDecQty";
            btnDecQty.Size = new Size(106, 25);
            btnDecQty.TabIndex = 203;
            btnDecQty.Text = "Decrease Qty";
            btnDecQty.UseVisualStyleBackColor = false;
            btnDecQty.Click += BtnDecQty_ClickEventHandler;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.DodgerBlue;
            btnRefresh.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefresh.Location = new Point(593, 480);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 204;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_ClickEventHandler;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DodgerBlue;
            btnDelete.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(79, 107);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 205;
            btnDelete.Text = "Delete Item";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_ClickEventHandler;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(172, 109);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 206;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnEdit_ClickEventHandler;
            // 
            // FrmInventoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(1033, 516);
            Controls.Add(button1);
            Controls.Add(btnDelete);
            Controls.Add(btnRefresh);
            Controls.Add(btnDecQty);
            Controls.Add(btnIncQty);
            Controls.Add(gvInventoryList);
            Controls.Add(btnAddNewItem);
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
            Controls.Add(txtSearch);
            Controls.Add(lblListHeader);
            Controls.Add(btnSearch);
            Controls.Add(btnSort);
            Name = "FrmInventoryList";
            Text = "Inventory List";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gvInventoryList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSort;
        private Button btnSearch;
        private FileSystemWatcher fileSystemWatcher1;
        private Label lblListHeader;
        private TextBox txtSearch;
        private Button btnDecrease1;
        private Label lblQuantity1;
        private Label lblCost1;
        private Label lblMaterial1;
        private Label lblUnitSize1;
        private Label lblInventoryItemDescription1;
        private Label lblInventoryItemName1;
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
        private Button btnAddNewItem;
        private DataGridView gvInventoryList;
        private Button btnDecQty;
        private Button btnIncQty;
        private Button btnRefresh;
        private Button btnDelete;
        private Button button1;
        // private DataGridView gvInventory;
    }
}

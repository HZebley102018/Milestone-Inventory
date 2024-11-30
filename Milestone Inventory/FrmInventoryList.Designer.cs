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
            lblQuantity2 = new Label();
            lblCost2 = new Label();
            lblMaterial2 = new Label();
            lblUnitSize2 = new Label();
            lblInventoryItemDescription2 = new Label();
            lblInventoryItemName2 = new Label();
            btnDecrease2 = new Button();
            btnIncrease2 = new Button();
            btnEditInventory2 = new Button();
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
            btnEditInventory6 = new Button();
            btnIncrease6 = new Button();
            btnDecrease6 = new Button();
            lblQuantity6 = new Label();
            lblCost6 = new Label();
            lblMaterial6 = new Label();
            lblUnitSize6 = new Label();
            lblInventoryItemDescription6 = new Label();
            lblInventoryItemName6 = new Label();
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
            btnSearch.Location = new Point(702, 46);
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
            lblListHeader.Location = new Point(340, 9);
            lblListHeader.Name = "lblListHeader";
            lblListHeader.Size = new Size(133, 26);
            lblListHeader.TabIndex = 2;
            lblListHeader.Text = "Inventory List";
            lblListHeader.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(519, 46);
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
            lblInventoryItemDescription.Location = new Point(158, 98);
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
            lblUnitSize.Location = new Point(337, 98);
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
            lblMaterial.Location = new Point(422, 98);
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
            lblCost.Location = new Point(503, 98);
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
            lblQuantity.Location = new Point(589, 98);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(76, 21);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "Quantity";
            // 
            // lblQuantity2
            // 
            lblQuantity2.BackColor = Color.WhiteSmoke;
            lblQuantity2.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity2.Location = new Point(589, 129);
            lblQuantity2.Name = "lblQuantity2";
            lblQuantity2.Size = new Size(76, 21);
            lblQuantity2.TabIndex = 15;
            lblQuantity2.Text = "Quantity";
            // 
            // lblCost2
            // 
            lblCost2.BackColor = Color.WhiteSmoke;
            lblCost2.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost2.Location = new Point(503, 129);
            lblCost2.Name = "lblCost2";
            lblCost2.Size = new Size(43, 21);
            lblCost2.TabIndex = 14;
            lblCost2.Text = "Cost";
            // 
            // lblMaterial2
            // 
            lblMaterial2.BackColor = Color.WhiteSmoke;
            lblMaterial2.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial2.Location = new Point(422, 129);
            lblMaterial2.Name = "lblMaterial2";
            lblMaterial2.Size = new Size(75, 21);
            lblMaterial2.TabIndex = 13;
            lblMaterial2.Text = "Material";
            // 
            // lblUnitSize2
            // 
            lblUnitSize2.BackColor = Color.WhiteSmoke;
            lblUnitSize2.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize2.Location = new Point(337, 129);
            lblUnitSize2.Name = "lblUnitSize2";
            lblUnitSize2.Size = new Size(79, 21);
            lblUnitSize2.TabIndex = 12;
            lblUnitSize2.Text = "Unit Size";
            // 
            // lblInventoryItemDescription2
            // 
            lblInventoryItemDescription2.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription2.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription2.Location = new Point(158, 129);
            lblInventoryItemDescription2.Name = "lblInventoryItemDescription2";
            lblInventoryItemDescription2.Size = new Size(173, 21);
            lblInventoryItemDescription2.TabIndex = 11;
            lblInventoryItemDescription2.Text = "Inventory Description";
            // 
            // lblInventoryItemName2
            // 
            lblInventoryItemName2.AutoSize = true;
            lblInventoryItemName2.BackColor = Color.WhiteSmoke;
            lblInventoryItemName2.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName2.Location = new Point(21, 129);
            lblInventoryItemName2.Name = "lblInventoryItemName2";
            lblInventoryItemName2.Size = new Size(131, 21);
            lblInventoryItemName2.TabIndex = 10;
            lblInventoryItemName2.Text = "Inventory Name";
            // 
            // btnDecrease2
            // 
            btnDecrease2.Location = new Point(552, 130);
            btnDecrease2.Name = "btnDecrease2";
            btnDecrease2.Size = new Size(31, 21);
            btnDecrease2.TabIndex = 16;
            btnDecrease2.Text = "<";
            btnDecrease2.UseVisualStyleBackColor = true;
            btnDecrease2.Click += Quantity2DecreaseEventHandler;
            // 
            // btnIncrease2
            // 
            btnIncrease2.Location = new Point(671, 131);
            btnIncrease2.Name = "btnIncrease2";
            btnIncrease2.Size = new Size(31, 21);
            btnIncrease2.TabIndex = 17;
            btnIncrease2.Text = ">";
            btnIncrease2.UseVisualStyleBackColor = true;
            btnIncrease2.Click += Quantity2IncreaseEventHandler;
            // 
            // btnEditInventory2
            // 
            btnEditInventory2.Location = new Point(708, 130);
            btnEditInventory2.Name = "btnEditInventory2";
            btnEditInventory2.Size = new Size(75, 23);
            btnEditInventory2.TabIndex = 18;
            btnEditInventory2.Text = "Edit";
            btnEditInventory2.UseVisualStyleBackColor = true;
            // 
            // btnEditInventory3
            // 
            btnEditInventory3.Location = new Point(708, 161);
            btnEditInventory3.Name = "btnEditInventory3";
            btnEditInventory3.Size = new Size(75, 23);
            btnEditInventory3.TabIndex = 27;
            btnEditInventory3.Text = "Edit";
            btnEditInventory3.UseVisualStyleBackColor = true;
            // 
            // btnIncrease3
            // 
            btnIncrease3.Location = new Point(671, 162);
            btnIncrease3.Name = "btnIncrease3";
            btnIncrease3.Size = new Size(31, 21);
            btnIncrease3.TabIndex = 26;
            btnIncrease3.Text = ">";
            btnIncrease3.UseVisualStyleBackColor = true;
            btnIncrease3.Click += Quantity3IncreaseEventHandler;
            // 
            // btnDecrease3
            // 
            btnDecrease3.Location = new Point(552, 161);
            btnDecrease3.Name = "btnDecrease3";
            btnDecrease3.Size = new Size(31, 21);
            btnDecrease3.TabIndex = 25;
            btnDecrease3.Text = "<";
            btnDecrease3.UseVisualStyleBackColor = true;
            btnDecrease3.Click += Quantity3DecreaseEventHandler;
            // 
            // lblQuantity3
            // 
            lblQuantity3.BackColor = Color.WhiteSmoke;
            lblQuantity3.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity3.Location = new Point(589, 160);
            lblQuantity3.Name = "lblQuantity3";
            lblQuantity3.Size = new Size(76, 21);
            lblQuantity3.TabIndex = 24;
            lblQuantity3.Text = "Quantity";
            // 
            // lblCost3
            // 
            lblCost3.BackColor = Color.WhiteSmoke;
            lblCost3.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost3.Location = new Point(503, 160);
            lblCost3.Name = "lblCost3";
            lblCost3.Size = new Size(43, 21);
            lblCost3.TabIndex = 23;
            lblCost3.Text = "Cost";
            // 
            // lblMaterial3
            // 
            lblMaterial3.BackColor = Color.WhiteSmoke;
            lblMaterial3.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial3.Location = new Point(422, 160);
            lblMaterial3.Name = "lblMaterial3";
            lblMaterial3.Size = new Size(75, 21);
            lblMaterial3.TabIndex = 22;
            lblMaterial3.Text = "Material";
            // 
            // lblUnitSize3
            // 
            lblUnitSize3.BackColor = Color.WhiteSmoke;
            lblUnitSize3.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize3.Location = new Point(337, 160);
            lblUnitSize3.Name = "lblUnitSize3";
            lblUnitSize3.Size = new Size(79, 21);
            lblUnitSize3.TabIndex = 21;
            lblUnitSize3.Text = "Unit Size";
            // 
            // lblInventoryItemDescription3
            // 
            lblInventoryItemDescription3.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription3.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription3.Location = new Point(158, 160);
            lblInventoryItemDescription3.Name = "lblInventoryItemDescription3";
            lblInventoryItemDescription3.Size = new Size(173, 21);
            lblInventoryItemDescription3.TabIndex = 20;
            lblInventoryItemDescription3.Text = "Inventory Description";
            // 
            // lblInventoryItemName3
            // 
            lblInventoryItemName3.AutoSize = true;
            lblInventoryItemName3.BackColor = Color.WhiteSmoke;
            lblInventoryItemName3.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName3.Location = new Point(21, 160);
            lblInventoryItemName3.Name = "lblInventoryItemName3";
            lblInventoryItemName3.Size = new Size(131, 21);
            lblInventoryItemName3.TabIndex = 19;
            lblInventoryItemName3.Text = "Inventory Name";
            // 
            // btnEditInventory4
            // 
            btnEditInventory4.Location = new Point(708, 192);
            btnEditInventory4.Name = "btnEditInventory4";
            btnEditInventory4.Size = new Size(75, 23);
            btnEditInventory4.TabIndex = 36;
            btnEditInventory4.Text = "Edit";
            btnEditInventory4.UseVisualStyleBackColor = true;
            // 
            // btnIncrease4
            // 
            btnIncrease4.Location = new Point(671, 193);
            btnIncrease4.Name = "btnIncrease4";
            btnIncrease4.Size = new Size(31, 21);
            btnIncrease4.TabIndex = 35;
            btnIncrease4.Text = ">";
            btnIncrease4.UseVisualStyleBackColor = true;
            btnIncrease4.Click += Quantity4IncreaseEventHandler;
            // 
            // btnDecrease4
            // 
            btnDecrease4.Location = new Point(552, 192);
            btnDecrease4.Name = "btnDecrease4";
            btnDecrease4.Size = new Size(31, 21);
            btnDecrease4.TabIndex = 34;
            btnDecrease4.Text = "<";
            btnDecrease4.UseVisualStyleBackColor = true;
            btnDecrease4.Click += Quantity4DecreaseEventHandler;
            // 
            // lblQuantity4
            // 
            lblQuantity4.BackColor = Color.WhiteSmoke;
            lblQuantity4.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity4.Location = new Point(589, 191);
            lblQuantity4.Name = "lblQuantity4";
            lblQuantity4.Size = new Size(76, 21);
            lblQuantity4.TabIndex = 33;
            lblQuantity4.Text = "Quantity";
            // 
            // lblCost4
            // 
            lblCost4.BackColor = Color.WhiteSmoke;
            lblCost4.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost4.Location = new Point(503, 191);
            lblCost4.Name = "lblCost4";
            lblCost4.Size = new Size(43, 21);
            lblCost4.TabIndex = 32;
            lblCost4.Text = "Cost";
            // 
            // lblMaterial4
            // 
            lblMaterial4.BackColor = Color.WhiteSmoke;
            lblMaterial4.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial4.Location = new Point(422, 191);
            lblMaterial4.Name = "lblMaterial4";
            lblMaterial4.Size = new Size(75, 21);
            lblMaterial4.TabIndex = 31;
            lblMaterial4.Text = "Material";
            // 
            // lblUnitSize4
            // 
            lblUnitSize4.BackColor = Color.WhiteSmoke;
            lblUnitSize4.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize4.Location = new Point(337, 191);
            lblUnitSize4.Name = "lblUnitSize4";
            lblUnitSize4.Size = new Size(79, 21);
            lblUnitSize4.TabIndex = 30;
            lblUnitSize4.Text = "Unit Size";
            // 
            // lblInventoryItemDescription4
            // 
            lblInventoryItemDescription4.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription4.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription4.Location = new Point(158, 191);
            lblInventoryItemDescription4.Name = "lblInventoryItemDescription4";
            lblInventoryItemDescription4.Size = new Size(173, 21);
            lblInventoryItemDescription4.TabIndex = 29;
            lblInventoryItemDescription4.Text = "Inventory Description";
            // 
            // lblInventoryItemName4
            // 
            lblInventoryItemName4.AutoSize = true;
            lblInventoryItemName4.BackColor = Color.WhiteSmoke;
            lblInventoryItemName4.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName4.Location = new Point(21, 191);
            lblInventoryItemName4.Name = "lblInventoryItemName4";
            lblInventoryItemName4.Size = new Size(131, 21);
            lblInventoryItemName4.TabIndex = 28;
            lblInventoryItemName4.Text = "Inventory Name";
            // 
            // btnEditInventory5
            // 
            btnEditInventory5.Location = new Point(708, 222);
            btnEditInventory5.Name = "btnEditInventory5";
            btnEditInventory5.Size = new Size(75, 23);
            btnEditInventory5.TabIndex = 45;
            btnEditInventory5.Text = "Edit";
            btnEditInventory5.UseVisualStyleBackColor = true;
            // 
            // btnIncrease5
            // 
            btnIncrease5.Location = new Point(671, 223);
            btnIncrease5.Name = "btnIncrease5";
            btnIncrease5.Size = new Size(31, 21);
            btnIncrease5.TabIndex = 44;
            btnIncrease5.Text = ">";
            btnIncrease5.UseVisualStyleBackColor = true;
            btnIncrease5.Click += Quantity5IncreaseEventHandler;
            // 
            // btnDecrease5
            // 
            btnDecrease5.Location = new Point(552, 222);
            btnDecrease5.Name = "btnDecrease5";
            btnDecrease5.Size = new Size(31, 21);
            btnDecrease5.TabIndex = 43;
            btnDecrease5.Text = "<";
            btnDecrease5.UseVisualStyleBackColor = true;
            btnDecrease5.Click += Quantity5DecreaseEventHandler;
            // 
            // lblQuantity5
            // 
            lblQuantity5.BackColor = Color.WhiteSmoke;
            lblQuantity5.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity5.Location = new Point(589, 221);
            lblQuantity5.Name = "lblQuantity5";
            lblQuantity5.Size = new Size(76, 21);
            lblQuantity5.TabIndex = 42;
            lblQuantity5.Text = "Quantity";
            // 
            // lblCost5
            // 
            lblCost5.BackColor = Color.WhiteSmoke;
            lblCost5.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost5.Location = new Point(503, 221);
            lblCost5.Name = "lblCost5";
            lblCost5.Size = new Size(43, 21);
            lblCost5.TabIndex = 41;
            lblCost5.Text = "Cost";
            // 
            // lblMaterial5
            // 
            lblMaterial5.BackColor = Color.WhiteSmoke;
            lblMaterial5.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial5.Location = new Point(422, 221);
            lblMaterial5.Name = "lblMaterial5";
            lblMaterial5.Size = new Size(75, 21);
            lblMaterial5.TabIndex = 40;
            lblMaterial5.Text = "Material";
            // 
            // lblUnitSize5
            // 
            lblUnitSize5.BackColor = Color.WhiteSmoke;
            lblUnitSize5.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize5.Location = new Point(337, 221);
            lblUnitSize5.Name = "lblUnitSize5";
            lblUnitSize5.Size = new Size(79, 21);
            lblUnitSize5.TabIndex = 39;
            lblUnitSize5.Text = "Unit Size";
            // 
            // lblInventoryItemDescription5
            // 
            lblInventoryItemDescription5.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription5.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription5.Location = new Point(158, 221);
            lblInventoryItemDescription5.Name = "lblInventoryItemDescription5";
            lblInventoryItemDescription5.Size = new Size(173, 21);
            lblInventoryItemDescription5.TabIndex = 38;
            lblInventoryItemDescription5.Text = "Inventory Description";
            // 
            // lblInventoryItemName5
            // 
            lblInventoryItemName5.AutoSize = true;
            lblInventoryItemName5.BackColor = Color.WhiteSmoke;
            lblInventoryItemName5.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName5.Location = new Point(21, 221);
            lblInventoryItemName5.Name = "lblInventoryItemName5";
            lblInventoryItemName5.Size = new Size(131, 21);
            lblInventoryItemName5.TabIndex = 37;
            lblInventoryItemName5.Text = "Inventory Name";
            // 
            // btnEditInventory6
            // 
            btnEditInventory6.Location = new Point(708, 253);
            btnEditInventory6.Name = "btnEditInventory6";
            btnEditInventory6.Size = new Size(75, 23);
            btnEditInventory6.TabIndex = 54;
            btnEditInventory6.Text = "Edit";
            btnEditInventory6.UseVisualStyleBackColor = true;
            // 
            // btnIncrease6
            // 
            btnIncrease6.Location = new Point(671, 254);
            btnIncrease6.Name = "btnIncrease6";
            btnIncrease6.Size = new Size(31, 21);
            btnIncrease6.TabIndex = 53;
            btnIncrease6.Text = ">";
            btnIncrease6.UseVisualStyleBackColor = true;
            btnIncrease6.Click += Quantity6IncreaseEventHandler;
            // 
            // btnDecrease6
            // 
            btnDecrease6.Location = new Point(552, 253);
            btnDecrease6.Name = "btnDecrease6";
            btnDecrease6.Size = new Size(31, 21);
            btnDecrease6.TabIndex = 52;
            btnDecrease6.Text = "<";
            btnDecrease6.UseVisualStyleBackColor = true;
            btnDecrease6.Click += Quantity6DecreaseEventHandler;
            // 
            // lblQuantity6
            // 
            lblQuantity6.BackColor = Color.WhiteSmoke;
            lblQuantity6.Font = new Font("Franklin Gothic Medium", 12F);
            lblQuantity6.Location = new Point(589, 252);
            lblQuantity6.Name = "lblQuantity6";
            lblQuantity6.Size = new Size(76, 21);
            lblQuantity6.TabIndex = 51;
            lblQuantity6.Text = "Quantity";
            // 
            // lblCost6
            // 
            lblCost6.BackColor = Color.WhiteSmoke;
            lblCost6.Font = new Font("Franklin Gothic Medium", 12F);
            lblCost6.Location = new Point(503, 252);
            lblCost6.Name = "lblCost6";
            lblCost6.Size = new Size(43, 21);
            lblCost6.TabIndex = 50;
            lblCost6.Text = "Cost";
            // 
            // lblMaterial6
            // 
            lblMaterial6.BackColor = Color.WhiteSmoke;
            lblMaterial6.Font = new Font("Franklin Gothic Medium", 12F);
            lblMaterial6.Location = new Point(422, 252);
            lblMaterial6.Name = "lblMaterial6";
            lblMaterial6.Size = new Size(75, 21);
            lblMaterial6.TabIndex = 49;
            lblMaterial6.Text = "Material";
            // 
            // lblUnitSize6
            // 
            lblUnitSize6.BackColor = Color.WhiteSmoke;
            lblUnitSize6.Font = new Font("Franklin Gothic Medium", 12F);
            lblUnitSize6.Location = new Point(337, 252);
            lblUnitSize6.Name = "lblUnitSize6";
            lblUnitSize6.Size = new Size(79, 21);
            lblUnitSize6.TabIndex = 48;
            lblUnitSize6.Text = "Unit Size";
            // 
            // lblInventoryItemDescription6
            // 
            lblInventoryItemDescription6.BackColor = Color.WhiteSmoke;
            lblInventoryItemDescription6.Font = new Font("Franklin Gothic Medium", 12F);
            lblInventoryItemDescription6.Location = new Point(158, 252);
            lblInventoryItemDescription6.Name = "lblInventoryItemDescription6";
            lblInventoryItemDescription6.Size = new Size(173, 21);
            lblInventoryItemDescription6.TabIndex = 47;
            lblInventoryItemDescription6.Text = "Inventory Description";
            // 
            // lblInventoryItemName6
            // 
            lblInventoryItemName6.AutoSize = true;
            lblInventoryItemName6.BackColor = Color.WhiteSmoke;
            lblInventoryItemName6.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInventoryItemName6.Location = new Point(21, 252);
            lblInventoryItemName6.Name = "lblInventoryItemName6";
            lblInventoryItemName6.Size = new Size(131, 21);
            lblInventoryItemName6.TabIndex = 46;
            lblInventoryItemName6.Text = "Inventory Name";
            // 
            // FrmInventoryList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(838, 456);
            Controls.Add(btnEditInventory6);
            Controls.Add(btnIncrease6);
            Controls.Add(btnDecrease6);
            Controls.Add(lblQuantity6);
            Controls.Add(lblCost6);
            Controls.Add(lblMaterial6);
            Controls.Add(lblUnitSize6);
            Controls.Add(lblInventoryItemDescription6);
            Controls.Add(lblInventoryItemName6);
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
        private Button btnDecrease2;
        private Label lblQuantity2;
        private Label lblCost2;
        private Label lblMaterial2;
        private Label lblUnitSize2;
        private Label lblInventoryItemDescription2;
        private Label lblInventoryItemName2;
        private Label lblQuantity;
        private Label lblCost;
        private Label lblMaterial;
        private Button btnIncrease2;
        private Button btnEditInventory2;
        private Button btnEditInventory3;
        private Button btnIncrease3;
        private Button btnDecrease3;
        private Label lblQuantity3;
        private Label lblCost3;
        private Label lblMaterial3;
        private Label lblUnitSize3;
        private Label lblInventoryItemDescription3;
        private Label lblInventoryItemName3;
        private Button btnEditInventory6;
        private Button btnIncrease6;
        private Button btnDecrease6;
        private Label lblQuantity6;
        private Label lblCost6;
        private Label lblMaterial6;
        private Label lblUnitSize6;
        private Label lblInventoryItemDescription6;
        private Label lblInventoryItemName6;
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
    }
}

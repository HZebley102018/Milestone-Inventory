namespace Milestone_Inventory.PresentationLayer
{
    partial class FrmSearchResults
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
            gvSearchInventory = new DataGridView();
            btnClose = new Button();
            lblSearchResults = new Label();
            ((System.ComponentModel.ISupportInitialize)gvSearchInventory).BeginInit();
            SuspendLayout();
            // 
            // gvSearchInventory
            // 
            gvSearchInventory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gvSearchInventory.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            gvSearchInventory.BackgroundColor = Color.PowderBlue;
            gvSearchInventory.BorderStyle = BorderStyle.None;
            gvSearchInventory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gvSearchInventory.Location = new Point(74, 68);
            gvSearchInventory.Name = "gvSearchInventory";
            gvSearchInventory.Size = new Size(638, 183);
            gvSearchInventory.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.AutoSize = true;
            btnClose.BackColor = Color.DodgerBlue;
            btnClose.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(316, 270);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 27);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += BtnClose_ClickEventHandler;
            // 
            // lblSearchResults
            // 
            lblSearchResults.AutoSize = true;
            lblSearchResults.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchResults.Location = new Point(291, 22);
            lblSearchResults.Name = "lblSearchResults";
            lblSearchResults.Size = new Size(146, 24);
            lblSearchResults.TabIndex = 2;
            lblSearchResults.Text = "Search Results";
            // 
            // FrmSearchResults
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSearchResults);
            Controls.Add(btnClose);
            Controls.Add(gvSearchInventory);
            Name = "FrmSearchResults";
            Text = "FrmSearchResults";
            Load += FrmLoad_EventHandler;
            ((System.ComponentModel.ISupportInitialize)gvSearchInventory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView gvSearchInventory;
        private Button btnClose;
        private Label lblSearchResults;
    }
}
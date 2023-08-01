namespace KATINAT_COFFEE_SHOP
{
    partial class fTableManager
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
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            usersInformationToolStripMenuItem = new ToolStripMenuItem();
            informationToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            shippingSiteToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            lsvBill = new ListView();
            FoodId = new ColumnHeader();
            Name = new ColumnHeader();
            Quantity = new ColumnHeader();
            Price = new ColumnHeader();
            TotalPrice = new ColumnHeader();
            panel3 = new Panel();
            txbTotalBill = new TextBox();
            btnCheckOut = new Button();
            panel4 = new Panel();
            lblAvailableQuantity = new Label();
            nmFoodCount = new NumericUpDown();
            btnAddFood = new Button();
            cbxFood = new ComboBox();
            cbxCategory = new ComboBox();
            flpTable = new FlowLayoutPanel();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, usersInformationToolStripMenuItem, shippingSiteToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += adminToolStripMenuItem_Click;
            // 
            // usersInformationToolStripMenuItem
            // 
            usersInformationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informationToolStripMenuItem, logOutToolStripMenuItem });
            usersInformationToolStripMenuItem.Name = "usersInformationToolStripMenuItem";
            usersInformationToolStripMenuItem.Size = new Size(143, 24);
            usersInformationToolStripMenuItem.Text = "User's Information";
            // 
            // informationToolStripMenuItem
            // 
            informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            informationToolStripMenuItem.Size = new Size(224, 26);
            informationToolStripMenuItem.Text = "Information";
            informationToolStripMenuItem.Click += informationToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(224, 26);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // shippingSiteToolStripMenuItem
            // 
            shippingSiteToolStripMenuItem.Name = "shippingSiteToolStripMenuItem";
            shippingSiteToolStripMenuItem.Size = new Size(109, 24);
            shippingSiteToolStripMenuItem.Text = "Shipping site";
            shippingSiteToolStripMenuItem.Click += shippingSiteToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(lsvBill);
            panel2.Location = new Point(433, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(367, 251);
            panel2.TabIndex = 2;
            // 
            // lsvBill
            // 
            lsvBill.Columns.AddRange(new ColumnHeader[] { FoodId, Name, Quantity, Price, TotalPrice });
            lsvBill.GridLines = true;
            lsvBill.Location = new Point(3, 3);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(361, 264);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // FoodId
            // 
            FoodId.Text = "FoodId";
            // 
            // Name
            // 
            Name.Text = "Name";
            // 
            // Quantity
            // 
            Quantity.Text = "Quantity";
            // 
            // Price
            // 
            Price.Text = "Price";
            // 
            // TotalPrice
            // 
            TotalPrice.Text = "Total Price";
            // 
            // panel3
            // 
            panel3.Controls.Add(txbTotalBill);
            panel3.Controls.Add(btnCheckOut);
            panel3.Location = new Point(433, 385);
            panel3.Name = "panel3";
            panel3.Size = new Size(367, 71);
            panel3.TabIndex = 3;
            // 
            // txbTotalBill
            // 
            txbTotalBill.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txbTotalBill.Location = new Point(55, 12);
            txbTotalBill.Name = "txbTotalBill";
            txbTotalBill.ReadOnly = true;
            txbTotalBill.Size = new Size(208, 38);
            txbTotalBill.TabIndex = 7;
            // 
            // btnCheckOut
            // 
            btnCheckOut.Location = new Point(269, 3);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(95, 62);
            btnCheckOut.TabIndex = 4;
            btnCheckOut.Text = "Discharge";
            btnCheckOut.UseVisualStyleBackColor = true;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblAvailableQuantity);
            panel4.Controls.Add(nmFoodCount);
            panel4.Controls.Add(btnAddFood);
            panel4.Controls.Add(cbxFood);
            panel4.Controls.Add(cbxCategory);
            panel4.Location = new Point(433, 31);
            panel4.Name = "panel4";
            panel4.Size = new Size(364, 94);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // lblAvailableQuantity
            // 
            lblAvailableQuantity.AutoSize = true;
            lblAvailableQuantity.Location = new Point(3, 68);
            lblAvailableQuantity.Name = "lblAvailableQuantity";
            lblAvailableQuantity.Size = new Size(105, 20);
            lblAvailableQuantity.TabIndex = 4;
            lblAvailableQuantity.Text = "aaaaaaaaaaaa";
            // 
            // nmFoodCount
            // 
            nmFoodCount.Location = new Point(310, 22);
            nmFoodCount.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            nmFoodCount.Name = "nmFoodCount";
            nmFoodCount.Size = new Size(54, 27);
            nmFoodCount.TabIndex = 3;
            nmFoodCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(210, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(94, 62);
            btnAddFood.TabIndex = 2;
            btnAddFood.Text = "Add New";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // cbxFood
            // 
            cbxFood.FormattingEnabled = true;
            cbxFood.Location = new Point(3, 37);
            cbxFood.Name = "cbxFood";
            cbxFood.Size = new Size(201, 28);
            cbxFood.TabIndex = 1;
            cbxFood.SelectedIndexChanged += cbxFood_SelectedIndexChanged_1;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(0, 3);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(204, 28);
            cbxCategory.TabIndex = 0;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.Location = new Point(12, 31);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(415, 425);
            flpTable.TabIndex = 5;
            // 
            // fTableManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(flpTable);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "fTableManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TABLE MANAGER";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem usersInformationToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private Button btnCheckOut;
        private Panel panel4;
        private NumericUpDown nmFoodCount;
        private Button btnAddFood;
        private ComboBox cbxFood;
        private ComboBox cbxCategory;
        private FlowLayoutPanel flpTable;
        private ToolStripMenuItem informationToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ListView lsvBill;
        private ColumnHeader FoodId;
        private ColumnHeader Name;
        private ColumnHeader Quantity;
        private ColumnHeader Price;
        private ColumnHeader TotalPrice;
        private TextBox txbTotalBill;
        private Label lblAvailableQuantity;
        private ToolStripMenuItem shippingSiteToolStripMenuItem;
    }
}
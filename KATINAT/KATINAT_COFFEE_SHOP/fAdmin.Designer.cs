namespace KATINAT_COFFEE_SHOP
{
    partial class fAdmin
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
            tcAdmin = new TabControl();
            tpBill = new TabPage();
            panel2 = new Panel();
            btnViewBill = new Button();
            dtpToDate = new DateTimePicker();
            dtpFromDate = new DateTimePicker();
            panel1 = new Panel();
            dgvRevenue = new DataGridView();
            tpFood = new TabPage();
            panel6 = new Panel();
            panel21 = new Panel();
            nmQuantity = new NumericUpDown();
            label5 = new Label();
            panel10 = new Panel();
            nmFoodPrice = new NumericUpDown();
            label4 = new Label();
            panel9 = new Panel();
            cbxFoodCategory = new ComboBox();
            label3 = new Label();
            panel8 = new Panel();
            txbFoodName = new TextBox();
            label2 = new Label();
            panel7 = new Panel();
            txbId = new TextBox();
            label1 = new Label();
            panel5 = new Panel();
            txbSearchFood = new TextBox();
            btnSearchFood = new Button();
            panel4 = new Panel();
            btnViewFood = new Button();
            btnEditFood = new Button();
            btnDeleteFood = new Button();
            btnAddFood = new Button();
            panel3 = new Panel();
            dgvFood = new DataGridView();
            tpFoodCategory = new TabPage();
            panel11 = new Panel();
            panel14 = new Panel();
            txbCategoryName = new TextBox();
            label7 = new Label();
            panel15 = new Panel();
            txbCategoryID = new TextBox();
            label8 = new Label();
            panel17 = new Panel();
            btnViewCategory = new Button();
            btnEditCategory = new Button();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            panel18 = new Panel();
            dgvCategoy = new DataGridView();
            tpTable = new TabPage();
            panel12 = new Panel();
            panel16 = new Panel();
            cbxTableStatus = new ComboBox();
            label6 = new Label();
            panel19 = new Panel();
            txbTableName = new TextBox();
            label9 = new Label();
            panel20 = new Panel();
            txbTableID = new TextBox();
            label10 = new Label();
            panel22 = new Panel();
            btnViewTable = new Button();
            bnEditTable = new Button();
            btnDeleteTable = new Button();
            btnAddTable = new Button();
            panel23 = new Panel();
            dgvTable = new DataGridView();
            tpAccount = new TabPage();
            panel13 = new Panel();
            btnResetPassword = new Button();
            panel24 = new Panel();
            txbAccountType = new TextBox();
            cbxAccountType = new Label();
            panel25 = new Panel();
            txbAccountName = new TextBox();
            label12 = new Label();
            panel26 = new Panel();
            txbAccountUserName = new TextBox();
            label13 = new Label();
            panel28 = new Panel();
            btnViewAccount = new Button();
            btnEditAccount = new Button();
            btnDeleteAccount = new Button();
            btnAddAccount = new Button();
            panel29 = new Panel();
            dgvAccount = new DataGridView();
            tpShippingOrder = new TabPage();
            txbNote = new TextBox();
            label11 = new Label();
            panel27 = new Panel();
            nmFoodCount = new NumericUpDown();
            btnChangeQuantity = new Button();
            cbxFood = new ComboBox();
            cbxCategory = new ComboBox();
            btnSendRequest = new Button();
            txbOrderBy = new TextBox();
            OrderBy = new Label();
            dgvOrder = new DataGridView();
            tabPage1 = new TabPage();
            btnDeleteOrder = new Button();
            dgvShippingOrderList = new DataGridView();
            tcAdmin.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).BeginInit();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).BeginInit();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFood).BeginInit();
            tpFoodCategory.SuspendLayout();
            panel11.SuspendLayout();
            panel14.SuspendLayout();
            panel15.SuspendLayout();
            panel17.SuspendLayout();
            panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategoy).BeginInit();
            tpTable.SuspendLayout();
            panel12.SuspendLayout();
            panel16.SuspendLayout();
            panel19.SuspendLayout();
            panel20.SuspendLayout();
            panel22.SuspendLayout();
            panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTable).BeginInit();
            tpAccount.SuspendLayout();
            panel13.SuspendLayout();
            panel24.SuspendLayout();
            panel25.SuspendLayout();
            panel26.SuspendLayout();
            panel28.SuspendLayout();
            panel29.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAccount).BeginInit();
            tpShippingOrder.SuspendLayout();
            panel27.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShippingOrderList).BeginInit();
            SuspendLayout();
            // 
            // tcAdmin
            // 
            tcAdmin.Controls.Add(tpBill);
            tcAdmin.Controls.Add(tpFood);
            tcAdmin.Controls.Add(tpFoodCategory);
            tcAdmin.Controls.Add(tpTable);
            tcAdmin.Controls.Add(tpAccount);
            tcAdmin.Controls.Add(tpShippingOrder);
            tcAdmin.Controls.Add(tabPage1);
            tcAdmin.Location = new Point(12, 12);
            tcAdmin.Name = "tcAdmin";
            tcAdmin.SelectedIndex = 0;
            tcAdmin.Size = new Size(776, 426);
            tcAdmin.TabIndex = 0;
            tcAdmin.SelectedIndexChanged += tcAdmin_SelectedIndexChanged;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 29);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(768, 393);
            tpBill.TabIndex = 0;
            tpBill.Text = "Revenue";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnViewBill);
            panel2.Controls.Add(dtpToDate);
            panel2.Controls.Add(dtpFromDate);
            panel2.Location = new Point(6, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(756, 39);
            panel2.TabIndex = 1;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(344, 7);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(94, 29);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "View";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpToDate
            // 
            dtpToDate.Location = new Point(503, 9);
            dtpToDate.Name = "dtpToDate";
            dtpToDate.Size = new Size(250, 27);
            dtpToDate.TabIndex = 1;
            // 
            // dtpFromDate
            // 
            dtpFromDate.Location = new Point(3, 9);
            dtpFromDate.Name = "dtpFromDate";
            dtpFromDate.Size = new Size(250, 27);
            dtpFromDate.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvRevenue);
            panel1.Location = new Point(6, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(756, 336);
            panel1.TabIndex = 0;
            // 
            // dgvRevenue
            // 
            dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRevenue.Location = new Point(3, 3);
            dgvRevenue.Name = "dgvRevenue";
            dgvRevenue.RowHeadersWidth = 51;
            dgvRevenue.RowTemplate.Height = 29;
            dgvRevenue.Size = new Size(750, 343);
            dgvRevenue.TabIndex = 0;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 29);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(768, 393);
            tpFood.TabIndex = 1;
            tpFood.Text = "Drinks";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(panel21);
            panel6.Controls.Add(panel10);
            panel6.Controls.Add(panel9);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(365, 85);
            panel6.Name = "panel6";
            panel6.Size = new Size(397, 302);
            panel6.TabIndex = 3;
            // 
            // panel21
            // 
            panel21.Controls.Add(nmQuantity);
            panel21.Controls.Add(label5);
            panel21.Location = new Point(2, 195);
            panel21.Name = "panel21";
            panel21.Size = new Size(391, 42);
            panel21.TabIndex = 6;
            // 
            // nmQuantity
            // 
            nmQuantity.Location = new Point(109, 7);
            nmQuantity.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmQuantity.Name = "nmQuantity";
            nmQuantity.Size = new Size(269, 27);
            nmQuantity.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(28, 9);
            label5.Name = "label5";
            label5.Size = new Size(61, 20);
            label5.TabIndex = 0;
            label5.Text = "Quantity";
            // 
            // panel10
            // 
            panel10.Controls.Add(nmFoodPrice);
            panel10.Controls.Add(label4);
            panel10.Location = new Point(2, 147);
            panel10.Name = "panel10";
            panel10.Size = new Size(391, 42);
            panel10.TabIndex = 4;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(109, 7);
            nmFoodPrice.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(269, 27);
            nmFoodPrice.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(28, 9);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 0;
            label4.Text = "PRICE";
            // 
            // panel9
            // 
            panel9.Controls.Add(cbxFoodCategory);
            panel9.Controls.Add(label3);
            panel9.Location = new Point(2, 99);
            panel9.Name = "panel9";
            panel9.Size = new Size(391, 42);
            panel9.TabIndex = 3;
            // 
            // cbxFoodCategory
            // 
            cbxFoodCategory.FormattingEnabled = true;
            cbxFoodCategory.Location = new Point(109, 6);
            cbxFoodCategory.Name = "cbxFoodCategory";
            cbxFoodCategory.Size = new Size(268, 28);
            cbxFoodCategory.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 9);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 0;
            label3.Text = "CATEGORY";
            // 
            // panel8
            // 
            panel8.Controls.Add(txbFoodName);
            panel8.Controls.Add(label2);
            panel8.Location = new Point(2, 51);
            panel8.Name = "panel8";
            panel8.Size = new Size(391, 42);
            panel8.TabIndex = 2;
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(109, 6);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(268, 27);
            txbFoodName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 9);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 0;
            label2.Text = "NAME";
            // 
            // panel7
            // 
            panel7.Controls.Add(txbId);
            panel7.Controls.Add(label1);
            panel7.Location = new Point(3, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(391, 42);
            panel7.TabIndex = 1;
            // 
            // txbId
            // 
            txbId.Location = new Point(108, 6);
            txbId.Name = "txbId";
            txbId.ReadOnly = true;
            txbId.Size = new Size(269, 27);
            txbId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 9);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(txbSearchFood);
            panel5.Controls.Add(btnSearchFood);
            panel5.Location = new Point(365, 6);
            panel5.Name = "panel5";
            panel5.Size = new Size(397, 73);
            panel5.TabIndex = 2;
            // 
            // txbSearchFood
            // 
            txbSearchFood.Location = new Point(3, 23);
            txbSearchFood.Name = "txbSearchFood";
            txbSearchFood.Size = new Size(296, 27);
            txbSearchFood.TabIndex = 0;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(305, 3);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(76, 67);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Search";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnViewFood);
            panel4.Controls.Add(btnEditFood);
            panel4.Controls.Add(btnDeleteFood);
            panel4.Controls.Add(btnAddFood);
            panel4.Location = new Point(3, 6);
            panel4.Name = "panel4";
            panel4.Size = new Size(356, 73);
            panel4.TabIndex = 1;
            // 
            // btnViewFood
            // 
            btnViewFood.Location = new Point(258, 3);
            btnViewFood.Name = "btnViewFood";
            btnViewFood.Size = new Size(76, 67);
            btnViewFood.TabIndex = 3;
            btnViewFood.Text = "View";
            btnViewFood.UseVisualStyleBackColor = true;
            btnViewFood.Click += btnViewFood_Click;
            // 
            // btnEditFood
            // 
            btnEditFood.Location = new Point(177, 3);
            btnEditFood.Name = "btnEditFood";
            btnEditFood.Size = new Size(75, 67);
            btnEditFood.TabIndex = 2;
            btnEditFood.Text = "Update";
            btnEditFood.UseVisualStyleBackColor = true;
            btnEditFood.Click += btnEditFood_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(81, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(76, 67);
            btnDeleteFood.TabIndex = 1;
            btnDeleteFood.Text = "Delete";
            btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(72, 67);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Add";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(dgvFood);
            panel3.Location = new Point(3, 85);
            panel3.Name = "panel3";
            panel3.Size = new Size(356, 302);
            panel3.TabIndex = 0;
            // 
            // dgvFood
            // 
            dgvFood.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFood.Location = new Point(3, 4);
            dgvFood.Name = "dgvFood";
            dgvFood.RowHeadersWidth = 51;
            dgvFood.RowTemplate.Height = 29;
            dgvFood.Size = new Size(350, 295);
            dgvFood.TabIndex = 0;
            dgvFood.CellContentClick += dgvFood_CellContentClick;
            // 
            // tpFoodCategory
            // 
            tpFoodCategory.Controls.Add(panel11);
            tpFoodCategory.Controls.Add(panel17);
            tpFoodCategory.Controls.Add(panel18);
            tpFoodCategory.Location = new Point(4, 29);
            tpFoodCategory.Name = "tpFoodCategory";
            tpFoodCategory.Padding = new Padding(3);
            tpFoodCategory.Size = new Size(768, 393);
            tpFoodCategory.TabIndex = 2;
            tpFoodCategory.Text = "Category";
            tpFoodCategory.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel14);
            panel11.Controls.Add(panel15);
            panel11.Location = new Point(367, 85);
            panel11.Name = "panel11";
            panel11.Size = new Size(397, 302);
            panel11.TabIndex = 7;
            // 
            // panel14
            // 
            panel14.Controls.Add(txbCategoryName);
            panel14.Controls.Add(label7);
            panel14.Location = new Point(2, 51);
            panel14.Name = "panel14";
            panel14.Size = new Size(391, 42);
            panel14.TabIndex = 2;
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(109, 6);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(268, 27);
            txbCategoryName.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 9);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 0;
            label7.Text = "NAME";
            // 
            // panel15
            // 
            panel15.Controls.Add(txbCategoryID);
            panel15.Controls.Add(label8);
            panel15.Location = new Point(3, 3);
            panel15.Name = "panel15";
            panel15.Size = new Size(391, 42);
            panel15.TabIndex = 1;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(108, 6);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(269, 27);
            txbCategoryID.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 9);
            label8.Name = "label8";
            label8.Size = new Size(22, 20);
            label8.TabIndex = 0;
            label8.Text = "ID";
            // 
            // panel17
            // 
            panel17.Controls.Add(btnViewCategory);
            panel17.Controls.Add(btnEditCategory);
            panel17.Controls.Add(btnDeleteCategory);
            panel17.Controls.Add(btnAddCategory);
            panel17.Location = new Point(5, 6);
            panel17.Name = "panel17";
            panel17.Size = new Size(356, 73);
            panel17.TabIndex = 5;
            // 
            // btnViewCategory
            // 
            btnViewCategory.Location = new Point(258, 3);
            btnViewCategory.Name = "btnViewCategory";
            btnViewCategory.Size = new Size(76, 67);
            btnViewCategory.TabIndex = 3;
            btnViewCategory.Text = "View";
            btnViewCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(177, 3);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(75, 67);
            btnEditCategory.TabIndex = 2;
            btnEditCategory.Text = "Update";
            btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(81, 3);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(76, 67);
            btnDeleteCategory.TabIndex = 1;
            btnDeleteCategory.Text = "Delete";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(3, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(72, 67);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Add";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // panel18
            // 
            panel18.Controls.Add(dgvCategoy);
            panel18.Location = new Point(5, 85);
            panel18.Name = "panel18";
            panel18.Size = new Size(356, 302);
            panel18.TabIndex = 4;
            // 
            // dgvCategoy
            // 
            dgvCategoy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategoy.Location = new Point(3, 4);
            dgvCategoy.Name = "dgvCategoy";
            dgvCategoy.RowHeadersWidth = 51;
            dgvCategoy.RowTemplate.Height = 29;
            dgvCategoy.Size = new Size(350, 295);
            dgvCategoy.TabIndex = 0;
            dgvCategoy.CellClick += dgvCategoy_CellClick;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(panel12);
            tpTable.Controls.Add(panel22);
            tpTable.Controls.Add(panel23);
            tpTable.Location = new Point(4, 29);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(768, 393);
            tpTable.TabIndex = 3;
            tpTable.Text = "Table";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            panel12.Controls.Add(panel16);
            panel12.Controls.Add(panel19);
            panel12.Controls.Add(panel20);
            panel12.Location = new Point(367, 85);
            panel12.Name = "panel12";
            panel12.Size = new Size(397, 302);
            panel12.TabIndex = 7;
            // 
            // panel16
            // 
            panel16.Controls.Add(cbxTableStatus);
            panel16.Controls.Add(label6);
            panel16.Location = new Point(2, 99);
            panel16.Name = "panel16";
            panel16.Size = new Size(391, 42);
            panel16.TabIndex = 3;
            // 
            // cbxTableStatus
            // 
            cbxTableStatus.FormattingEnabled = true;
            cbxTableStatus.Location = new Point(109, 9);
            cbxTableStatus.Name = "cbxTableStatus";
            cbxTableStatus.Size = new Size(268, 28);
            cbxTableStatus.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(28, 9);
            label6.Name = "label6";
            label6.Size = new Size(59, 20);
            label6.TabIndex = 0;
            label6.Text = "STATUS";
            // 
            // panel19
            // 
            panel19.Controls.Add(txbTableName);
            panel19.Controls.Add(label9);
            panel19.Location = new Point(2, 51);
            panel19.Name = "panel19";
            panel19.Size = new Size(391, 42);
            panel19.TabIndex = 2;
            // 
            // txbTableName
            // 
            txbTableName.Location = new Point(109, 6);
            txbTableName.Name = "txbTableName";
            txbTableName.Size = new Size(268, 27);
            txbTableName.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(28, 9);
            label9.Name = "label9";
            label9.Size = new Size(46, 20);
            label9.TabIndex = 0;
            label9.Text = "NAME";
            // 
            // panel20
            // 
            panel20.Controls.Add(txbTableID);
            panel20.Controls.Add(label10);
            panel20.Location = new Point(3, 3);
            panel20.Name = "panel20";
            panel20.Size = new Size(391, 42);
            panel20.TabIndex = 1;
            // 
            // txbTableID
            // 
            txbTableID.Location = new Point(108, 6);
            txbTableID.Name = "txbTableID";
            txbTableID.ReadOnly = true;
            txbTableID.Size = new Size(269, 27);
            txbTableID.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(28, 9);
            label10.Name = "label10";
            label10.Size = new Size(22, 20);
            label10.TabIndex = 0;
            label10.Text = "ID";
            // 
            // panel22
            // 
            panel22.Controls.Add(btnViewTable);
            panel22.Controls.Add(bnEditTable);
            panel22.Controls.Add(btnDeleteTable);
            panel22.Controls.Add(btnAddTable);
            panel22.Location = new Point(5, 6);
            panel22.Name = "panel22";
            panel22.Size = new Size(356, 73);
            panel22.TabIndex = 5;
            // 
            // btnViewTable
            // 
            btnViewTable.Location = new Point(258, 3);
            btnViewTable.Name = "btnViewTable";
            btnViewTable.Size = new Size(76, 67);
            btnViewTable.TabIndex = 3;
            btnViewTable.Text = "View";
            btnViewTable.UseVisualStyleBackColor = true;
            // 
            // bnEditTable
            // 
            bnEditTable.Location = new Point(177, 3);
            bnEditTable.Name = "bnEditTable";
            bnEditTable.Size = new Size(75, 67);
            bnEditTable.TabIndex = 2;
            bnEditTable.Text = "Update";
            bnEditTable.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(81, 3);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(76, 67);
            btnDeleteTable.TabIndex = 1;
            btnDeleteTable.Text = "Delete";
            btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(3, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(72, 67);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Add";
            btnAddTable.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            panel23.Controls.Add(dgvTable);
            panel23.Location = new Point(5, 85);
            panel23.Name = "panel23";
            panel23.Size = new Size(356, 302);
            panel23.TabIndex = 4;
            // 
            // dgvTable
            // 
            dgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTable.Location = new Point(3, 4);
            dgvTable.Name = "dgvTable";
            dgvTable.RowHeadersWidth = 51;
            dgvTable.RowTemplate.Height = 29;
            dgvTable.Size = new Size(350, 295);
            dgvTable.TabIndex = 0;
            dgvTable.CellClick += dgvTable_CellClick;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(panel13);
            tpAccount.Controls.Add(panel28);
            tpAccount.Controls.Add(panel29);
            tpAccount.Location = new Point(4, 29);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(768, 393);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Account";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            panel13.Controls.Add(btnResetPassword);
            panel13.Controls.Add(panel24);
            panel13.Controls.Add(panel25);
            panel13.Controls.Add(panel26);
            panel13.Location = new Point(367, 85);
            panel13.Name = "panel13";
            panel13.Size = new Size(397, 302);
            panel13.TabIndex = 7;
            // 
            // btnResetPassword
            // 
            btnResetPassword.Location = new Point(264, 147);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(129, 67);
            btnResetPassword.TabIndex = 4;
            btnResetPassword.Text = "RESET PASSWORD";
            btnResetPassword.UseVisualStyleBackColor = true;
            // 
            // panel24
            // 
            panel24.Controls.Add(txbAccountType);
            panel24.Controls.Add(cbxAccountType);
            panel24.Location = new Point(2, 99);
            panel24.Name = "panel24";
            panel24.Size = new Size(391, 42);
            panel24.TabIndex = 3;
            // 
            // txbAccountType
            // 
            txbAccountType.Location = new Point(109, 6);
            txbAccountType.Name = "txbAccountType";
            txbAccountType.Size = new Size(268, 27);
            txbAccountType.TabIndex = 1;
            // 
            // cbxAccountType
            // 
            cbxAccountType.AutoSize = true;
            cbxAccountType.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cbxAccountType.Location = new Point(28, 9);
            cbxAccountType.Name = "cbxAccountType";
            cbxAccountType.Size = new Size(41, 20);
            cbxAccountType.TabIndex = 0;
            cbxAccountType.Text = "TYPE";
            // 
            // panel25
            // 
            panel25.Controls.Add(txbAccountName);
            panel25.Controls.Add(label12);
            panel25.Location = new Point(2, 51);
            panel25.Name = "panel25";
            panel25.Size = new Size(391, 42);
            panel25.TabIndex = 2;
            // 
            // txbAccountName
            // 
            txbAccountName.Location = new Point(109, 6);
            txbAccountName.Name = "txbAccountName";
            txbAccountName.ReadOnly = true;
            txbAccountName.Size = new Size(268, 27);
            txbAccountName.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(28, 9);
            label12.Name = "label12";
            label12.Size = new Size(46, 20);
            label12.TabIndex = 0;
            label12.Text = "NAME";
            // 
            // panel26
            // 
            panel26.Controls.Add(txbAccountUserName);
            panel26.Controls.Add(label13);
            panel26.Location = new Point(3, 3);
            panel26.Name = "panel26";
            panel26.Size = new Size(391, 42);
            panel26.TabIndex = 1;
            // 
            // txbAccountUserName
            // 
            txbAccountUserName.Location = new Point(108, 6);
            txbAccountUserName.Name = "txbAccountUserName";
            txbAccountUserName.ReadOnly = true;
            txbAccountUserName.Size = new Size(269, 27);
            txbAccountUserName.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(27, 13);
            label13.Name = "label13";
            label13.Size = new Size(80, 20);
            label13.TabIndex = 0;
            label13.Text = "USERNAME";
            // 
            // panel28
            // 
            panel28.Controls.Add(btnViewAccount);
            panel28.Controls.Add(btnEditAccount);
            panel28.Controls.Add(btnDeleteAccount);
            panel28.Controls.Add(btnAddAccount);
            panel28.Location = new Point(5, 6);
            panel28.Name = "panel28";
            panel28.Size = new Size(356, 73);
            panel28.TabIndex = 5;
            // 
            // btnViewAccount
            // 
            btnViewAccount.Location = new Point(258, 3);
            btnViewAccount.Name = "btnViewAccount";
            btnViewAccount.Size = new Size(76, 67);
            btnViewAccount.TabIndex = 3;
            btnViewAccount.Text = "View";
            btnViewAccount.UseVisualStyleBackColor = true;
            // 
            // btnEditAccount
            // 
            btnEditAccount.Location = new Point(177, 3);
            btnEditAccount.Name = "btnEditAccount";
            btnEditAccount.Size = new Size(75, 67);
            btnEditAccount.TabIndex = 2;
            btnEditAccount.Text = "Update";
            btnEditAccount.UseVisualStyleBackColor = true;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(81, 3);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(76, 67);
            btnDeleteAccount.TabIndex = 1;
            btnDeleteAccount.Text = "Delete";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(3, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(72, 67);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Add";
            btnAddAccount.UseVisualStyleBackColor = true;
            // 
            // panel29
            // 
            panel29.Controls.Add(dgvAccount);
            panel29.Location = new Point(5, 85);
            panel29.Name = "panel29";
            panel29.Size = new Size(356, 302);
            panel29.TabIndex = 4;
            // 
            // dgvAccount
            // 
            dgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAccount.Location = new Point(3, 4);
            dgvAccount.Name = "dgvAccount";
            dgvAccount.RowHeadersWidth = 51;
            dgvAccount.RowTemplate.Height = 29;
            dgvAccount.Size = new Size(350, 295);
            dgvAccount.TabIndex = 0;
            dgvAccount.CellContentClick += dgvAccount_CellContentClick;
            // 
            // tpShippingOrder
            // 
            tpShippingOrder.Controls.Add(txbNote);
            tpShippingOrder.Controls.Add(label11);
            tpShippingOrder.Controls.Add(panel27);
            tpShippingOrder.Controls.Add(btnSendRequest);
            tpShippingOrder.Controls.Add(txbOrderBy);
            tpShippingOrder.Controls.Add(OrderBy);
            tpShippingOrder.Controls.Add(dgvOrder);
            tpShippingOrder.Location = new Point(4, 29);
            tpShippingOrder.Name = "tpShippingOrder";
            tpShippingOrder.Padding = new Padding(3);
            tpShippingOrder.Size = new Size(768, 393);
            tpShippingOrder.TabIndex = 5;
            tpShippingOrder.Text = "Shipping Order";
            tpShippingOrder.UseVisualStyleBackColor = true;
            // 
            // txbNote
            // 
            txbNote.Location = new Point(383, 154);
            txbNote.Multiline = true;
            txbNote.Name = "txbNote";
            txbNote.Size = new Size(379, 148);
            txbNote.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(380, 123);
            label11.Name = "label11";
            label11.Size = new Size(74, 28);
            label11.TabIndex = 6;
            label11.Text = "*NOTE";
            // 
            // panel27
            // 
            panel27.Controls.Add(nmFoodCount);
            panel27.Controls.Add(btnChangeQuantity);
            panel27.Controls.Add(cbxFood);
            panel27.Controls.Add(cbxCategory);
            panel27.Location = new Point(380, 39);
            panel27.Name = "panel27";
            panel27.Size = new Size(382, 81);
            panel27.TabIndex = 5;
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
            // btnChangeQuantity
            // 
            btnChangeQuantity.Location = new Point(210, 3);
            btnChangeQuantity.Name = "btnChangeQuantity";
            btnChangeQuantity.Size = new Size(94, 62);
            btnChangeQuantity.TabIndex = 2;
            btnChangeQuantity.Text = "Change Quantity";
            btnChangeQuantity.UseVisualStyleBackColor = true;
            btnChangeQuantity.Click += btnChangeQuantity_Click;
            // 
            // cbxFood
            // 
            cbxFood.FormattingEnabled = true;
            cbxFood.Location = new Point(3, 37);
            cbxFood.Name = "cbxFood";
            cbxFood.Size = new Size(201, 28);
            cbxFood.TabIndex = 1;
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
            // btnSendRequest
            // 
            btnSendRequest.Location = new Point(380, 308);
            btnSendRequest.Name = "btnSendRequest";
            btnSendRequest.Size = new Size(382, 79);
            btnSendRequest.TabIndex = 3;
            btnSendRequest.Text = "Send Request";
            btnSendRequest.UseVisualStyleBackColor = true;
            btnSendRequest.Click += btnSendRequest_Click;
            // 
            // txbOrderBy
            // 
            txbOrderBy.Location = new Point(456, 6);
            txbOrderBy.Name = "txbOrderBy";
            txbOrderBy.ReadOnly = true;
            txbOrderBy.Size = new Size(306, 27);
            txbOrderBy.TabIndex = 2;
            // 
            // OrderBy
            // 
            OrderBy.AutoSize = true;
            OrderBy.Location = new Point(383, 9);
            OrderBy.Name = "OrderBy";
            OrderBy.Size = new Size(67, 20);
            OrderBy.TabIndex = 1;
            OrderBy.Text = "Order By";
            // 
            // dgvOrder
            // 
            dgvOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrder.Location = new Point(6, 6);
            dgvOrder.Name = "dgvOrder";
            dgvOrder.RowHeadersWidth = 51;
            dgvOrder.RowTemplate.Height = 29;
            dgvOrder.Size = new Size(368, 381);
            dgvOrder.TabIndex = 0;
            dgvOrder.CellContentClick += dgvOrder_CellContentClick;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnDeleteOrder);
            tabPage1.Controls.Add(dgvShippingOrderList);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 393);
            tabPage1.TabIndex = 6;
            tabPage1.Text = "Shipping Order List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(555, 6);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(94, 93);
            btnDeleteOrder.TabIndex = 2;
            btnDeleteOrder.Text = "Delete";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            // 
            // dgvShippingOrderList
            // 
            dgvShippingOrderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShippingOrderList.Location = new Point(6, 6);
            dgvShippingOrderList.Name = "dgvShippingOrderList";
            dgvShippingOrderList.RowHeadersWidth = 51;
            dgvShippingOrderList.RowTemplate.Height = 29;
            dgvShippingOrderList.Size = new Size(543, 381);
            dgvShippingOrderList.TabIndex = 1;
            dgvShippingOrderList.CellContentClick += dgvShippingOrderList_CellContentClick;
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tcAdmin);
            Name = "fAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            tcAdmin.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRevenue).EndInit();
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel21.ResumeLayout(false);
            panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmQuantity).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFood).EndInit();
            tpFoodCategory.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel17.ResumeLayout(false);
            panel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCategoy).EndInit();
            tpTable.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel16.PerformLayout();
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel20.ResumeLayout(false);
            panel20.PerformLayout();
            panel22.ResumeLayout(false);
            panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTable).EndInit();
            tpAccount.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel24.ResumeLayout(false);
            panel24.PerformLayout();
            panel25.ResumeLayout(false);
            panel25.PerformLayout();
            panel26.ResumeLayout(false);
            panel26.PerformLayout();
            panel28.ResumeLayout(false);
            panel29.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAccount).EndInit();
            tpShippingOrder.ResumeLayout(false);
            tpShippingOrder.PerformLayout();
            panel27.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nmFoodCount).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrder).EndInit();
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvShippingOrderList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcAdmin;
        private TabPage tpBill;
        private TabPage tpFood;
        private Panel panel2;
        private Button btnViewBill;
        private DateTimePicker dtpToDate;
        private DateTimePicker dtpFromDate;
        private Panel panel1;
        private DataGridView dgvRevenue;
        private Panel panel6;
        private Panel panel5;
        private TextBox txbSearchFood;
        private Button btnSearchFood;
        private Panel panel4;
        private Button btnViewFood;
        private Button btnEditFood;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Panel panel3;
        private DataGridView dgvFood;
        private TabPage tpFoodCategory;
        private TabPage tpTable;
        private TabPage tpAccount;
        private Panel panel7;
        private TextBox txbId;
        private Label label1;
        private Panel panel10;
        private NumericUpDown nmFoodPrice;
        private Label label4;
        private Panel panel9;
        private Label label3;
        private Panel panel8;
        private TextBox txbFoodName;
        private Label label2;
        private Panel panel11;
        private Panel panel14;
        private TextBox txbCategoryName;
        private Label label7;
        private Panel panel15;
        private TextBox txbCategoryID;
        private Label label8;
        private Panel panel17;
        private Button btnViewCategory;
        private Button btnEditCategory;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Panel panel18;
        private DataGridView dgvCategoy;
        private Panel panel12;
        private Panel panel16;
        private ComboBox cbxTableStatus;
        private Label label6;
        private Panel panel19;
        private TextBox txbTableName;
        private Label label9;
        private Panel panel20;
        private TextBox txbTableID;
        private Label label10;
        private Panel panel22;
        private Button btnViewTable;
        private Button bnEditTable;
        private Button btnDeleteTable;
        private Button btnAddTable;
        private Panel panel23;
        private DataGridView dgvTable;
        private Panel panel13;
        private Button btnResetPassword;
        private Panel panel24;
        private TextBox txbAccountType;
        private Label cbxAccountType;
        private Panel panel25;
        private TextBox txbAccountName;
        private Label label12;
        private Panel panel26;
        private TextBox txbAccountUserName;
        private Label label13;
        private Panel panel28;
        private Button btnViewAccount;
        private Button btnEditAccount;
        private Button btnDeleteAccount;
        private Button btnAddAccount;
        private Panel panel29;
        private DataGridView dgvAccount;
        private ComboBox cbxFoodCategory;
        private Panel panel21;
        private NumericUpDown nmQuantity;
        private Label label5;
        private TabPage tpShippingOrder;
        private TextBox txbOrderBy;
        private Label OrderBy;
        private DataGridView dgvOrder;
        private Button btnSendRequest;
        private Panel panel27;
        private NumericUpDown nmFoodCount;
        private Button btnChangeQuantity;
        private ComboBox cbxFood;
        private ComboBox cbxCategory;
        private TextBox txbNote;
        private Label label11;
        private TabPage tabPage1;
        private Button btnDeleteOrder;
        private DataGridView dgvShippingOrderList;
    }
}
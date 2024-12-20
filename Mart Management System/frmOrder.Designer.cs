namespace Mart_Management_System
{
    partial class frmOrder
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
            this.components = new System.ComponentModel.Container();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbProductsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.martManagementSystemDataSet5 = new Mart_Management_System.MartManagementSystemDataSet5();
            this.tbProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martManagementSystemDataSet1 = new Mart_Management_System.MartManagementSystemDataSet1();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lblChange1 = new System.Windows.Forms.Label();
            this.lblTotalPrice1 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.prodidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martManagementSystemDataSet2 = new Mart_Management_System.MartManagementSystemDataSet2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboproduct = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbocategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductsTableAdapter = new Mart_Management_System.MartManagementSystemDataSet1TableAdapters.tbProductsTableAdapter();
            this.tbOrdersTableAdapter = new Mart_Management_System.MartManagementSystemDataSet2TableAdapters.tbOrdersTableAdapter();
            this.tbProductsTableAdapter1 = new Mart_Management_System.MartManagementSystemDataSet5TableAdapters.tbProductsTableAdapter();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagepathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateinsertDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.lblOrder);
            this.panel5.Location = new System.Drawing.Point(-4, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1750, 129);
            this.panel5.TabIndex = 6;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.ForeColor = System.Drawing.Color.Black;
            this.lblOrder.Location = new System.Drawing.Point(756, 35);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(136, 57);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "Order";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(24, 162);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 477);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.imagepathDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateinsertDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbProductsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(34, 27);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(892, 421);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbProductsBindingSource1
            // 
            this.tbProductsBindingSource1.DataMember = "tbProducts";
            this.tbProductsBindingSource1.DataSource = this.martManagementSystemDataSet5;
            // 
            // martManagementSystemDataSet5
            // 
            this.martManagementSystemDataSet5.DataSetName = "MartManagementSystemDataSet5";
            this.martManagementSystemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbProductsBindingSource
            // 
            this.tbProductsBindingSource.DataMember = "tbProducts";
            this.tbProductsBindingSource.DataSource = this.martManagementSystemDataSet1;
            // 
            // martManagementSystemDataSet1
            // 
            this.martManagementSystemDataSet1.DataSetName = "MartManagementSystemDataSet1";
            this.martManagementSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel10.Controls.Add(this.lblChange1);
            this.panel10.Controls.Add(this.lblTotalPrice1);
            this.panel10.Controls.Add(this.lblChange);
            this.panel10.Controls.Add(this.txtAmount);
            this.panel10.Controls.Add(this.label12);
            this.panel10.Controls.Add(this.label11);
            this.panel10.Controls.Add(this.lblTotalPrice);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.btnReceipt);
            this.panel10.Controls.Add(this.btnPayment);
            this.panel10.Controls.Add(this.dataGridViewOrder);
            this.panel10.Location = new System.Drawing.Point(1012, 162);
            this.panel10.Margin = new System.Windows.Forms.Padding(6);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(712, 1102);
            this.panel10.TabIndex = 8;
            // 
            // lblChange1
            // 
            this.lblChange1.AutoSize = true;
            this.lblChange1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChange1.Location = new System.Drawing.Point(272, 756);
            this.lblChange1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblChange1.Name = "lblChange1";
            this.lblChange1.Size = new System.Drawing.Size(27, 36);
            this.lblChange1.TabIndex = 27;
            this.lblChange1.Text = "..";
            // 
            // lblTotalPrice1
            // 
            this.lblTotalPrice1.AutoSize = true;
            this.lblTotalPrice1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPrice1.Location = new System.Drawing.Point(260, 560);
            this.lblTotalPrice1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPrice1.Name = "lblTotalPrice1";
            this.lblTotalPrice1.Size = new System.Drawing.Size(27, 36);
            this.lblTotalPrice1.TabIndex = 19;
            this.lblTotalPrice1.Text = "..";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChange.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblChange.Location = new System.Drawing.Point(260, 762);
            this.lblChange.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(0, 36);
            this.lblChange.TabIndex = 26;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(266, 653);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(6);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(270, 43);
            this.txtAmount.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(98, 762);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 36);
            this.label12.TabIndex = 24;
            this.label12.Text = "Change : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.RoyalBlue;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(96, 662);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 36);
            this.label11.TabIndex = 23;
            this.label11.Text = "Amount : ";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPrice.Location = new System.Drawing.Point(260, 560);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 36);
            this.lblTotalPrice.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(68, 560);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 36);
            this.label9.TabIndex = 21;
            this.label9.Text = "Total Price : ";
            // 
            // btnReceipt
            // 
            this.btnReceipt.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReceipt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReceipt.ForeColor = System.Drawing.Color.Transparent;
            this.btnReceipt.Location = new System.Drawing.Point(128, 985);
            this.btnReceipt.Margin = new System.Windows.Forms.Padding(6);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(500, 73);
            this.btnReceipt.TabIndex = 20;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = false;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPayment.ForeColor = System.Drawing.Color.Transparent;
            this.btnPayment.Location = new System.Drawing.Point(128, 877);
            this.btnPayment.Margin = new System.Windows.Forms.Padding(6);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(500, 73);
            this.btnPayment.TabIndex = 19;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.AutoGenerateColumns = false;
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn1,
            this.prodnameDataGridViewTextBoxColumn1,
            this.categoryDataGridViewTextBoxColumn1,
            this.qtyDataGridViewTextBoxColumn,
            this.origpriceDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn});
            this.dataGridViewOrder.DataSource = this.tbOrdersBindingSource;
            this.dataGridViewOrder.Location = new System.Drawing.Point(34, 27);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 82;
            this.dataGridViewOrder.Size = new System.Drawing.Size(656, 421);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // prodidDataGridViewTextBoxColumn1
            // 
            this.prodidDataGridViewTextBoxColumn1.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn1.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.prodidDataGridViewTextBoxColumn1.Name = "prodidDataGridViewTextBoxColumn1";
            this.prodidDataGridViewTextBoxColumn1.Width = 200;
            // 
            // prodnameDataGridViewTextBoxColumn1
            // 
            this.prodnameDataGridViewTextBoxColumn1.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn1.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.prodnameDataGridViewTextBoxColumn1.Name = "prodnameDataGridViewTextBoxColumn1";
            this.prodnameDataGridViewTextBoxColumn1.Width = 200;
            // 
            // categoryDataGridViewTextBoxColumn1
            // 
            this.categoryDataGridViewTextBoxColumn1.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn1.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn1.MinimumWidth = 10;
            this.categoryDataGridViewTextBoxColumn1.Name = "categoryDataGridViewTextBoxColumn1";
            this.categoryDataGridViewTextBoxColumn1.Width = 200;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            this.qtyDataGridViewTextBoxColumn.DataPropertyName = "qty";
            this.qtyDataGridViewTextBoxColumn.HeaderText = "qty";
            this.qtyDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            this.qtyDataGridViewTextBoxColumn.Width = 200;
            // 
            // origpriceDataGridViewTextBoxColumn
            // 
            this.origpriceDataGridViewTextBoxColumn.DataPropertyName = "orig_price";
            this.origpriceDataGridViewTextBoxColumn.HeaderText = "orig_price";
            this.origpriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.origpriceDataGridViewTextBoxColumn.Name = "origpriceDataGridViewTextBoxColumn";
            this.origpriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // totalpriceDataGridViewTextBoxColumn
            // 
            this.totalpriceDataGridViewTextBoxColumn.DataPropertyName = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.HeaderText = "total_price";
            this.totalpriceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.totalpriceDataGridViewTextBoxColumn.Name = "totalpriceDataGridViewTextBoxColumn";
            this.totalpriceDataGridViewTextBoxColumn.Width = 200;
            // 
            // orderdateDataGridViewTextBoxColumn
            // 
            this.orderdateDataGridViewTextBoxColumn.DataPropertyName = "order_date";
            this.orderdateDataGridViewTextBoxColumn.HeaderText = "order_date";
            this.orderdateDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.orderdateDataGridViewTextBoxColumn.Name = "orderdateDataGridViewTextBoxColumn";
            this.orderdateDataGridViewTextBoxColumn.Width = 200;
            // 
            // tbOrdersBindingSource
            // 
            this.tbOrdersBindingSource.DataMember = "tbOrders";
            this.tbOrdersBindingSource.DataSource = this.martManagementSystemDataSet2;
            // 
            // martManagementSystemDataSet2
            // 
            this.martManagementSystemDataSet2.DataSetName = "MartManagementSystemDataSet2";
            this.martManagementSystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.lblPrice);
            this.panel3.Controls.Add(this.lblProductName);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cboproduct);
            this.panel3.Controls.Add(this.numericUpDown1);
            this.panel3.Controls.Add(this.cbocategory);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(24, 669);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 594);
            this.panel3.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(718, 477);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(208, 73);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemove.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemove.Location = new System.Drawing.Point(326, 477);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(208, 73);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(74, 477);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(208, 73);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(522, 262);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 36);
            this.label8.TabIndex = 15;
            this.label8.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(210, 369);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(0, 36);
            this.lblPrice.TabIndex = 14;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(210, 254);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(0, 36);
            this.lblProductName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Product ID: ";
            // 
            // cboproduct
            // 
            this.cboproduct.FormattingEnabled = true;
            this.cboproduct.Location = new System.Drawing.Point(686, 133);
            this.cboproduct.Margin = new System.Windows.Forms.Padding(6);
            this.cboproduct.Name = "cboproduct";
            this.cboproduct.Size = new System.Drawing.Size(238, 33);
            this.cboproduct.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(686, 256);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(6);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(240, 31);
            this.numericUpDown1.TabIndex = 7;
            // 
            // cbocategory
            // 
            this.cbocategory.FormattingEnabled = true;
            this.cbocategory.Location = new System.Drawing.Point(216, 136);
            this.cbocategory.Margin = new System.Windows.Forms.Padding(6);
            this.cbocategory.Name = "cbocategory";
            this.cbocategory.Size = new System.Drawing.Size(238, 33);
            this.cbocategory.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Let\'s Order";
            // 
            // tbProductsTableAdapter
            // 
            this.tbProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tbOrdersTableAdapter
            // 
            this.tbOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // tbProductsTableAdapter1
            // 
            this.tbProductsTableAdapter1.ClearBeforeFill = true;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.Width = 200;
            // 
            // prodnameDataGridViewTextBoxColumn
            // 
            this.prodnameDataGridViewTextBoxColumn.DataPropertyName = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.HeaderText = "prod_name";
            this.prodnameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.prodnameDataGridViewTextBoxColumn.Name = "prodnameDataGridViewTextBoxColumn";
            this.prodnameDataGridViewTextBoxColumn.Width = 200;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.Width = 200;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "stock";
            this.stockDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.Width = 200;
            // 
            // imagepathDataGridViewTextBoxColumn
            // 
            this.imagepathDataGridViewTextBoxColumn.DataPropertyName = "image_path";
            this.imagepathDataGridViewTextBoxColumn.HeaderText = "image_path";
            this.imagepathDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.imagepathDataGridViewTextBoxColumn.Name = "imagepathDataGridViewTextBoxColumn";
            this.imagepathDataGridViewTextBoxColumn.Width = 200;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.Width = 200;
            // 
            // dateinsertDataGridViewTextBoxColumn
            // 
            this.dateinsertDataGridViewTextBoxColumn.DataPropertyName = "date_insert";
            this.dateinsertDataGridViewTextBoxColumn.HeaderText = "date_insert";
            this.dateinsertDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dateinsertDataGridViewTextBoxColumn.Name = "dateinsertDataGridViewTextBoxColumn";
            this.dateinsertDataGridViewTextBoxColumn.Width = 200;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1745, 1315);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboproduct;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.ComboBox cbocategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChange;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private MartManagementSystemDataSet1 martManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource tbProductsBindingSource;
        private MartManagementSystemDataSet1TableAdapters.tbProductsTableAdapter tbProductsTableAdapter;
        private MartManagementSystemDataSet2 martManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource tbOrdersBindingSource;
        private MartManagementSystemDataSet2TableAdapters.tbOrdersTableAdapter tbOrdersTableAdapter;
        private System.Windows.Forms.Label lblTotalPrice1;
        private System.Windows.Forms.Label lblChange1;
        private MartManagementSystemDataSet5 martManagementSystemDataSet5;
        private System.Windows.Forms.BindingSource tbProductsBindingSource1;
        private MartManagementSystemDataSet5TableAdapters.tbProductsTableAdapter tbProductsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagepathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateinsertDataGridViewTextBoxColumn;
    }
}
namespace Mart_Management_System
{
    partial class frmProduct
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
            this.lblProduct = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.tbProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martManagementSystemDataSet1 = new Mart_Management_System.MartManagementSystemDataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.tbCategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martManagementSystemDataSet = new Mart_Management_System.MartManagementSystemDataSet();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtProdId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProductsTableAdapter = new Mart_Management_System.MartManagementSystemDataSet1TableAdapters.tbProductsTableAdapter();
            this.tbCategoriesTableAdapter = new Mart_Management_System.MartManagementSystemDataSetTableAdapters.tbCategoriesTableAdapter();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.lblProduct);
            this.panel5.Location = new System.Drawing.Point(-2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1750, 125);
            this.panel5.TabIndex = 5;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(756, 35);
            this.lblProduct.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(176, 57);
            this.lblProduct.TabIndex = 2;
            this.lblProduct.Text = "Product";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.dataGridViewProducts);
            this.panel1.Location = new System.Drawing.Point(24, 156);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1700, 477);
            this.panel1.TabIndex = 6;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoGenerateColumns = false;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn,
            this.imagepathDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.dateinsertDataGridViewTextBoxColumn});
            this.dataGridViewProducts.DataSource = this.tbProductsBindingSource;
            this.dataGridViewProducts.Location = new System.Drawing.Point(34, 27);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersWidth = 82;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1634, 421);
            this.dataGridViewProducts.TabIndex = 0;
            this.dataGridViewProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellClick);
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProducts_CellContentClick);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.cboStatus);
            this.panel3.Controls.Add(this.cboCategory);
            this.panel3.Controls.Add(this.pictureBox);
            this.panel3.Controls.Add(this.btnBrowse);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtStock);
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.txtProdName);
            this.panel3.Controls.Add(this.btnClear);
            this.panel3.Controls.Add(this.btnRemove);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.txtProdId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(24, 665);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1700, 629);
            this.panel3.TabIndex = 12;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cboStatus.Location = new System.Drawing.Point(874, 348);
            this.cboStatus.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(312, 33);
            this.cboStatus.TabIndex = 25;
            // 
            // cboCategory
            // 
            this.cboCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tbCategoriesBindingSource, "category", true));
            this.cboCategory.DataSource = this.tbCategoriesBindingSource;
            this.cboCategory.DisplayMember = "category";
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(242, 348);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(312, 33);
            this.cboCategory.TabIndex = 24;
            this.cboCategory.ValueMember = "category";
            // 
            // tbCategoriesBindingSource
            // 
            this.tbCategoriesBindingSource.DataMember = "tbCategories";
            this.tbCategoriesBindingSource.DataSource = this.martManagementSystemDataSet;
            // 
            // martManagementSystemDataSet
            // 
            this.martManagementSystemDataSet.DataSetName = "MartManagementSystemDataSet";
            this.martManagementSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(1376, 88);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(232, 244);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 23;
            this.pictureBox.TabStop = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBrowse.ForeColor = System.Drawing.Color.Transparent;
            this.btnBrowse.Location = new System.Drawing.Point(1376, 344);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(232, 58);
            this.btnBrowse.TabIndex = 22;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(706, 344);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 41);
            this.label7.TabIndex = 21;
            this.label7.Text = "Status : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(714, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 41);
            this.label6.TabIndex = 20;
            this.label6.Text = "Stock : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(730, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 41);
            this.label5.TabIndex = 19;
            this.label5.Text = "Price :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(80, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 41);
            this.label4.TabIndex = 18;
            this.label4.Text = "Category : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(10, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 41);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product Name : ";
            // 
            // txtStock
            // 
            this.txtStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStock.Location = new System.Drawing.Point(874, 206);
            this.txtStock.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtStock.Multiline = true;
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(312, 52);
            this.txtStock.TabIndex = 15;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(874, 90);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(312, 50);
            this.txtPrice.TabIndex = 14;
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(242, 206);
            this.txtProdName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProdName.Multiline = true;
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(312, 52);
            this.txtProdName.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(1162, 492);
            this.btnClear.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(288, 87);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnRemove.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemove.Location = new System.Drawing.Point(818, 492);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(288, 87);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Location = new System.Drawing.Point(456, 492);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(288, 87);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.Location = new System.Drawing.Point(122, 492);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(288, 87);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtProdId
            // 
            this.txtProdId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdId.Location = new System.Drawing.Point(242, 90);
            this.txtProdId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProdId.Multiline = true;
            this.txtProdId.Name = "txtProdId";
            this.txtProdId.Size = new System.Drawing.Size(312, 52);
            this.txtProdId.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 41);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product ID: ";
            // 
            // tbProductsTableAdapter
            // 
            this.tbProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tbCategoriesTableAdapter
            // 
            this.tbCategoriesTableAdapter.ClearBeforeFill = true;
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
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1748, 1317);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load_1);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtProdId;
        private System.Windows.Forms.Label label2;
        private MartManagementSystemDataSet1 martManagementSystemDataSet1;
        private System.Windows.Forms.BindingSource tbProductsBindingSource;
        private MartManagementSystemDataSet1TableAdapters.tbProductsTableAdapter tbProductsTableAdapter;
        private MartManagementSystemDataSet martManagementSystemDataSet;
        private System.Windows.Forms.BindingSource tbCategoriesBindingSource;
        private MartManagementSystemDataSetTableAdapters.tbCategoriesTableAdapter tbCategoriesTableAdapter;
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
namespace Mart_Management_System
{
    partial class frmDashBoard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTodayIncome = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblDasboard = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbOrdersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.martManagementSystemDataSet2 = new Mart_Management_System.MartManagementSystemDataSet2();
            this.label9 = new System.Windows.Forms.Label();
            this.tbOrdersTableAdapter = new Mart_Management_System.MartManagementSystemDataSet2TableAdapters.tbOrdersTableAdapter();
            this.martManagementSystemDataSet6 = new Mart_Management_System.MartManagementSystemDataSet6();
            this.tbOrderHistoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbOrderHistoryTableAdapter = new Mart_Management_System.MartManagementSystemDataSet6TableAdapters.tbOrderHistoryTableAdapter();
            this.prodidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.origpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrderHistoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.lblTotalUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(72, 152);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 227);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalUser
            // 
            this.lblTotalUser.AutoSize = true;
            this.lblTotalUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalUser.Location = new System.Drawing.Point(168, 129);
            this.lblTotalUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalUser.Name = "lblTotalUser";
            this.lblTotalUser.Size = new System.Drawing.Size(70, 25);
            this.lblTotalUser.TabIndex = 2;
            this.lblTotalUser.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(168, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mart_Management_System.Properties.Resources.icons8_user_100;
            this.pictureBox1.Location = new System.Drawing.Point(24, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.Controls.Add(this.lblOrder);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(637, 152);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(465, 227);
            this.panel2.TabIndex = 3;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOrder.Location = new System.Drawing.Point(168, 129);
            this.lblOrder.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(70, 25);
            this.lblOrder.TabIndex = 2;
            this.lblOrder.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(168, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 50);
            this.label4.TabIndex = 1;
            this.label4.Text = "Order";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Mart_Management_System.Properties.Resources.icons8_customer_100;
            this.pictureBox2.Location = new System.Drawing.Point(24, 25);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Controls.Add(this.lblTodayIncome);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(1223, 152);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(459, 227);
            this.panel3.TabIndex = 3;
            // 
            // lblTodayIncome
            // 
            this.lblTodayIncome.AutoSize = true;
            this.lblTodayIncome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTodayIncome.Location = new System.Drawing.Point(168, 129);
            this.lblTodayIncome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTodayIncome.Name = "lblTodayIncome";
            this.lblTodayIncome.Size = new System.Drawing.Size(70, 25);
            this.lblTodayIncome.TabIndex = 2;
            this.lblTodayIncome.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(168, 25);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label6.Size = new System.Drawing.Size(162, 50);
            this.label6.TabIndex = 1;
            this.label6.Text = "Income";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Mart_Management_System.Properties.Resources.cash;
            this.pictureBox3.Location = new System.Drawing.Point(24, 25);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 129);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Control;
            this.panel5.Controls.Add(this.lblDasboard);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1750, 125);
            this.panel5.TabIndex = 4;
            // 
            // lblDasboard
            // 
            this.lblDasboard.AutoSize = true;
            this.lblDasboard.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDasboard.ForeColor = System.Drawing.Color.Black;
            this.lblDasboard.Location = new System.Drawing.Point(756, 35);
            this.lblDasboard.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDasboard.Name = "lblDasboard";
            this.lblDasboard.Size = new System.Drawing.Size(232, 57);
            this.lblDasboard.TabIndex = 2;
            this.lblDasboard.Text = "DashBoard";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel6.Controls.Add(this.dataGridView1);
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(96, 483);
            this.panel6.Margin = new System.Windows.Forms.Padding(6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1574, 702);
            this.panel6.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.prodidDataGridViewTextBoxColumn,
            this.prodnameDataGridViewTextBoxColumn,
            this.qtyDataGridViewTextBoxColumn,
            this.origpriceDataGridViewTextBoxColumn,
            this.totalpriceDataGridViewTextBoxColumn,
            this.orderdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbOrderHistoryBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(42, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(1498, 629);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(64, 437);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 45);
            this.label9.TabIndex = 3;
            this.label9.Text = "Today Customers";
            // 
            // tbOrdersTableAdapter
            // 
            this.tbOrdersTableAdapter.ClearBeforeFill = true;
            // 
            // martManagementSystemDataSet6
            // 
            this.martManagementSystemDataSet6.DataSetName = "MartManagementSystemDataSet6";
            this.martManagementSystemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbOrderHistoryBindingSource
            // 
            this.tbOrderHistoryBindingSource.DataMember = "tbOrderHistory";
            this.tbOrderHistoryBindingSource.DataSource = this.martManagementSystemDataSet6;
            // 
            // tbOrderHistoryTableAdapter
            // 
            this.tbOrderHistoryTableAdapter.ClearBeforeFill = true;
            // 
            // prodidDataGridViewTextBoxColumn
            // 
            this.prodidDataGridViewTextBoxColumn.DataPropertyName = "prod_id";
            this.prodidDataGridViewTextBoxColumn.HeaderText = "prod_id";
            this.prodidDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.prodidDataGridViewTextBoxColumn.Name = "prodidDataGridViewTextBoxColumn";
            this.prodidDataGridViewTextBoxColumn.ReadOnly = true;
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
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1748, 1317);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrdersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.martManagementSystemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOrderHistoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTotalUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTodayIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblDasboard;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private MartManagementSystemDataSet2 martManagementSystemDataSet2;
        private System.Windows.Forms.BindingSource tbOrdersBindingSource;
        private MartManagementSystemDataSet2TableAdapters.tbOrdersTableAdapter tbOrdersTableAdapter;
        private MartManagementSystemDataSet6 martManagementSystemDataSet6;
        private System.Windows.Forms.BindingSource tbOrderHistoryBindingSource;
        private MartManagementSystemDataSet6TableAdapters.tbOrderHistoryTableAdapter tbOrderHistoryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn origpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderdateDataGridViewTextBoxColumn;
    }
}
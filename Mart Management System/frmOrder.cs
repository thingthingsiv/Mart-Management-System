using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Mart_Management_System
{
    public partial class frmOrder : Form
    {
        private string connectionString = "Data Source=DESKTOP-6ULAPOO\\SQLEXPRESS;Initial Catalog=MartManagementSystem;Integrated Security=True;";
        private float totalOrderAmount = 0;

        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            this.tbProductsTableAdapter1.Fill(this.martManagementSystemDataSet5.tbProducts);
            LoadCategories();
            LoadProducts();
            LoadOrderData();
        }

        private void LoadCategories()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT category FROM tbCategories", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbocategory.DataSource = dt;
                cbocategory.DisplayMember = "category";
                cbocategory.ValueMember = "category";
                cbocategory.SelectedIndex = -1;
            }
        }

        private void LoadProducts()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT prod_id, prod_name, price FROM tbProducts", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cboproduct.DataSource = dt;
                cboproduct.DisplayMember = "prod_name";
                cboproduct.ValueMember = "prod_id";
                cboproduct.SelectedIndex = -1;
            }
        }

        private void LoadOrderData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT prod_id, prod_name, qty, orig_price, total_price FROM tbOrders", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewOrder.DataSource = dt;

                totalOrderAmount = 0;
                foreach (DataRow row in dt.Rows)
                {
                    totalOrderAmount += Convert.ToSingle(row["total_price"]);
                }
                lblTotalPrice1.Text = $" ${totalOrderAmount}";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbocategory.SelectedIndex == -1 || cboproduct.SelectedIndex == -1 || numericUpDown1.Value <= 0)
            {
                MessageBox.Show("Please select a category, product, and quantity.");
                return;
            }

            string productId = cboproduct.SelectedValue.ToString();
            string productName = cboproduct.Text;
            int qty = Convert.ToInt32(numericUpDown1.Value);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT price FROM tbProducts WHERE prod_id = @prod_id", conn);
                cmd.Parameters.AddWithValue("@prod_id", productId);
                conn.Open();
                float price = Convert.ToSingle(cmd.ExecuteScalar());

                Order order = new Order
                {
                    ProductId = int.Parse(productId),
                    ProductName = productName,
                    Quantity = qty,
                    Price = price
                };

                totalOrderAmount += order.TotalPrice;

                // Insert the order into the database
                string insertQuery = "INSERT INTO tbOrders (prod_id, prod_name, qty, orig_price, total_price, order_date) VALUES (@prod_id, @prod_name, @qty, @orig_price, @total_price, @order_date)";
                using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                {
                    insertCmd.Parameters.AddWithValue("@prod_id", order.ProductId);
                    insertCmd.Parameters.AddWithValue("@prod_name", order.ProductName);
                    insertCmd.Parameters.AddWithValue("@qty", order.Quantity);
                    insertCmd.Parameters.AddWithValue("@orig_price", order.Price);
                    insertCmd.Parameters.AddWithValue("@total_price", order.TotalPrice);
                    insertCmd.Parameters.AddWithValue("@order_date", DateTime.Now);
                    insertCmd.ExecuteNonQuery();
                }
                lblTotalPrice1.Text = $" ${totalOrderAmount}";
            }

            LoadOrderData();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAmount.Text) || !float.TryParse(txtAmount.Text, out float paidAmount) || paidAmount < totalOrderAmount)
            {
                MessageBox.Show("Please enter a valid amount greater than or equal to the total order amount.");
                return;
            }

            float change = paidAmount - totalOrderAmount;
            lblChange1.Text = $"${change}";
            MessageBox.Show("Order successfully paid!");
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Text files (*.txt)|*.txt|PDF files (*.pdf)|*.pdf", FileName = "Receipt.txt" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLine("********** RECEIPT **********");
                        sw.WriteLine("Date: " + DateTime.Now);
                        sw.WriteLine("Items:");

                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            SqlCommand cmd = new SqlCommand("SELECT prod_name, qty, orig_price, total_price FROM tbOrders", conn);
                            conn.Open();

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    int qty = Convert.ToInt32(reader["qty"]);
                                    float price = Convert.ToSingle(reader["orig_price"]);
                                    float total = Convert.ToSingle(reader["total_price"]);

                                    sw.WriteLine($"{prodName} - {qty} x ${price} = ${total}");
                                }
                            }
                        }

                        sw.WriteLine("----------------------------");
                        sw.WriteLine($"Total Amount: ${totalOrderAmount}");
                        sw.WriteLine("*****************************");
                    }

                    SaveOrderHistory();
                    MessageBox.Show("Receipt generated successfully!");

                    ClearOrderData();
                    ResetOrderForm();
                }
            }
        }

        private void SaveOrderHistory()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO tbOrderHistory (prod_id, prod_name, qty, orig_price, total_price, order_date) SELECT prod_id, prod_name, qty, orig_price, total_price, order_date FROM tbOrders", conn);
                cmd.ExecuteNonQuery();
            }
        }

        private void ClearOrderData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM tbOrders", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            LoadOrderData();
        }

        private void ResetOrderForm()
        {
            cbocategory.SelectedIndex = -1;
            cboproduct.SelectedIndex = -1;
            txtAmount.Clear();
            lblTotalPrice1.Text = " $0";
            lblChange1.Text = " $0";
            totalOrderAmount = 0;
            numericUpDown1.Value = 0;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewOrder.SelectedRows.Count > 0)
            {
                // Retrieve the product ID from the first selected row
                int productId = Convert.ToInt32(dataGridViewOrder.SelectedRows[0].Cells[0].Value);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM tbOrders WHERE prod_id = @prod_id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@prod_id", productId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                // Reload data and clear input fields
                LoadOrderData();
               
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }
            }

            // Optionally reset other controls like combo boxes, labels, etc.
            cbocategory.SelectedIndex = -1;
            cboproduct.SelectedIndex = -1;
            numericUpDown1.Value = 0;
            lblTotalPrice1.Text = " $0";
            lblChange1.Text = " $0";
            txtAmount.Clear();

        }
    }

  
}
